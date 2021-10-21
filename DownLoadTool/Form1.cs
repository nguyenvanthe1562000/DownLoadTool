using DownLoadTool.common;
using MediaToolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace DownLoadTool
{
    public enum Status
    {
        Loading, None, OK
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //lbl_uri.Hide();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        DateTime _startedAt;
        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_folder.Text = dialog.FileName;
            }
        }

        async Task download(string url, string path, ListViewItem listViewItem = null)
        {
            try
            {
                listViewItem.SubItems[5].Text = Status.Loading.ToString();

                Action downloadaction = () =>
                {

                    Uri uri = new Uri(url);
                    WebClient webClient = new WebClient();
                    webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                    webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
                    webClient.DownloadFileTaskAsync(uri, path).GetAwaiter().GetResult();


                };

                Task task = new Task(downloadaction);
                task.Start();
                await task;
                listViewItem.SubItems[5].Text = Status.OK.ToString();
                if (listViewItem.SubItems[3].Text.Equals("mp3"))
                {
                    var taskconvert = ConvertMp4ToMp3(path, listViewItem);
                    await taskconvert;

                }
                listViewItem.Checked = true;


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }


        }



        private void btn_downloadYoutobe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_folder.Text))
            {
                error_CheckNull.SetError(txt_folder, "nhập");
                return;
            }
            try
            {
                foreach (ListViewItem item in lsv_Url.Items)
                {
                    var task = item;
                    if (!task.Checked && task.SubItems[5].Text != Status.Loading.ToString() && task.SubItems[6].Text != Status.Loading.ToString())
                    {
                        string name = txt_folder.Text + "\\" + item.SubItems[2].Text;
                        var taskdonload = download(item.SubItems[1].Text, name, task);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        async Task ConvertMp4ToMp3(string filename, ListViewItem listViewItem)
        {

            Action downloadaction = () =>
            {
                var listview = listViewItem.ListView.Name;
                if (listview.Equals("lsv_Url"))
                {
                    listViewItem.SubItems[6].Text = Status.Loading.ToString();
                }
                else
                {
                    listViewItem.SubItems[2].Text = Status.Loading.ToString();
                }

                var inputFile = new MediaToolkit.Model.MediaFile { Filename = filename };
                var outputFile = new MediaToolkit.Model.MediaFile { Filename = ChangeFileName.ChangeType(filename, true) };
                using (var enging = new Engine())
                {
                    enging.GetMetadata(inputFile);
                    enging.Convert(inputFile, outputFile);
                }
                if (listview.Equals("lsv_Url"))
                {
                    listViewItem.SubItems[6].Text = Status.OK.ToString();
                    if (chb_DownLoadConvertDelete.Checked)
                    {
                        File.Delete(filename);
                    }
                }
                else
                {
                    listViewItem.Checked = true;
                    listViewItem.SubItems[2].Text = Status.OK.ToString();
                    if (chb_ConvertDelete.Checked)
                    {
                        File.Delete(filename);
                    }
                }


            };
            Task task = new Task(downloadaction);
            task.Start();
            await task;




        }



        private void txt_UrlYoutube_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txt_Url.Text))
                {
                    ListViewItem viewItem = new ListViewItem("");
                    viewItem.SubItems.Add(lbl_uri.Text);
                    viewItem.SubItems.Add(txt_FileName.Text);
                    viewItem.SubItems.Add(chb_Convert.Checked == true ? "Mp3" : "Mp4");
                    viewItem.SubItems.Add(cbx_Resolution.Text);
                    lsv_Url.Items.Add(viewItem);
                    txt_Url.Text = string.Empty;
                    lbl_uri.Text = string.Empty;
                }
                else
                {
                    error_CheckNull.SetError(txt_Url, "nhập url video");
                }
            }
        }
        string GetFormatVideo(int Resolution, int AudioBitrate, AdaptiveKind adaptiveKind)
        {

            if (adaptiveKind == AdaptiveKind.Audio)
            {
                return string.Format("Mp3-{0}", AudioBitrate);
            }
            else if (adaptiveKind == AdaptiveKind.Video)
            {
                if (AudioBitrate > 0)
                {
                    return string.Format("Mp4-{0}p", Resolution);
                }
                else
                {
                    return string.Format("Mp4-{0}p-x", Resolution);
                }
            }
            return "";
        }

        private async void txt_UrlYoutube_TextChanged(object sender, EventArgs e)
        {

            try
            {


                string youtube1 = "https://youtu.be/";
                string youtube2 = "https://www.youtube.com/";
                string facebook = "https://www.facebook.com/";
                string link = txt_Url.Text;

                //cbx_Resolution.Enabled = false;
                txt_FileName.Enabled = false;
                Task task = new Task(() =>
                {
                    if (link.StartsWith(youtube1) || link.StartsWith(youtube2))
                        YouTuBe(link);
                    else if (link.StartsWith(facebook))
                        FaceBook(link);
                });
                task.Start();
                await task;
              //  cbx_Resolution.Enabled = true;
                txt_FileName.Enabled = true;

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(txt_Url.Text))
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        void YouTuBe(string link)
        {

            var youTube = YouTube.Default; // starting point for YouTube actions
            var videoInfos = youTube.GetAllVideosAsync(link).GetAwaiter().GetResult().Where(x => x.Format != VideoFormat.WebM && x.IsAdaptive == true && x.AudioFormat != AudioFormat.Opus);
            txt_FileName.Text = Path.GetFileName(videoInfos.ElementAt(0).FullName);
            var sourceLinkVideo = videoInfos.Select(x => new { Resolution = GetFormatVideo(x.Resolution, x.AudioBitrate, x.AdaptiveKind), Uri = x.Uri }).OrderBy(x => x.Resolution.Length).ToList();
            cbx_Resolution.DataSource = sourceLinkVideo;
            ///videoInfos.Select(x => new { Resolution = GetFormatVideo(x.Resolution, x.AudioBitrate, x.AdaptiveKind, x.ContentLength), Uri = x.Uri }).ToList(); ;
            cbx_Resolution.DisplayMember = "Resolution";
            cbx_Resolution.ValueMember = "Uri";
            lbl_uri.Text = cbx_Resolution.SelectedValue.ToString();
        }
        void FaceBook(string link)
        {
            try
            {
                //https://www.facebook.com/watch/?v=913982579215908
                //https://www.facebook.com/100630271951411/videos/183422293811482/
                var faceBook = new FaceBook().GetVideoFaceBook(link);
            
                //string regex= "^[^<>:;,?\" *|/]+ $";
                var regex = Regex.Matches(link, @"\w");
                var name = "";
                foreach (var item in regex)
                {
                    name += item;
                }
                txt_FileName.Text = name + ".mp4";
                cbx_Resolution.DisplayMember = "Resolution";
                cbx_Resolution.ValueMember = "Uri";
                cbx_Resolution.DataSource = faceBook;
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lẽ một cái gì đó hỏng chăng");
            }

        }
        private void cbx_Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_uri.Text = cbx_Resolution.SelectedValue.ToString();
        }

        private void lsv_Url_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_folder.Text))
            {
                error_CheckNull.Clear();
                ListViewItem viewItem = new ListViewItem((lsv_Url.Items.Count + 1).ToString());
                if (string.IsNullOrEmpty(lbl_uri.Text))
                {
                    MessageBox.Show("uri null chọn lại độ phân giải");
                }
                viewItem.SubItems.Add(lbl_uri.Text);
                viewItem.SubItems.Add(txt_FileName.Text);
                viewItem.SubItems.Add(chb_Convert.Checked == true ? "mp3" : "mp4");
                viewItem.SubItems.Add(cbx_Resolution.Text);
                viewItem.SubItems.Add(Status.None.ToString());
                viewItem.SubItems.Add(Status.None.ToString());
                lsv_Url.Items.Add(viewItem);
                txt_Url.Text = string.Empty;
                txt_FileName.Text = new Random().Next(0, 1) + txt_FileName.Text;
                //lbl_uri.Text = string.Empty;

            }
            else
            {
                error_CheckNull.SetError(txt_folder, "nhập folder de luu");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lsv_Url.SelectedItems.Count > 0)
            {
                var checkdeletetaskrun = false;
                foreach (ListViewItem eachItem in lsv_Url.SelectedItems)
                {
                    if (eachItem.SubItems[5].Text != Status.Loading.ToString() && eachItem.SubItems[6].Text != Status.Loading.ToString())
                    {
                        lsv_Url.Items.Remove(eachItem);
                    }
                    else
                        checkdeletetaskrun = true;

                }
                if (checkdeletetaskrun)
                {
                    MessageBox.Show("Chỉ xóa được các video đã tải và convert xog");
                }
            }
        }



        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                progressBarYoutube.Value = 0;
                lbl_TotolByteReceived.Text = "0 MB";
                lbl_speed.Text = "0 MB";
            });
        }


        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (chb_ShowStatus.Checked)
            {
                progressBarYoutube.Value = (int)e.ProgressPercentage;
                lbl_TotolByteReceived.Text = string.Format("{0} MB", (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

                if (_startedAt == default(DateTime))
                {
                    _startedAt = DateTime.Now;
                }
                else
                {
                    var timeSpan = DateTime.Now - _startedAt;
                    if (timeSpan.TotalSeconds > 0)
                    {
                        var bytesPerSecond = e.BytesReceived / Convert.ToDouble(timeSpan.TotalSeconds);
                        lbl_speed.Text = string.Format("{0} MB/s", (bytesPerSecond / 1024d / 1024d).ToString("0.00"));
                    }
                }

            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
        }




        private void txt_folder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "file mp4|*.mp4";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (var item in openFileDialog.FileNames)
                {
                    ListViewItem listViewItem = new ListViewItem("");
                    listViewItem.SubItems.Add(item);
                    listViewItem.SubItems.Add(Status.None.ToString());
                    lsv_Convert.Items.Add(listViewItem);
                }

            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_FolderConvert.Text))
            {
                MessageBox.Show("nhập folder để lưu");
                return;
            }
            foreach (ListViewItem item in lsv_Convert.Items)
            {
                var listviewitem = item;
                if (!listviewitem.Checked && listviewitem.SubItems[2].Text == Status.None.ToString())
                {
                    var taskConvertMp4ToMp3 = ConvertMp4ToMp3(item.SubItems[1].Text, listviewitem);
                }
            }
        }


        private void txt_FolderConvert_DoubleClick(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_FolderConvert.Text = dialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = @"https://s1.phimmoi.pro/play/6104768c96eb2d1555303153";
            string path = @"C:\Users\nguye\OneDrive\Máy tính\New folder\mp3.mp4";
            using (var http =new xNet.HttpRequest())
            {
                http.Referer = "https://em.iq.com/";
               
                var file= http.Get("https://data.video.iq.com/v.f4v").ToMemoryStream().ToArray();

            } 
         

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("có task đang tải có muốn đóng", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {

                e.Cancel = true;

            }
            else
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var checkdeletetaskrun = false;
            foreach (ListViewItem eachItem in lsv_Url.Items)
            {
                if (eachItem.Checked)
                {
                    if (eachItem.SubItems[5].Text != Status.Loading.ToString() && eachItem.SubItems[6].Text != Status.Loading.ToString())
                    {
                        lsv_Url.Items.Remove(eachItem);
                    }
                    else
                        checkdeletetaskrun = true;
                }
            }
            if (checkdeletetaskrun)
            {
                MessageBox.Show("Chỉ xóa được các video đã tải và convert xong");
            }

        }

        private void btn_DeleteConvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsv_Url.SelectedItems)
            {
                if (item.SubItems[2].Text != Status.Loading.ToString())
                {
                    lsv_Url.Items.Remove(item);
                }
            }
        }


    }
}
