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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_Description = new TextBox();
            txt_SourceURL = new TextBox();
            txt_ImageURL = new TextBox();
            txt_Year = new TextBox();
            txt_Artist = new TextBox();
            txt_SongName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
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
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 41);
            textBox1.MinimumSize = new Size(125, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "search text";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 4;
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(180, 410);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(292, 127);
            textBox2.TabIndex = 6;
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
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(bnt_LoadAlbums);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(bnt_Search);
            splitContainer1.Panel2.Controls.Add(textBox1);
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
            splitContainer2.SplitterDistance = 243;
            splitContainer2.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 7F);
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(3, 2);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(437, 229);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 19);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(429, 206);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Albums";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_Description);
            groupBox1.Controls.Add(txt_SourceURL);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_Year);
            groupBox1.Controls.Add(txt_Artist);
            groupBox1.Controls.Add(txt_SongName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(423, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.DarkOliveGreen;
            button3.Location = new Point(361, 38);
            button3.Name = "button3";
            button3.Size = new Size(59, 117);
            button3.TabIndex = 12;
            button3.Text = "&Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_Description
            // 
            txt_Description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Description.Location = new Point(97, 160);
            txt_Description.MinimumSize = new Size(75, 0);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(258, 23);
            txt_Description.TabIndex = 11;
            // 
            // txt_SourceURL
            // 
            txt_SourceURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_SourceURL.Location = new Point(97, 131);
            txt_SourceURL.MinimumSize = new Size(75, 0);
            txt_SourceURL.Name = "txt_SourceURL";
            txt_SourceURL.Size = new Size(258, 20);
            txt_SourceURL.TabIndex = 10;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_ImageURL.Location = new Point(97, 103);
            txt_ImageURL.MinimumSize = new Size(75, 0);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(258, 20);
            txt_ImageURL.TabIndex = 9;
            // 
            // txt_Year
            // 
            txt_Year.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Year.Location = new Point(97, 74);
            txt_Year.MinimumSize = new Size(50, 0);
            txt_Year.Name = "txt_Year";
            txt_Year.Size = new Size(142, 20);
            txt_Year.TabIndex = 8;
            // 
            // txt_Artist
            // 
            txt_Artist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Artist.Location = new Point(97, 44);
            txt_Artist.MinimumSize = new Size(75, 0);
            txt_Artist.Name = "txt_Artist";
            txt_Artist.Size = new Size(258, 20);
            txt_Artist.TabIndex = 7;
            // 
            // txt_SongName
            // 
            txt_SongName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_SongName.Location = new Point(97, 14);
            txt_SongName.MinimumSize = new Size(75, 0);
            txt_SongName.Name = "txt_SongName";
            txt_SongName.Size = new Size(258, 20);
            txt_SongName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 160);
            label6.Name = "label6";
            label6.Size = new Size(56, 12);
            label6.TabIndex = 5;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 134);
            label5.Name = "label5";
            label5.Size = new Size(53, 12);
            label5.TabIndex = 4;
            label5.Text = "SourceURL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 101);
            label4.Name = "label4";
            label4.Size = new Size(53, 12);
            label4.TabIndex = 3;
            label4.Text = "ImageURL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 74);
            label3.Name = "label3";
            label3.Size = new Size(25, 12);
            label3.TabIndex = 2;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 47);
            label2.Name = "label2";
            label2.Size = new Size(28, 12);
            label2.TabIndex = 1;
            label2.Text = "Artist:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(56, 12);
            label1.TabIndex = 0;
            label1.Text = "SongName:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 19);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(429, 206);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Tracks";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // webVideo
            // 
            webVideo.AllowExternalDrop = true;
            webVideo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webVideo.BackColor = Color.Black;
            webVideo.CreationProperties = null;
            webVideo.DefaultBackgroundColor = Color.Black;
            webVideo.Location = new Point(5, 3);
            webVideo.Name = "webVideo";
            webVideo.Padding = new Padding(3, 5, 3, 5);
            webVideo.Size = new Size(433, 283);
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
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webVideo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bnt_LoadAlbums;
        private Button bnt_Search;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
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
        private Button button3;
        private Label label7;
        private DataGridView dataGridView2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webVideo;
        private ToolTip toolTipforTracks;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer2;
    }
}
