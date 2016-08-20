namespace MakiLoveBringer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Pigment pigment1 = new Pigment();
            Pigment pigment2 = new Pigment();
            Pigment pigment3 = new Pigment();
            Pigment pigment4 = new Pigment();
            Pigment pigment5 = new Pigment();
            Pigment pigment6 = new Pigment();
            Pigment pigment7 = new Pigment();
            Pigment pigment8 = new Pigment();
            Pigment pigment9 = new Pigment();
            Pigment pigment10 = new Pigment();
            Pigment pigment11 = new Pigment();
            Pigment pigment12 = new Pigment();
            Pigment pigment13 = new Pigment();
            Pigment pigment14 = new Pigment();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.stTheme1 = new STTheme();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stGroupBox2 = new STGroupBox();
            this.statusLBL = new STLabel();
            this.nextUploadLBL = new STLabel();
            this.uploadCountLBL = new STLabel();
            this.filesToUploadLBL = new STLabel();
            this.stGroupBox1 = new STGroupBox();
            this.stLabel4 = new STLabel();
            this.messageTB = new STTextBox();
            this.startBTN = new sexyButton();
            this.stLabel3 = new STLabel();
            this.intervalTB = new STTextBox();
            this.browseBTN = new sexyButton();
            this.stLabel2 = new STLabel();
            this.picturesFolderTB = new STTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stLabel1 = new STLabel();
            this.stTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.stGroupBox2.SuspendLayout();
            this.stGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Interval = 1000;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // stTheme1
            // 
            this.stTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(253)))));
            this.stTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.stTheme1.Controls.Add(this.pictureBox2);
            this.stTheme1.Controls.Add(this.stGroupBox2);
            this.stTheme1.Controls.Add(this.stGroupBox1);
            this.stTheme1.Controls.Add(this.pictureBox1);
            this.stTheme1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.stTheme1.Margin = new System.Windows.Forms.Padding(0);
            this.stTheme1.Name = "stTheme1";
            this.stTheme1.Radius = 5;
            this.stTheme1.Size = new System.Drawing.Size(545, 393);
            this.stTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.stTheme1.Title = "                                                Maki Love Bringer";
            this.stTheme1.TitleColorBack = System.Drawing.Color.Black;
            this.stTheme1.TitleColorFront = System.Drawing.Color.White;
            this.stTheme1.TopMost = false;
            this.stTheme1.TransparencyKey = System.Drawing.Color.Magenta;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MakiLoveBringer.Properties.Resources.closeButton11;
            this.pictureBox2.Location = new System.Drawing.Point(517, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stGroupBox2
            // 
            this.stGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(253)))));
            this.stGroupBox2.Controls.Add(this.statusLBL);
            this.stGroupBox2.Controls.Add(this.nextUploadLBL);
            this.stGroupBox2.Controls.Add(this.uploadCountLBL);
            this.stGroupBox2.Controls.Add(this.filesToUploadLBL);
            this.stGroupBox2.Description = "";
            this.stGroupBox2.DescriptionAlign = STGroupBox.DescriptionAligns.Underneath;
            this.stGroupBox2.DescriptionBackColor = System.Drawing.Color.Black;
            this.stGroupBox2.DescriptionColor = System.Drawing.Color.White;
            this.stGroupBox2.DescriptionFont = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic);
            this.stGroupBox2.DrawSeperator = true;
            this.stGroupBox2.Location = new System.Drawing.Point(12, 257);
            this.stGroupBox2.Name = "stGroupBox2";
            this.stGroupBox2.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stGroupBox2.OutlineThickness = 1;
            this.stGroupBox2.Radius = 3;
            this.stGroupBox2.SeperatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.stGroupBox2.SeperatorThickness = 2;
            this.stGroupBox2.Size = new System.Drawing.Size(296, 117);
            this.stGroupBox2.Title = "Info";
            this.stGroupBox2.TitleBackColor = System.Drawing.Color.DeepPink;
            this.stGroupBox2.TitleColor = System.Drawing.Color.Black;
            this.stGroupBox2.TitleFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            // 
            // statusLBL
            // 
            this.statusLBL.Font = new System.Drawing.Font("Verdana", 8F);
            this.statusLBL.Location = new System.Drawing.Point(12, 91);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(152, 14);
            this.statusLBL.Text = "status: waiting for folder...";
            this.statusLBL.TextColor = System.Drawing.Color.Black;
            this.statusLBL.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // nextUploadLBL
            // 
            this.nextUploadLBL.Font = new System.Drawing.Font("Verdana", 8F);
            this.nextUploadLBL.Location = new System.Drawing.Point(12, 71);
            this.nextUploadLBL.Name = "nextUploadLBL";
            this.nextUploadLBL.Size = new System.Drawing.Size(119, 14);
            this.nextUploadLBL.Text = "time till next upload: ";
            this.nextUploadLBL.TextColor = System.Drawing.Color.Black;
            this.nextUploadLBL.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // uploadCountLBL
            // 
            this.uploadCountLBL.Font = new System.Drawing.Font("Verdana", 8F);
            this.uploadCountLBL.Location = new System.Drawing.Point(12, 51);
            this.uploadCountLBL.Name = "uploadCountLBL";
            this.uploadCountLBL.Size = new System.Drawing.Size(79, 14);
            this.uploadCountLBL.Text = "upload count: ";
            this.uploadCountLBL.TextColor = System.Drawing.Color.Black;
            this.uploadCountLBL.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // filesToUploadLBL
            // 
            this.filesToUploadLBL.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesToUploadLBL.Location = new System.Drawing.Point(12, 31);
            this.filesToUploadLBL.Name = "filesToUploadLBL";
            this.filesToUploadLBL.Size = new System.Drawing.Size(89, 14);
            this.filesToUploadLBL.Text = "files to upload: ";
            this.filesToUploadLBL.TextColor = System.Drawing.Color.Black;
            this.filesToUploadLBL.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // stGroupBox1
            // 
            this.stGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(253)))));
            this.stGroupBox1.Controls.Add(this.stLabel4);
            this.stGroupBox1.Controls.Add(this.messageTB);
            this.stGroupBox1.Controls.Add(this.startBTN);
            this.stGroupBox1.Controls.Add(this.stLabel3);
            this.stGroupBox1.Controls.Add(this.intervalTB);
            this.stGroupBox1.Controls.Add(this.browseBTN);
            this.stGroupBox1.Controls.Add(this.stLabel2);
            this.stGroupBox1.Controls.Add(this.picturesFolderTB);
            this.stGroupBox1.Description = "";
            this.stGroupBox1.DescriptionAlign = STGroupBox.DescriptionAligns.Underneath;
            this.stGroupBox1.DescriptionBackColor = System.Drawing.SystemColors.Highlight;
            this.stGroupBox1.DescriptionColor = System.Drawing.Color.DimGray;
            this.stGroupBox1.DescriptionFont = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic);
            this.stGroupBox1.DrawSeperator = true;
            this.stGroupBox1.Location = new System.Drawing.Point(12, 32);
            this.stGroupBox1.Name = "stGroupBox1";
            this.stGroupBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.stGroupBox1.OutlineThickness = 1;
            this.stGroupBox1.Radius = 3;
            this.stGroupBox1.SeperatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.stGroupBox1.SeperatorThickness = 2;
            this.stGroupBox1.Size = new System.Drawing.Size(296, 210);
            this.stGroupBox1.Title = "Settings";
            this.stGroupBox1.TitleBackColor = System.Drawing.Color.DeepPink;
            this.stGroupBox1.TitleColor = System.Drawing.Color.Black;
            this.stGroupBox1.TitleFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            // 
            // stLabel4
            // 
            this.stLabel4.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel4.Location = new System.Drawing.Point(13, 107);
            this.stLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.stLabel4.Name = "stLabel4";
            this.stLabel4.Size = new System.Drawing.Size(50, 14);
            this.stLabel4.Text = "Message";
            this.stLabel4.TextColor = System.Drawing.Color.Black;
            this.stLabel4.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // messageTB
            // 
            this.messageTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.messageTB.BackColorBottom = System.Drawing.SystemColors.HighlightText;
            this.messageTB.BackColorTop = System.Drawing.SystemColors.HighlightText;
            this.messageTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTB.Font = new System.Drawing.Font("Verdana", 8F);
            this.messageTB.ForeColor = System.Drawing.Color.Black;
            this.messageTB.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.messageTB.Location = new System.Drawing.Point(12, 127);
            this.messageTB.Name = "messageTB";
            this.messageTB.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.messageTB.PasswordChar = '\0';
            this.messageTB.Radius = 3;
            this.messageTB.Size = new System.Drawing.Size(276, 21);
            this.messageTB.TabIndex = 8;
            // 
            // startBTN
            // 
            pigment1.Name = "Border";
            pigment1.Value = System.Drawing.Color.Black;
            pigment2.Name = "Backcolor";
            pigment2.Value = System.Drawing.Color.White;
            pigment3.Name = "Highlight";
            pigment3.Value = System.Drawing.Color.White;
            pigment4.Name = "Gradient1";
            pigment4.Value = System.Drawing.SystemColors.HighlightText;
            pigment5.Name = "Gradient2";
            pigment5.Value = System.Drawing.Color.HotPink;
            pigment6.Name = "Text Color";
            pigment6.Value = System.Drawing.Color.Black;
            pigment7.Name = "Text Shadow";
            pigment7.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startBTN.Colors = new Pigment[] {
        pigment1,
        pigment2,
        pigment3,
        pigment4,
        pigment5,
        pigment6,
        pigment7};
            this.startBTN.Enabled = false;
            this.startBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.startBTN.Location = new System.Drawing.Point(199, 170);
            this.startBTN.Name = "startBTN";
            this.startBTN.Shadow = true;
            this.startBTN.Size = new System.Drawing.Size(89, 27);
            this.startBTN.TabIndex = 5;
            this.startBTN.Text = "Start";
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stLabel3
            // 
            this.stLabel3.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel3.Location = new System.Drawing.Point(12, 159);
            this.stLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.stLabel3.Name = "stLabel3";
            this.stLabel3.Size = new System.Drawing.Size(46, 14);
            this.stLabel3.Text = "Interval";
            this.stLabel3.TextColor = System.Drawing.Color.Black;
            this.stLabel3.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // intervalTB
            // 
            this.intervalTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.intervalTB.BackColorBottom = System.Drawing.SystemColors.HighlightText;
            this.intervalTB.BackColorTop = System.Drawing.SystemColors.HighlightText;
            this.intervalTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.intervalTB.Font = new System.Drawing.Font("Verdana", 8F);
            this.intervalTB.ForeColor = System.Drawing.Color.Black;
            this.intervalTB.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.intervalTB.Location = new System.Drawing.Point(12, 176);
            this.intervalTB.Name = "intervalTB";
            this.intervalTB.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.intervalTB.PasswordChar = '\0';
            this.intervalTB.Radius = 3;
            this.intervalTB.Size = new System.Drawing.Size(51, 21);
            this.intervalTB.TabIndex = 3;
            // 
            // browseBTN
            // 
            this.browseBTN.BackColor = System.Drawing.Color.White;
            pigment8.Name = "Border";
            pigment8.Value = System.Drawing.Color.Black;
            pigment9.Name = "Backcolor";
            pigment9.Value = System.Drawing.Color.White;
            pigment10.Name = "Highlight";
            pigment10.Value = System.Drawing.Color.White;
            pigment11.Name = "Gradient1";
            pigment11.Value = System.Drawing.SystemColors.HighlightText;
            pigment12.Name = "Gradient2";
            pigment12.Value = System.Drawing.Color.HotPink;
            pigment13.Name = "Text Color";
            pigment13.Value = System.Drawing.Color.Black;
            pigment14.Name = "Text Shadow";
            pigment14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.browseBTN.Colors = new Pigment[] {
        pigment8,
        pigment9,
        pigment10,
        pigment11,
        pigment12,
        pigment13,
        pigment14};
            this.browseBTN.Font = new System.Drawing.Font("Verdana", 8F);
            this.browseBTN.Location = new System.Drawing.Point(199, 79);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Shadow = true;
            this.browseBTN.Size = new System.Drawing.Size(89, 27);
            this.browseBTN.TabIndex = 1;
            this.browseBTN.Text = "Browse";
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // stLabel2
            // 
            this.stLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel2.Location = new System.Drawing.Point(12, 32);
            this.stLabel2.Name = "stLabel2";
            this.stLabel2.Size = new System.Drawing.Size(82, 14);
            this.stLabel2.Text = "Pictures folder";
            this.stLabel2.TextColor = System.Drawing.Color.Black;
            this.stLabel2.TextColorBack = System.Drawing.Color.HotPink;
            // 
            // picturesFolderTB
            // 
            this.picturesFolderTB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picturesFolderTB.BackColorBottom = System.Drawing.SystemColors.HighlightText;
            this.picturesFolderTB.BackColorTop = System.Drawing.SystemColors.HighlightText;
            this.picturesFolderTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picturesFolderTB.Font = new System.Drawing.Font("Verdana", 8F);
            this.picturesFolderTB.ForeColor = System.Drawing.Color.Black;
            this.picturesFolderTB.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.picturesFolderTB.Location = new System.Drawing.Point(12, 52);
            this.picturesFolderTB.Name = "picturesFolderTB";
            this.picturesFolderTB.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.picturesFolderTB.PasswordChar = '\0';
            this.picturesFolderTB.Radius = 3;
            this.picturesFolderTB.Size = new System.Drawing.Size(276, 21);
            this.picturesFolderTB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MakiLoveBringer.Properties.Resources.maki5555;
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 355);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stLabel1
            // 
            this.stLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.stLabel1.Location = new System.Drawing.Point(3, 35);
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(93, 14);
            this.stLabel1.TextColor = System.Drawing.Color.White;
            this.stLabel1.TextColorBack = System.Drawing.Color.Black;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 382);
            this.Controls.Add(this.stTheme1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                Maki Love Bringer";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stTheme1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.stGroupBox2.ResumeLayout(false);
            this.stGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private STTheme stTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private STGroupBox stGroupBox1;
        private STLabel stLabel1;
        private STLabel stLabel2;
        private STTextBox picturesFolderTB;
        private sexyButton browseBTN;
        private STTextBox intervalTB;
        private STLabel stLabel3;
        private sexyButton startBTN;
        private STLabel stLabel4;
        private STTextBox messageTB;
        private STGroupBox stGroupBox2;
        private STLabel statusLBL;
        private STLabel nextUploadLBL;
        private STLabel uploadCountLBL;
        private STLabel filesToUploadLBL;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

