namespace YoutubeDownloader
{
    partial class MainForm
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
            this.btYoutubeDownloader = new System.Windows.Forms.Button();
            this.btnLibVideo = new System.Windows.Forms.Button();
            this.btnYoutubeExplode = new System.Windows.Forms.Button();
            this.tbDownloadFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btYoutubeDownloader
            // 
            this.btYoutubeDownloader.Location = new System.Drawing.Point(61, 35);
            this.btYoutubeDownloader.Name = "btYoutubeDownloader";
            this.btYoutubeDownloader.Size = new System.Drawing.Size(127, 23);
            this.btYoutubeDownloader.TabIndex = 0;
            this.btYoutubeDownloader.Text = "Youtube Extractor";
            this.btYoutubeDownloader.UseVisualStyleBackColor = true;
            this.btYoutubeDownloader.Click += new System.EventHandler(this.btYoutubeDownloader_Click);
            // 
            // btnLibVideo
            // 
            this.btnLibVideo.Location = new System.Drawing.Point(59, 73);
            this.btnLibVideo.Name = "btnLibVideo";
            this.btnLibVideo.Size = new System.Drawing.Size(127, 23);
            this.btnLibVideo.TabIndex = 1;
            this.btnLibVideo.Text = "Lib Video";
            this.btnLibVideo.UseVisualStyleBackColor = true;
            this.btnLibVideo.Click += new System.EventHandler(this.btnLibVideo_Click);
            // 
            // btnYoutubeExplode
            // 
            this.btnYoutubeExplode.Location = new System.Drawing.Point(61, 112);
            this.btnYoutubeExplode.Name = "btnYoutubeExplode";
            this.btnYoutubeExplode.Size = new System.Drawing.Size(127, 23);
            this.btnYoutubeExplode.TabIndex = 2;
            this.btnYoutubeExplode.Text = "Youtube Explode";
            this.btnYoutubeExplode.UseVisualStyleBackColor = true;
            this.btnYoutubeExplode.Click += new System.EventHandler(this.btnYoutubeExplode_Click);
            // 
            // tbDownloadFolder
            // 
            this.tbDownloadFolder.Location = new System.Drawing.Point(21, 189);
            this.tbDownloadFolder.Name = "tbDownloadFolder";
            this.tbDownloadFolder.Size = new System.Drawing.Size(221, 20);
            this.tbDownloadFolder.TabIndex = 3;
            this.tbDownloadFolder.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Download folder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDownloadFolder);
            this.Controls.Add(this.btnYoutubeExplode);
            this.Controls.Add(this.btnLibVideo);
            this.Controls.Add(this.btYoutubeDownloader);
            this.Name = "MainForm";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYoutubeDownloader;
        private System.Windows.Forms.Button btnLibVideo;
        private System.Windows.Forms.Button btnYoutubeExplode;
        private System.Windows.Forms.TextBox tbDownloadFolder;
        private System.Windows.Forms.Label label1;
    }
}