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
using VideoLibrary;

namespace YoutubeDownloader
{
    public partial class LibVideo : Form
    {
        private string _link { get; set; }
        private readonly string DOWNLOAD_FOLDER = Settings.DownloadFolder + "/libvideo"; 

        public LibVideo()
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

            await SaveVideoToDiskAsync(_link);

            MessageBox.Show("Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task SaveVideoToDiskAsync(string link)
        {            
            using (var service = Client.For(YouTube.Default))
            {
                var video = await service.GetVideoAsync(link);

                var bytes = await video.GetBytesAsync();

                File.WriteAllBytes(Path.Combine(DOWNLOAD_FOLDER, "libvideo_" + video.FullName), bytes);
            }            
        }

        private void SaveVideoToDisk(string link)
        {
            string path = @"D:\Download\libvideo";

            using (var service = Client.For(YouTube.Default))
            {
                var video = service.GetVideo(link);

                File.WriteAllBytes(Path.Combine("D:/Download/libvideo", video.FullName), video.GetBytes());
            }
        }

        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
