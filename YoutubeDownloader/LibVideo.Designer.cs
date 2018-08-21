namespace YoutubeDownloader
{
    partial class LibVideo
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
            this.tbLink = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVideoId = new System.Windows.Forms.Label();
            this.pbDownloading = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(34, 28);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(204, 20);
            this.tbLink.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(94, 63);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(84, 34);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbVideoId);
            this.panel1.Controls.Add(this.tbLink);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Location = new System.Drawing.Point(57, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 112);
            this.panel1.TabIndex = 2;
            // 
            // lbVideoId
            // 
            this.lbVideoId.AutoSize = true;
            this.lbVideoId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVideoId.Location = new System.Drawing.Point(34, 9);
            this.lbVideoId.Name = "lbVideoId";
            this.lbVideoId.Size = new System.Drawing.Size(69, 17);
            this.lbVideoId.TabIndex = 2;
            this.lbVideoId.Text = "Video URL";
            // 
            // pbDownloading
            // 
            this.pbDownloading.Location = new System.Drawing.Point(57, 159);
            this.pbDownloading.Name = "pbDownloading";
            this.pbDownloading.Size = new System.Drawing.Size(271, 23);
            this.pbDownloading.TabIndex = 3;
            // 
            // LibVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 194);
            this.Controls.Add(this.pbDownloading);
            this.Controls.Add(this.panel1);
            this.Name = "LibVideo";
            this.Text = "Lib Video";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVideoId;
        private System.Windows.Forms.ProgressBar pbDownloading;
    }
}

