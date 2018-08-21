using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            Settings.DownloadFolder = this.tbDownloadFolder.Text;
            this.tbDownloadFolder.TextChanged += tbDownloadFolder_TextChanged;
        }

        void tbDownloadFolder_TextChanged(object sender, EventArgs e)
        {
            Settings.DownloadFolder = this.tbDownloadFolder.Text;
        }

        private void btYoutubeDownloader_Click(object sender, EventArgs e)
        {
            var youtubeExtractor = new YoutubeExtrator();
            youtubeExtractor.ShowDialog(this);
        }

        private void btnLibVideo_Click(object sender, EventArgs e)
        {
            var libVideo = new LibVideo();
            libVideo.ShowDialog(this);
        }

        private void btnYoutubeExplode_Click(object sender, EventArgs e)
        {
            var youtubeExplode = new YoutubeExplode();
            youtubeExplode.ShowDialog(this);
        }
    }
}
