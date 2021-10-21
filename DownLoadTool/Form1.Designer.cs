
namespace DownLoadTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chb_DownLoadConvertDelete = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_uri = new System.Windows.Forms.Label();
            this.chb_Convert = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Resolution = new System.Windows.Forms.ComboBox();
            this.Fomatter = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chb_ConvertDelete = new System.Windows.Forms.CheckBox();
            this.btn_DeleteConvert = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.txt_FolderConvert = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lsv_Convert = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConvertStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_TotolByteReceived = new System.Windows.Forms.Label();
            this.lsv_Url = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownloadStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoConvertStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarYoutube = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.btn_downloadYoutube = new System.Windows.Forms.Button();
            this.error_CheckNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_deleteCheck = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chb_ShowStatus = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_CheckNull)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 150);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chb_DownLoadConvertDelete);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_FileName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Url);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lbl_uri);
            this.tabPage1.Controls.Add(this.chb_Convert);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbx_Resolution);
            this.tabPage1.Controls.Add(this.Fomatter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chb_DownLoadConvertDelete
            // 
            this.chb_DownLoadConvertDelete.AutoSize = true;
            this.chb_DownLoadConvertDelete.Location = new System.Drawing.Point(415, 81);
            this.chb_DownLoadConvertDelete.Name = "chb_DownLoadConvertDelete";
            this.chb_DownLoadConvertDelete.Size = new System.Drawing.Size(103, 17);
            this.chb_DownLoadConvertDelete.TabIndex = 64;
            this.chb_DownLoadConvertDelete.Text = "Convert xog xóa";
            this.chb_DownLoadConvertDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Uri";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(85, 32);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(361, 20);
            this.txt_FileName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tên video: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(85, 9);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(361, 20);
            this.txt_Url.TabIndex = 0;
            this.txt_Url.TextChanged += new System.EventHandler(this.txt_UrlYoutube_TextChanged);
            this.txt_Url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UrlYoutube_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "tải mp4 và convert mp3 luôn (ngốn cpu 20-40%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "x : không có âm tải chậm, file mp3:tải chậm ";
            // 
            // lbl_uri
            // 
            this.lbl_uri.AutoSize = true;
            this.lbl_uri.Enabled = false;
            this.lbl_uri.Location = new System.Drawing.Point(82, 108);
            this.lbl_uri.Name = "lbl_uri";
            this.lbl_uri.Size = new System.Drawing.Size(20, 13);
            this.lbl_uri.TabIndex = 45;
            this.lbl_uri.Text = "Uri";
            this.lbl_uri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chb_Convert
            // 
            this.chb_Convert.AutoSize = true;
            this.chb_Convert.Location = new System.Drawing.Point(108, 81);
            this.chb_Convert.Name = "chb_Convert";
            this.chb_Convert.Size = new System.Drawing.Size(63, 17);
            this.chb_Convert.TabIndex = 60;
            this.chb_Convert.Text = "Convert";
            this.chb_Convert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Độ phân giải";
            // 
            // cbx_Resolution
            // 
            this.cbx_Resolution.FormattingEnabled = true;
            this.cbx_Resolution.Location = new System.Drawing.Point(85, 58);
            this.cbx_Resolution.Name = "cbx_Resolution";
            this.cbx_Resolution.Size = new System.Drawing.Size(162, 21);
            this.cbx_Resolution.TabIndex = 30;
            this.cbx_Resolution.SelectedIndexChanged += new System.EventHandler(this.cbx_Resolution_SelectedIndexChanged);
            // 
            // Fomatter
            // 
            this.Fomatter.AutoSize = true;
            this.Fomatter.Location = new System.Drawing.Point(6, 82);
            this.Fomatter.Name = "Fomatter";
            this.Fomatter.Size = new System.Drawing.Size(98, 13);
            this.Fomatter.TabIndex = 34;
            this.Fomatter.Text = "Convert Mp4->Mp3";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chb_ConvertDelete);
            this.tabPage3.Controls.Add(this.btn_DeleteConvert);
            this.tabPage3.Controls.Add(this.btn_convert);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btn_SelectFile);
            this.tabPage3.Controls.Add(this.txt_FolderConvert);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.lsv_Convert);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(688, 124);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chb_ConvertDelete
            // 
            this.chb_ConvertDelete.AutoSize = true;
            this.chb_ConvertDelete.Location = new System.Drawing.Point(134, 31);
            this.chb_ConvertDelete.Name = "chb_ConvertDelete";
            this.chb_ConvertDelete.Size = new System.Drawing.Size(138, 17);
            this.chb_ConvertDelete.TabIndex = 70;
            this.chb_ConvertDelete.Text = "Convert Xong Xóa MP4";
            this.chb_ConvertDelete.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteConvert
            // 
            this.btn_DeleteConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DeleteConvert.Location = new System.Drawing.Point(571, 22);
            this.btn_DeleteConvert.Name = "btn_DeleteConvert";
            this.btn_DeleteConvert.Size = new System.Drawing.Size(111, 23);
            this.btn_DeleteConvert.TabIndex = 53;
            this.btn_DeleteConvert.Text = "xóa";
            this.btn_DeleteConvert.UseVisualStyleBackColor = true;
            this.btn_DeleteConvert.Click += new System.EventHandler(this.btn_DeleteConvert_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_convert.Location = new System.Drawing.Point(454, 22);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(111, 23);
            this.btn_convert.TabIndex = 52;
            this.btn_convert.Text = "Start";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Mp4 - > Mp3";
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SelectFile.Location = new System.Drawing.Point(337, 22);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(111, 23);
            this.btn_SelectFile.TabIndex = 47;
            this.btn_SelectFile.Text = "Chọn Mp4";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // txt_FolderConvert
            // 
            this.txt_FolderConvert.Location = new System.Drawing.Point(64, 8);
            this.txt_FolderConvert.Name = "txt_FolderConvert";
            this.txt_FolderConvert.Size = new System.Drawing.Size(213, 20);
            this.txt_FolderConvert.TabIndex = 49;
            this.txt_FolderConvert.DoubleClick += new System.EventHandler(this.txt_FolderConvert_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Convert";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "lưu folder";
            // 
            // lsv_Convert
            // 
            this.lsv_Convert.CheckBoxes = true;
            this.lsv_Convert.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.ConvertStatus});
            this.lsv_Convert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsv_Convert.FullRowSelect = true;
            this.lsv_Convert.GridLines = true;
            this.lsv_Convert.HideSelection = false;
            this.lsv_Convert.Location = new System.Drawing.Point(3, 51);
            this.lsv_Convert.Name = "lsv_Convert";
            this.lsv_Convert.Size = new System.Drawing.Size(682, 70);
            this.lsv_Convert.TabIndex = 34;
            this.lsv_Convert.UseCompatibleStateImageBehavior = false;
            this.lsv_Convert.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Check";
            this.columnHeader5.Width = 44;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Url";
            this.columnHeader6.Width = 340;
            // 
            // ConvertStatus
            // 
            this.ConvertStatus.Text = "Trạng thái";
            this.ConvertStatus.Width = 161;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "speed :";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(623, 152);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(28, 13);
            this.lbl_speed.TabIndex = 54;
            this.lbl_speed.Text = "0Mb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tải video";
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(606, 153);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 23);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(188, 156);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 20);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Lưu url";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_TotolByteReceived
            // 
            this.lbl_TotolByteReceived.AutoSize = true;
            this.lbl_TotolByteReceived.Location = new System.Drawing.Point(623, 134);
            this.lbl_TotolByteReceived.Name = "lbl_TotolByteReceived";
            this.lbl_TotolByteReceived.Size = new System.Drawing.Size(28, 13);
            this.lbl_TotolByteReceived.TabIndex = 44;
            this.lbl_TotolByteReceived.Text = "0Mb";
            // 
            // lsv_Url
            // 
            this.lsv_Url.CheckBoxes = true;
            this.lsv_Url.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check,
            this.Url,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.DownloadStatus,
            this.VideoConvertStatus});
            this.lsv_Url.FullRowSelect = true;
            this.lsv_Url.GridLines = true;
            this.lsv_Url.HideSelection = false;
            this.lsv_Url.Location = new System.Drawing.Point(-3, 3);
            this.lsv_Url.Name = "lsv_Url";
            this.lsv_Url.Size = new System.Drawing.Size(692, 122);
            this.lsv_Url.TabIndex = 13;
            this.lsv_Url.UseCompatibleStateImageBehavior = false;
            this.lsv_Url.View = System.Windows.Forms.View.Details;
            this.lsv_Url.SelectedIndexChanged += new System.EventHandler(this.lsv_Url_SelectedIndexChanged);
            // 
            // Check
            // 
            this.Check.Text = "Check";
            this.Check.Width = 44;
            // 
            // Url
            // 
            this.Url.Text = "Url";
            this.Url.Width = 29;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "tên ";
            this.columnHeader1.Width = 255;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "định dạng";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chất lượng";
            this.columnHeader3.Width = 74;
            // 
            // DownloadStatus
            // 
            this.DownloadStatus.Text = "Download";
            this.DownloadStatus.Width = 96;
            // 
            // VideoConvertStatus
            // 
            this.VideoConvertStatus.Text = "Convert Mp4->Mp3";
            this.VideoConvertStatus.Width = 106;
            // 
            // progressBarYoutube
            // 
            this.progressBarYoutube.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarYoutube.Location = new System.Drawing.Point(0, 172);
            this.progressBarYoutube.Name = "progressBarYoutube";
            this.progressBarYoutube.Size = new System.Drawing.Size(696, 23);
            this.progressBarYoutube.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lưu vào folder";
            // 
            // txt_folder
            // 
            this.txt_folder.Location = new System.Drawing.Point(89, 156);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(93, 20);
            this.txt_folder.TabIndex = 5;
            this.txt_folder.TextChanged += new System.EventHandler(this.txt_folder_TextChanged);
            this.txt_folder.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // btn_downloadYoutube
            // 
            this.btn_downloadYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_downloadYoutube.Location = new System.Drawing.Point(3, 131);
            this.btn_downloadYoutube.Name = "btn_downloadYoutube";
            this.btn_downloadYoutube.Size = new System.Drawing.Size(79, 35);
            this.btn_downloadYoutube.TabIndex = 4;
            this.btn_downloadYoutube.Text = "Tải";
            this.btn_downloadYoutube.UseVisualStyleBackColor = true;
            this.btn_downloadYoutube.Click += new System.EventHandler(this.btn_downloadYoutobe_Click);
            // 
            // error_CheckNull
            // 
            this.error_CheckNull.ContainerControl = this;
            // 
            // btn_deleteCheck
            // 
            this.btn_deleteCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteCheck.Location = new System.Drawing.Point(489, 153);
            this.btn_deleteCheck.Name = "btn_deleteCheck";
            this.btn_deleteCheck.Size = new System.Drawing.Size(111, 23);
            this.btn_deleteCheck.TabIndex = 65;
            this.btn_deleteCheck.Text = "xóa all checked";
            this.btn_deleteCheck.UseVisualStyleBackColor = true;
            this.btn_deleteCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(419, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 66;
            this.button2.Text = "Nút test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chb_ShowStatus
            // 
            this.chb_ShowStatus.AutoSize = true;
            this.chb_ShowStatus.Location = new System.Drawing.Point(424, 130);
            this.chb_ShowStatus.Name = "chb_ShowStatus";
            this.chb_ShowStatus.Size = new System.Drawing.Size(133, 17);
            this.chb_ShowStatus.TabIndex = 67;
            this.chb_ShowStatus.Text = "Hiển thị tải tốc độ tải ?";
            this.chb_ShowStatus.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 152);
            this.label15.MaximumSize = new System.Drawing.Size(0, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Ngốn >15% CPU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lsv_Url);
            this.panel1.Controls.Add(this.chb_ShowStatus);
            this.panel1.Controls.Add(this.lbl_TotolByteReceived);
            this.panel1.Controls.Add(this.progressBarYoutube);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbl_speed);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_downloadYoutube);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 195);
            this.panel1.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deleteCheck);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownLoadTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_CheckNull)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Button btn_downloadYoutube;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.ErrorProvider error_CheckNull;
        private System.Windows.Forms.ListView lsv_Url;
        private System.Windows.Forms.ColumnHeader Check;
        private System.Windows.Forms.ColumnHeader Url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Fomatter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Resolution;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_uri;
        private System.Windows.Forms.ProgressBar progressBarYoutube;
        private System.Windows.Forms.Label lbl_TotolByteReceived;
        private System.Windows.Forms.MaskedTextBox txt_FileName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_Convert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_FolderConvert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.ListView lsv_Convert;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ColumnHeader ConvertStatus;
        private System.Windows.Forms.ColumnHeader DownloadStatus;
        private System.Windows.Forms.Button btn_deleteCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader VideoConvertStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chb_ShowStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_ConvertDelete;
        private System.Windows.Forms.Button btn_DeleteConvert;
        private System.Windows.Forms.CheckBox chb_DownLoadConvertDelete;
        private System.Windows.Forms.Label label9;
    }
}

