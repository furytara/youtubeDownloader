using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace YoutubeDownloader
{
    public partial class YoutubeExtrator : Form
    {
        private string _link { get; set; }
        private readonly string DOWNLOAD_FOLDER = Settings.DownloadFolder + "/youtubeextractor"; 

        public YoutubeExtrator()
        {
            InitializeComponent();

            if (!Directory.Exists(DOWNLOAD_FOLDER))
            {
                Directory.CreateDirectory(DOWNLOAD_FOLDER);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _link = this.tbLink.Text;

            try
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(_link);

                /*
                 * Select the first .mp4 video with 360p resolution
                 */
                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4);


                /*
                 * If the video has a decrypted signature, decipher it
                 */
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }

                /*
                 * Create the video downloader.
                 * The first argument is the video to download.
                 * The second argument is the path to save the video file.
                 */
                var videoDownloader = new VideoDownloader(video, Path.Combine(DOWNLOAD_FOLDER, "yt_extractor_" + video.Title + video.VideoExtension));

                // Register the ProgressChanged event and print the current progress
                videoDownloader.DownloadProgressChanged += videoDownloader_DownloadProgressChanged;

                /*
                 * Execute the video downloader.
                 * For GUI applications note, that this method runs synchronously.
                 */
                videoDownloader.Execute();

                MessageBox.Show("Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void videoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            pbDownloading.Value = (int)e.ProgressPercentage;
        }
    }
}
