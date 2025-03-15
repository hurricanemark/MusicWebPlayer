namespace MusicWebPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            bnt_LoadAlbums = new Button();
            bnt_Search = new Button();
            txt_AlbumSearchText = new TextBox();
            pictureBox1 = new PictureBox();
            txt_DisplayDescription = new TextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tabControl1 = new TabControl();
            tabAlbumPage = new TabPage();
            txt_Description = new TextBox();
            bnt_AddAlbum = new Button();
            txt_SourceURL = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_Artist = new TextBox();
            label1 = new Label();
            txt_ImageURL = new TextBox();
            label2 = new Label();
            txt_Year = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_SongName = new TextBox();
            tabTrackPage = new TabPage();
            listBoxTrackNumber = new ListBox();
            label12 = new Label();
            label11 = new Label();
            comboBoxAlbum = new ComboBox();
            bnt_AddTrack = new Button();
            txt_Lyrics = new TextBox();
            txt_VidURL = new TextBox();
            label10 = new Label();
            txt_TrackName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            webVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            toolTipforTracks = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabAlbumPage.SuspendLayout();
            tabTrackPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webVideo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkSlateGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(3, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(469, 161);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bnt_LoadAlbums
            // 
            bnt_LoadAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bnt_LoadAlbums.BackColor = Color.DarkOliveGreen;
            bnt_LoadAlbums.Location = new Point(3, 3);
            bnt_LoadAlbums.MinimumSize = new Size(90, 0);
            bnt_LoadAlbums.Name = "bnt_LoadAlbums";
            bnt_LoadAlbums.Size = new Size(468, 31);
            bnt_LoadAlbums.TabIndex = 2;
            bnt_LoadAlbums.Text = "&Load Albums";
            bnt_LoadAlbums.UseVisualStyleBackColor = false;
            bnt_LoadAlbums.Click += bnt_LoadAlbums_Click;
            // 
            // bnt_Search
            // 
            bnt_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bnt_Search.BackColor = Color.YellowGreen;
            bnt_Search.Location = new Point(355, 40);
            bnt_Search.MinimumSize = new Size(70, 0);
            bnt_Search.Name = "bnt_Search";
            bnt_Search.Size = new Size(116, 23);
            bnt_Search.TabIndex = 3;
            bnt_Search.Text = "&Search";
            bnt_Search.UseVisualStyleBackColor = false;
            bnt_Search.Click += bnt_Search_Click;
            // 
            // txt_AlbumSearchText
            // 
            txt_AlbumSearchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_AlbumSearchText.Location = new Point(3, 41);
            txt_AlbumSearchText.MinimumSize = new Size(125, 0);
            txt_AlbumSearchText.Name = "txt_AlbumSearchText";
            txt_AlbumSearchText.PlaceholderText = "search text";
            txt_AlbumSearchText.Size = new Size(347, 23);
            txt_AlbumSearchText.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = Properties.Resources.yt_music_channel;
            pictureBox1.InitialImage = Properties.Resources.yt_music_channel;
            pictureBox1.Location = new Point(3, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txt_DisplayDescription
            // 
            txt_DisplayDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_DisplayDescription.BackColor = Color.Black;
            txt_DisplayDescription.BorderStyle = BorderStyle.None;
            txt_DisplayDescription.ForeColor = Color.White;
            txt_DisplayDescription.Location = new Point(180, 410);
            txt_DisplayDescription.Multiline = true;
            txt_DisplayDescription.Name = "txt_DisplayDescription";
            txt_DisplayDescription.ReadOnly = true;
            txt_DisplayDescription.Size = new Size(292, 127);
            txt_DisplayDescription.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(txt_DisplayDescription);
            splitContainer1.Panel2.Controls.Add(bnt_LoadAlbums);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(bnt_Search);
            splitContainer1.Panel2.Controls.Add(txt_AlbumSearchText);
            splitContainer1.Size = new Size(923, 541);
            splitContainer1.SplitterDistance = 445;
            splitContainer1.TabIndex = 7;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tabControl1);
            splitContainer2.Panel1.Padding = new Padding(2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(webVideo);
            splitContainer2.Size = new Size(445, 541);
            splitContainer2.SplitterDistance = 233;
            splitContainer2.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAlbumPage);
            tabControl1.Controls.Add(tabTrackPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 7F);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(3, 2);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(437, 225);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabAlbumPage
            // 
            tabAlbumPage.AutoScroll = true;
            tabAlbumPage.BackColor = Color.Black;
            tabAlbumPage.Controls.Add(txt_Description);
            tabAlbumPage.Controls.Add(bnt_AddAlbum);
            tabAlbumPage.Controls.Add(txt_SourceURL);
            tabAlbumPage.Controls.Add(label6);
            tabAlbumPage.Controls.Add(label5);
            tabAlbumPage.Controls.Add(txt_Artist);
            tabAlbumPage.Controls.Add(label1);
            tabAlbumPage.Controls.Add(txt_ImageURL);
            tabAlbumPage.Controls.Add(label2);
            tabAlbumPage.Controls.Add(txt_Year);
            tabAlbumPage.Controls.Add(label3);
            tabAlbumPage.Controls.Add(label4);
            tabAlbumPage.Controls.Add(txt_SongName);
            tabAlbumPage.ForeColor = Color.Black;
            tabAlbumPage.Location = new Point(4, 19);
            tabAlbumPage.Name = "tabAlbumPage";
            tabAlbumPage.Padding = new Padding(3);
            tabAlbumPage.Size = new Size(429, 202);
            tabAlbumPage.TabIndex = 0;
            tabAlbumPage.Text = "Add Albums";
            tabAlbumPage.ToolTipText = "Add new Album containing one or more song";
            // 
            // txt_Description
            // 
            txt_Description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Description.Location = new Point(78, 120);
            txt_Description.MinimumSize = new Size(75, 0);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(267, 45);
            txt_Description.TabIndex = 11;
            // 
            // bnt_AddAlbum
            // 
            bnt_AddAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bnt_AddAlbum.BackColor = Color.DarkOliveGreen;
            bnt_AddAlbum.ForeColor = Color.White;
            bnt_AddAlbum.Location = new Point(362, 14);
            bnt_AddAlbum.Name = "bnt_AddAlbum";
            bnt_AddAlbum.Size = new Size(50, 81);
            bnt_AddAlbum.TabIndex = 12;
            bnt_AddAlbum.Text = "&Add Album";
            bnt_AddAlbum.UseVisualStyleBackColor = false;
            bnt_AddAlbum.Click += bnt_AddAlbum_Click;
            // 
            // txt_SourceURL
            // 
            txt_SourceURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_SourceURL.Location = new Point(78, 171);
            txt_SourceURL.MinimumSize = new Size(75, 0);
            txt_SourceURL.Name = "txt_SourceURL";
            txt_SourceURL.Size = new Size(267, 20);
            txt_SourceURL.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 120);
            label6.Name = "label6";
            label6.Size = new Size(56, 12);
            label6.TabIndex = 5;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 174);
            label5.Name = "label5";
            label5.Size = new Size(55, 12);
            label5.TabIndex = 4;
            label5.Text = "SourceURL:";
            // 
            // txt_Artist
            // 
            txt_Artist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Artist.Location = new Point(78, 40);
            txt_Artist.MinimumSize = new Size(75, 0);
            txt_Artist.Name = "txt_Artist";
            txt_Artist.Size = new Size(267, 20);
            txt_Artist.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 12);
            label1.TabIndex = 0;
            label1.Text = "SongName:";
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_ImageURL.Location = new Point(78, 94);
            txt_ImageURL.MinimumSize = new Size(75, 0);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(267, 20);
            txt_ImageURL.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 43);
            label2.Name = "label2";
            label2.Size = new Size(28, 12);
            label2.TabIndex = 1;
            label2.Text = "Artist:";
            // 
            // txt_Year
            // 
            txt_Year.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Year.Location = new Point(78, 65);
            txt_Year.MinimumSize = new Size(50, 0);
            txt_Year.Name = "txt_Year";
            txt_Year.Size = new Size(138, 20);
            txt_Year.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(47, 65);
            label3.Name = "label3";
            label3.Size = new Size(25, 12);
            label3.TabIndex = 2;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 92);
            label4.Name = "label4";
            label4.Size = new Size(53, 12);
            label4.TabIndex = 3;
            label4.Text = "ImageURL:";
            // 
            // txt_SongName
            // 
            txt_SongName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_SongName.Location = new Point(78, 14);
            txt_SongName.MinimumSize = new Size(75, 0);
            txt_SongName.Name = "txt_SongName";
            txt_SongName.Size = new Size(267, 20);
            txt_SongName.TabIndex = 6;
            // 
            // tabTrackPage
            // 
            tabTrackPage.AutoScroll = true;
            tabTrackPage.BackColor = Color.Black;
            tabTrackPage.Controls.Add(listBoxTrackNumber);
            tabTrackPage.Controls.Add(label12);
            tabTrackPage.Controls.Add(label11);
            tabTrackPage.Controls.Add(comboBoxAlbum);
            tabTrackPage.Controls.Add(bnt_AddTrack);
            tabTrackPage.Controls.Add(txt_Lyrics);
            tabTrackPage.Controls.Add(txt_VidURL);
            tabTrackPage.Controls.Add(label10);
            tabTrackPage.Controls.Add(txt_TrackName);
            tabTrackPage.Controls.Add(label9);
            tabTrackPage.Controls.Add(label8);
            tabTrackPage.Location = new Point(4, 19);
            tabTrackPage.Name = "tabTrackPage";
            tabTrackPage.Padding = new Padding(3);
            tabTrackPage.Size = new Size(429, 202);
            tabTrackPage.TabIndex = 1;
            tabTrackPage.Text = "Add Tracks";
            tabTrackPage.ToolTipText = "Select album ID, add song track.";
            // 
            // listBoxTrackNumber
            // 
            listBoxTrackNumber.AllowDrop = true;
            listBoxTrackNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxTrackNumber.FormattingEnabled = true;
            listBoxTrackNumber.ItemHeight = 12;
            listBoxTrackNumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            listBoxTrackNumber.Location = new Point(75, 14);
            listBoxTrackNumber.MaximumSize = new Size(60, 32);
            listBoxTrackNumber.Name = "listBoxTrackNumber";
            listBoxTrackNumber.Size = new Size(49, 28);
            listBoxTrackNumber.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 22);
            label12.Name = "label12";
            label12.Size = new Size(65, 12);
            label12.TabIndex = 10;
            label12.Text = "TrackNumber:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 49);
            label11.Name = "label11";
            label11.Size = new Size(46, 12);
            label11.TabIndex = 9;
            label11.Text = "AlbumID:";
            // 
            // comboBoxAlbum
            // 
            comboBoxAlbum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAlbum.FormattingEnabled = true;
            comboBoxAlbum.Location = new Point(75, 46);
            comboBoxAlbum.Name = "comboBoxAlbum";
            comboBoxAlbum.Size = new Size(271, 20);
            comboBoxAlbum.TabIndex = 8;
            // 
            // bnt_AddTrack
            // 
            bnt_AddTrack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bnt_AddTrack.BackColor = Color.DarkOliveGreen;
            bnt_AddTrack.Location = new Point(361, 18);
            bnt_AddTrack.Name = "bnt_AddTrack";
            bnt_AddTrack.Size = new Size(50, 75);
            bnt_AddTrack.TabIndex = 7;
            bnt_AddTrack.Text = "&Add Track";
            bnt_AddTrack.UseVisualStyleBackColor = false;
            bnt_AddTrack.Click += bnt_AddTrack_Click;
            // 
            // txt_Lyrics
            // 
            txt_Lyrics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Lyrics.Location = new Point(75, 101);
            txt_Lyrics.Multiline = true;
            txt_Lyrics.Name = "txt_Lyrics";
            txt_Lyrics.Size = new Size(271, 60);
            txt_Lyrics.TabIndex = 6;
            // 
            // txt_VidURL
            // 
            txt_VidURL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_VidURL.Location = new Point(75, 167);
            txt_VidURL.Name = "txt_VidURL";
            txt_VidURL.Size = new Size(271, 20);
            txt_VidURL.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 96);
            label10.Name = "label10";
            label10.Size = new Size(31, 12);
            label10.TabIndex = 4;
            label10.Text = "Lyrics:";
            // 
            // txt_TrackName
            // 
            txt_TrackName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_TrackName.Location = new Point(75, 72);
            txt_TrackName.Name = "txt_TrackName";
            txt_TrackName.Size = new Size(271, 20);
            txt_TrackName.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 170);
            label9.Name = "label9";
            label9.Size = new Size(50, 12);
            label9.TabIndex = 2;
            label9.Text = "VideoURL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 73);
            label8.Name = "label8";
            label8.Size = new Size(46, 12);
            label8.TabIndex = 1;
            label8.Text = "TrackTitle:";
            // 
            // webVideo
            // 
            webVideo.AllowExternalDrop = true;
            webVideo.BackColor = Color.Black;
            webVideo.CreationProperties = null;
            webVideo.DefaultBackgroundColor = Color.Black;
            webVideo.Dock = DockStyle.Fill;
            webVideo.Location = new Point(0, 0);
            webVideo.Name = "webVideo";
            webVideo.Padding = new Padding(3, 5, 3, 5);
            webVideo.Size = new Size(441, 300);
            webVideo.TabIndex = 1;
            webVideo.ZoomFactor = 1D;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(3, 240);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 8;
            label7.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.CadetBlue;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.CadetBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.Location = new Point(3, 258);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(469, 146);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // toolTipforTracks
            // 
            toolTipforTracks.ToolTipIcon = ToolTipIcon.Info;
            toolTipforTracks.ToolTipTitle = "Tip";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(923, 541);
            Controls.Add(splitContainer1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RolEmiTech Music Vault";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabAlbumPage.ResumeLayout(false);
            tabAlbumPage.PerformLayout();
            tabTrackPage.ResumeLayout(false);
            tabTrackPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webVideo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dataGridView1;
        private Button bnt_LoadAlbums;
        private Button bnt_Search;
        private TextBox txt_AlbumSearchText;
        private PictureBox pictureBox1;
        private TextBox txt_DisplayDescription;
        private SplitContainer splitContainer1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Description;
        private TextBox txt_SourceURL;
        private TextBox txt_ImageURL;
        private TextBox txt_Year;
        private TextBox txt_Artist;
        private TextBox txt_SongName;
        private Button bnt_AddAlbum;
        private Label label7;
        private DataGridView dataGridView2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webVideo;
        private ToolTip toolTipforTracks;
        private TabControl tabControl1;
        private TabPage tabAlbumPage;
        private TabPage tabTrackPage;
        private SplitContainer splitContainer2;
        private Label label9;
        private Label label8;
        private TextBox txt_Lyrics;
        private TextBox txt_VidURL;
        private Label label10;
        private TextBox txt_TrackName;
        private Button bnt_AddTrack;
        private Label label11;
        private ComboBox comboBoxAlbum;
        private Label label12;
        private ListBox listBoxTrackNumber;
    }
}
