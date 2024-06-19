using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await LoadFtpDirectoryAsync(tbHost.Text);
        }

        private async Task LoadFtpDirectoryAsync(string url)
        {
            FadList.Items.Clear();
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = await reader.ReadLineAsync();
                            string formattedLine = FormatFtpLine(line);
                            FadList.Items.Add(formattedLine);
                        }
                    }
                }
            }
        }

        private string FormatFtpLine(string line)
        {
            string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 9)
            {
                return line;
            }
            string permissions = tokens[0];
            string hardLinks = tokens[1];
            string owner = tokens[2];
            string group = tokens[3];
            string size = tokens[4];
            string month = tokens[5];
            string day = tokens[6];
            string yearOrTime = tokens[7];
            string name = tokens[8];

            return $"{size.PadLeft(10)} {month} {day.PadLeft(2)} {yearOrTime} {name}";
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Всі файли|*.*|png files|*.png|jpg files|*.jpg|gif files | *.gif | bmp files | *.bmp | exe files | *.exe | rar files | *.rar | zip files | *.zip | txt files | *.txt";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox10.Text = openFileDialog1.FileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbUpload.Text + openFileDialog1.SafeFileName);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                byte[] file = File.ReadAllBytes(textBox10.Text);
                using (Stream strz = await request.GetRequestStreamAsync())
                {
                    await strz.WriteAsync(file, 0, file.Length);
                }
                await LoadFtpDirectoryAsync(tbHost.Text);
                MessageBox.Show(openFileDialog1.SafeFileName + " завантажено");
            }
            else
            {
                MessageBox.Show(openFileDialog1.SafeFileName + " не заватажено");
            }
        }

        private async void tbnCreate_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbNewDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                await LoadFtpDirectoryAsync(tbHost.Text);
                MessageBox.Show("Каталог " + tbNewDir.Text + " створено");
            }
        }

        private async void btnGetFileSize_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbFileSize.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                MessageBox.Show("Розмір файлу: " + response.ContentLength.ToString() + " K");
            }
        }

        private async void btnRemoveDir_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbRemoveDir.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                await LoadFtpDirectoryAsync(tbHost.Text);
                MessageBox.Show("Каталог " + tbRemoveDir.Text + " видалено");
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbDownload.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream fileStream = new FileStream(textBox10.Text, FileMode.Create))
                    {
                        await responseStream.CopyToAsync(fileStream);
                    }
                }
                MessageBox.Show("Файл " + tbDownload.Text + " завантажено");
            }
        }

        private async void btnRename_Click(object sender, EventArgs e)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbOldName.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.RenameTo = tbNewName.Text;
            using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
            {
                MessageBox.Show("Файл " + tbOldName.Text + " перейменовано на " + tbNewName.Text);
                await LoadFtpDirectoryAsync(tbHost.Text);
            }
        }

        private async void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + tbDeleteFile.Text);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                using (FtpWebResponse response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    await LoadFtpDirectoryAsync(tbHost.Text);
                    MessageBox.Show("Файл " + tbDeleteFile.Text + " видалено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("settings.txt"))
            {
                writer.WriteLine(tbHost.Text);
                writer.WriteLine(tbUser.Text);
                writer.WriteLine(tbPass.Text);
            }
            MessageBox.Show("Налаштування збережено");
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("settings.txt"))
            {
                tbHost.Text = reader.ReadLine();
                tbUser.Text = reader.ReadLine();
                tbPass.Text = reader.ReadLine();
            }
            MessageBox.Show("Налаштування завантажено");
        }
    }
}
