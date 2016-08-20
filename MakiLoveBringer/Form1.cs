using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakiLoveBringer.Properties;
using xNet;
using Ini;

namespace MakiLoveBringer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipText = "MakiLoveBringer";
            notifyIcon1.BalloonTipTitle = "MakiLoveBringer";
            notifyIcon1.Text = "MakiLoveBringer";
            notifyIcon1.Icon = Properties.Resources.makiiii;
        }

        //windows_phone
        //private const string ACCESS_TOKEN = "dc8562d5e7457fefc0ea0ac77a4165fc3bf3fe2d88c01f7c02c13309959ca12cb2747b25db84d5733155f";
        
        //iphone
        //private const string ACCESS_TOKEN = "cffeaeb78b88986f32343cfd5e3d598eb3524ac39393ff0e0fda3bbd8111d5d61e139ed1ad2e9cd26cccb";

        private List<string> pictureList;
        private int uploadCount = 0;
        private int filesToUpload = 0;
        private string _message;
        private int interval;
        private int rawInterval;
        private DateTime SendTime;
        private bool isSending;
        private IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "settings.ini"));
        private string AccessToken;
        private string group_id;
        private string repost_group_id;
        private int doRepost;

        private void ShowBaloonTip(int duration, string message, ToolTipIcon icon)
        {
            notifyIcon1.ShowBalloonTip(duration, "MakiLoveBringer", message, icon);
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {

            pictureList = new List<string>();

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picturesFolderTB.Text = fbd.SelectedPath;
                var files = Directory.GetFiles(fbd.SelectedPath, "*.*").Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".jpeg"));

                foreach (string file in files)
                {
                    var length = new FileInfo(file).Length;
                    if (length > 1000)
                        pictureList.Add(file);
                }
                startBTN.Enabled = true;

                filesToUploadLBL.Text = "files to upload: " + pictureList.Count.ToString();
                statusLBL.Text = "status: waiting for start...";
            } 
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            if (startBTN.Text == "Start")
            {
                if (int.Parse(intervalTB.Text) > 0)
                {
                    _message = Uri.EscapeDataString(messageTB.Text);
                    filesToUpload = pictureList.Count;
                    filesToUploadLBL.Text = "files to upload: " + filesToUpload;
                    startBTN.Text = "Stop";
                    interval = int.Parse(intervalTB.Text) * 1000;
                    rawInterval = int.Parse(intervalTB.Text);
                    mainTimer.Interval = interval;
                    mainTimer.Start();
                    SendTime = DateTime.Now.AddMilliseconds(mainTimer.Interval);
                    statusUpdateTimer.Start();
                    statusLBL.Text = "status: waiting...";
                }
            }

            else
            {
                startBTN.Text = "Start";
                mainTimer.Stop();
                statusUpdateTimer.Stop();
            }   
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            SendTime = DateTime.Now.AddMilliseconds(mainTimer.Interval);
            Thread t = new Thread(() => uploadShit());
            t.IsBackground = true;
            t.Start();
        }

        private void statusUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!isSending)
            {
                TimeSpan nextUpload = SendTime - DateTime.Now;
                nextUploadLBL.Text = string.Format("time till next upload: {0}h {1}m {2}s", nextUpload.Hours, nextUpload.Minutes, nextUpload.Seconds);
            }
        }

        private void uploadShit()
        {
            statusLBL.Invoke(new MethodInvoker(() => statusLBL.Text = "status: uploading..."));
            isSending = true;
            string resp = string.Empty;
            string lastUploadedItem = string.Empty;
            lastUploadedItem = pictureList[0];
            pictureList.RemoveAt(0);

            resp = vk_requests.doWallPhotoUpload(group_id, AccessToken, _message, lastUploadedItem, true);

            if (resp != null)
            {
                if (doRepost == 1)
                {
                    statusLBL.Invoke(new MethodInvoker(() => statusLBL.Text = "status: reposting..."));
                    string repost_obj = "wall-" + group_id + "_" + resp;
                    vk_requests.doRepost(repost_obj, "", repost_group_id, AccessToken);
                }

                if (pictureList.Count > 0)
                {
                    isSending = false;
                    var uploadTime = DateTime.Now;
                    uploadCount++;
                    filesToUpload = pictureList.Count;
                    uploadCountLBL.Invoke(new MethodInvoker(() => uploadCountLBL.Text = "upload count: " + uploadCount));
                    filesToUploadLBL.Invoke(new MethodInvoker(() => filesToUploadLBL.Text = "files to upload: " + filesToUpload));
                    statusLBL.Invoke(new MethodInvoker(() => statusLBL.Text = "status: waiting..."));
                }

                else
                {
                    isSending = false;
                    var uploadTime = DateTime.Now;
                    uploadCount++;
                    filesToUpload = 0;
                    uploadCountLBL.Invoke(new MethodInvoker(() => uploadCountLBL.Text = "upload count: " + uploadCount));
                    filesToUploadLBL.Invoke(new MethodInvoker(() => filesToUploadLBL.Text = "files to upload: " + filesToUpload));
                    statusLBL.Invoke(new MethodInvoker(() => statusLBL.Text = "status: waiting..."));

                    new SoundPlayer(Properties.Resources.Tutturuu_).Play();

                    mainTimer.Stop();
                    statusUpdateTimer.Stop();

                    startBTN.Invoke(new MethodInvoker(() => startBTN.Text = "Start"));
                    ShowBaloonTip(5000, "Everything is uploaded!", ToolTipIcon.Info);
                }
            }

            else
            {
                statusLBL.Invoke(new MethodInvoker(() => statusLBL.Text = "status: error while uploading"));
                isSending = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "settings.ini")))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[Settings]" + Environment.NewLine);
                sb.Append("AccessToken=" + Environment.NewLine);
                sb.Append("GroupID=" + Environment.NewLine);
                sb.Append("DoRepost=" + Environment.NewLine);
                sb.Append("RepostGroupID=" + Environment.NewLine);
                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "settings.ini")))
                {
                    sw.WriteLine(sb.ToString());
                    sw.Close();
                }
                MessageBox.Show("Please configure settings.ini file in your program's directory");
                Application.Exit();
            }

            else
            {
                int result;
                AccessToken = ini.IniReadValue("Settings", "AccessToken");
                group_id = ini.IniReadValue("Settings", "GroupID");
                bool success = int.TryParse((ini.IniReadValue("Settings", "DoRepost")), out result);
                repost_group_id = ini.IniReadValue("Settings", "RepostGroupID");

                if (string.IsNullOrEmpty(AccessToken) || string.IsNullOrEmpty(group_id) || !success)
                {
                    MessageBox.Show("config is incorrect. configure settings.ini in the same folder as your program");
                    Application.Exit();
                }
                else
                {
                    doRepost = result;
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }
    }
}
