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
using YoutubeExplode;
using YoutubeExtractor;

namespace YoutubeDownloader
{
    public partial class YoutubeExplode : Form
    {
        private string _link { get; set; }
        private readonly string DOWNLOAD_FOLDER = Settings.DownloadFolder + "/youtubeexplode"; 

        public YoutubeExplode()
        {
            InitializeComponent();

            if (!Directory.Exists(DOWNLOAD_FOLDER))
            {
                Directory.CreateDirectory(DOWNLOAD_FOLDER);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _link = this.tbLink.Text;
            var id = YoutubeClient.ParseVideoId(_link);

            await GetVideoInfoAsync(id);
        }

        private async Task GetVideoInfoAsync(string id)
        {
            var client = new YoutubeClient();
            var video = await client.GetVideoAsync(id);

            var title = video.Title; // "Infected Mushroom - Spitfire [Monstercat Release]"
            var author = video.Author; // "Monstercat"
            var duration = video.Duration; // 00:07:14
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            _link = this.tbLink.Text;
            var id = YoutubeClient.ParseVideoId(_link);

            await GetClosedCaptionTrackAsync(id);
        }

        private async Task GetClosedCaptionTrackAsync(string id)
        {
            var client = new YoutubeClient();            

            var trackInfos = await client.GetVideoClosedCaptionTrackInfosAsync(id);

            var trackInfo = trackInfos.First(t => t.Language.Code == "en");
            var track = await client.GetClosedCaptionTrackAsync(trackInfo);

            var caption = track.Captions;
            //var text = caption.Text; // "And the game was afoot."
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            _link = this.tbLink.Text;
            var id = YoutubeClient.ParsePlaylistId(_link);

            await GetPlaylistAsync(id);
        }

        private async Task GetPlaylistAsync(string id)
        {
            var client = new YoutubeClient();
            var playlist = await client.GetPlaylistAsync(id);

            var title = playlist.Title; // "Igorrr - Hallelujah"
            var author = playlist.Author; // "randomusername604"

            var video = playlist.Videos.First();
            var videoTitle = video.Title; // "Igorrr - Tout Petit Moineau"
            var videoAuthor = video.Author; // "Igorrr Official"
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            _link = this.tbLink.Text;
            var id = YoutubeClient.ParseVideoId(_link);

            await DownloadAsync(id);

            MessageBox.Show("Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task DownloadAsync(string id)
        {            
            var client = new YoutubeClient();
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);

            var streamInfo = streamInfoSet.Muxed;

            var highestVideoMediaQuality = streamInfo.FirstOrDefault();
            string name = id + ".mp4";

            await client.DownloadMediaStreamAsync(highestVideoMediaQuality, Path.Combine(DOWNLOAD_FOLDER, name));
        }
    }
}
