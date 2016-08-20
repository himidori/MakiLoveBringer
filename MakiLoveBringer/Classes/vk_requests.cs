using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace MakiLoveBringer
{
    public static class vk_requests
    {
        public static string doWallPost(string uId, string token, string message)
        {
            using (var req = new HttpRequest())
            {
                string resp = req.Get(string.Format("https://api.vk.com/method/wall.post?owner_id={0}&message={1}&access_token={2}", uId, message, token)).ToString();
                return resp;
            }
        }

        public static string doWallPhotoUpload(string uId, string token, string message, string imagePath, bool isGroup)
        {
            string url = string.Empty;
            string extension = imagePath.Substring(imagePath.LastIndexOf('.'));

            using (var req = new HttpRequest())
            {
                string src = string.Empty;

                if (isGroup)
                {
                    src = req.Get(string.Format("https://api.vk.com/method/photos.getWallUploadServer?group_id={0}&access_token={1}", uId, token)).ToString();
                }
                else
                {
                    src = req.Get(string.Format("https://api.vk.com/method/photos.getWallUploadServer?user_id={0}&access_token={1}", uId, token)).ToString();
                }

                url = src.Substrings("\"upload_url\":", "\",")[0].Replace(@"\/", "/").Substring(1);
            }

            FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();

            Dictionary<string, object> postParameters = new Dictionary<string, object>();
            postParameters.Add("filename", imagePath);
            postParameters.Add("fileformat", extension);
            postParameters.Add("file", new FormUpload.FileParameter(data, imagePath, "image/" + extension));

            HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(url, Http.ChromeUserAgent(), postParameters);

            StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
            string fullResponse = responseReader.ReadToEnd();
            webResponse.Close();

            JToken jtoken = JToken.Parse(fullResponse);

            string server = jtoken["server"].ToString();
            string photo = jtoken["photo"].ToString();
            string hash = jtoken["hash"].ToString();

            HttpRequest request = new HttpRequest();

            string finalResponse = string.Empty;

            if (isGroup)
            {
                finalResponse = request.Get(string.Format("https://api.vk.com/method/photos.saveWallPhoto?group_id={0}&photo={1}&server={2}&hash={3}&access_token={4}", uId, photo, server, hash, token)).ToString();
            }

            else
            {
                finalResponse = request.Get(string.Format("https://api.vk.com/method/photos.saveWallPhoto?user_id={0}&photo={1}&server={2}&hash={3}&access_token={4}", uId, photo, server, hash, token)).ToString();
            }
            string photoId = finalResponse.Substrings("\"id\":\"", "\",")[0];
            string resp = string.Empty;

            if (isGroup)
            {
                resp = request.Get(string.Format("https://api.vk.com/method/wall.post?owner_id={0}&message={1}&access_token={2}&attachments={3}&from_group=1&signed=0", uId.Insert(0, "-"), message, token, photoId)).ToString();

                if (!resp.Contains("error_msg"))
                {
                    resp = resp.Substring("\"post_id\":", "}");
                    return resp;
                }

                else
                    return null;
            }
            else
            {
                resp = request.Get(string.Format("https://api.vk.com/method/wall.post?owner_id={0}&message{1}access_token={2}&&attachments={3}", uId, message, token, photoId)).ToString();

                if (!resp.Contains("error_msg"))
                {
                    resp = resp.Substring("\"post_id\":", "}");
                    return resp;
                }

                else
                    return null;
            }

        }

        public static string doWallDocUpload(string uId, string token, string message, string docPath)
        {
            string url = string.Empty;
            using (var req = new HttpRequest())
            {
                string src = req.Get(string.Format("https://api.vk.com/method/docs.getWallUploadServer?group_id={0}&access_token={1}", uId, token)).ToString();
                url = src.Substrings("\"upload_url\":", "}")[0].Replace(@"\/", "/").Replace("\"", "");
            }

            FileStream fs = new FileStream(docPath, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();

            Dictionary<string, object> postParameters = new Dictionary<string, object>();
            postParameters.Add("filename", docPath);
            postParameters.Add("fileformat", ".gif");
            postParameters.Add("file", new FormUpload.FileParameter(data, docPath, "image/gif"));

            HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(url, Http.ChromeUserAgent(), postParameters);

            StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
            string fullResponse = responseReader.ReadToEnd();
            webResponse.Close();

            JToken jtoken = JToken.Parse(fullResponse);
            string file = jtoken["file"].ToString();

            HttpRequest request = new HttpRequest();

            string finalResponse = string.Empty;
            finalResponse = request.Get(string.Format("https://api.vk.com/method/docs.save?file={0}&access_token={1}", file, token)).ToString();

            string did = "doc-" + finalResponse.Substring("\"url\":", "?").Split('-')[1];

            string docId = did.Split('_')[1];

            string resp = request.Get(string.Format("https://api.vk.com/method/wall.post?owner_id={0}&message={1}&access_token={2}&attachments={3}&from_group=1&signed=1", uId.Insert(0, "-"), message, token, did)).ToString();

            request.Get(string.Format("https://api.vk.com/method/docs.delete?owner_id={0}&doc_id={1}&access_token={2}", uId.Insert(0, "-"), docId, token));


            return resp;
        }

        public static void doRepost(string obj, string message, string group_id, string token)
        {
            using (var request = new HttpRequest())
            {
                request.Get(string.Format("https://api.vk.com/method/wall.repost?object={0}&message={1}&group_id={2}&access_token={3}", obj, message, group_id, token));
            }
        }
    }
}
