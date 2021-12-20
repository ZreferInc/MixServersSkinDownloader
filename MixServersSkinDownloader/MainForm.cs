using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MixServersSkinDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DwnldBtn_Click(object sender, System.EventArgs e) => Download();

        private void NickTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Download();
        }

        private void NickTB_TextChanged(object sender, System.EventArgs e)
        {
            NickTB.Text = Regex.Replace(NickTB.Text, "[\r ]+", "");
            NickTB.SelectionStart = NickTB.Text.Length;
            NickTB.SelectionLength = 0;
        }

        private void Download()
        {
            string URI = $"http://files.mix-servers.com/web/{(SkinRB.Checked ? "skins" : "cloaks")}/{NickTB.Text}.png";
            string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36";

            using HttpClient Client = new();
            using HttpRequestMessage Message = new(HttpMethod.Get, URI);
            Message.Headers.UserAgent.ParseAdd(UserAgent);
            Message.Headers.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");

            try
            {
                HttpResponseMessage Response =
                    Client.SendAsync(Message, HttpCompletionOption.ResponseContentRead).Result;
                if (Response.StatusCode == HttpStatusCode.NotFound)
                {
                    Error($"{(SkinRB.Checked ? "Скин" : "Плащ")} по этому никнейму не был найден");
                    return;
                }

                byte[] ImageBytes = Response.Content.ReadAsByteArrayAsync().Result;
                using MemoryStream ms = new(ImageBytes);

                SaveFileDialog SaveDialog = new()
                {
                    DefaultExt = ".png",
                    FileName = $"{NickTB.Text}_{(SkinRB.Checked ? "skin" : "cloak")}.png",
                    Filter = "PNG Files|*.png",
                    RestoreDirectory = true,
                    Title = $"Сохранить {(SkinRB.Checked ? "скин" : "плащ")} игрока {NickTB.Text}"
                };
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image.FromStream(ms).Save(SaveDialog.FileName, ImageFormat.Png);
                    }
                    catch (Exception ie)
                    {
                        throw new BadImageFormatException(ie.Message);
                    }
                }
            }
            catch (AggregateException ae)
            {
                if (ae.InnerException is HttpRequestException hre)
                    Error($"Ошибка скачивания файла с сервера:\n{hre.Message}");
            }
            catch (BadImageFormatException bife)
            {
                Error($"Был скачан неверный формат изображения с сервера\nСообщение об ошибке:\n{bife.Message}");
            }
            catch (Exception e)
            {
                Error($"Неизвестная ошибка:\n{e.Message}");
            }
        }

        private void Error(string Message) => MessageBox.Show(Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}