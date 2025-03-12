using MusicWebPlayer.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using Microsoft.Web.WebView2.Core;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;


namespace MusicWebPlayer
{

    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource albumBindingSourceDesc = new BindingSource();

        BindingSource tracksBindingSource = new BindingSource();

        public string sqliteConnectionString = "Data Source=rolemimusic.db;Version=3;";

        public Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2 { get; }

        public Form1()
        {
            InitializeComponent();
            //this.vidBrowser.Location = new System.Drawing.Point(1064, 24);
            //this.vidBrowser.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            //this.vidBrowser.MinimumSize = new System.Drawing.Size(27, 27);
            //this.vidBrowser.Name = "music.youtube.com";
            //this.vidBrowser.Size = new System.Drawing.Size(405, 506);
            //this.vidBrowser.TabIndex = 27;
            //this.vidBrowser.TabStop = false;
            //Form1.ActiveForm.Controls.Add(this.vidBrowser);

            webVideo.NavigationStarting += EnsureHttps;
            InitializeAsync();

            toolTipforTracks.SetToolTip(dataGridView2, "Select a track to play");
            toolTipforTracks.Active = true;
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webVideo.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }
        async void InitializeAsync()
        {
            // Create and initialize the WebView2
            await webVideo.EnsureCoreWebView2Async(null);
        }



        private void bnt_LoadAlbums_Click(object sender, EventArgs e)
        {
            // create two fake data items
            /*
            albumsDAO albumdoa = new albumsDAO();
            
            Album A1 = new Album
            {
                ID = 1,
                AlbumName = "Ma Baker",
                ArtistName = "BoneyM",
                ReleaseYear = 1976,
                ImageURL = "https://somewhere.com/m.png",
                PlayURL = "https://music.youtube.com/watch?v=xsUuI_exzzQ&si=Eo-4vlS9RJ1wwLgF",
                Description = "Description Ma Baker"
            };
            Album A2 = new Album
            {
                ID = 2,
                AlbumName = "SucumBha",
                ArtistName = "BoneyN",
                ReleaseYear = 1988,
                ImageURL = "https://somewhere.com/n.png",
                PlayURL = "https://music.youtube.com/watch?v=xsUuI_exzzQ&si=Eo-4vlS9RJ1wwLgF",
                Description = "Description for SucumBha"
            };

            albumdoa.albums.Add(A1);
            albumdoa.albums.Add(A2);
            */

            AlbumsDAO albumdao = new AlbumsDAO();
            SQLiteDAO albums = new SQLiteDAO(sqliteConnectionString);

            // get Album data from MySQL database
            //albumBindingSource.DataSource = albumdao.getAllAlbums();

            // get Album data from SQLite database
            albumBindingSource.DataSource = albums.GetAlbumsData();

            dataGridView1.DataSource = albumBindingSource;

        }

        private void bnt_Search_Click(object sender, EventArgs e)
        {
            // search button
            AlbumsDAO albumdao = new AlbumsDAO();

            // Connect the list to the grid view control
            albumBindingSource.DataSource = albumdao.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // get the row number being clicked
            int rowClicked = dataGridView.CurrentRow.Index;
            //MessageBox.Show("You clicked row " + rowClicked);

            // load selected image
            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                pictureBox1.Load(imageURL);
            }
            catch (System.Net.WebException ex)
            {
                //MessageBox.Show(ex.Message);

                pictureBox1.Load("yt_music_channel.jpeg");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
#pragma warning restore CS0168 // Variable is declared but never used

            // load selected description
            AlbumsDAO desDAO = new AlbumsDAO();
            String songName = dataGridView.Rows[rowClicked].Cells[1].Value.ToString();
            albumBindingSourceDesc.DataSource = desDAO.getDescription(songName);

            textBox2.Text = albumBindingSourceDesc.DataSource.ToString();


            // load the tracks from the selected album
            AlbumsDAO selAlbumDoa = new AlbumsDAO();
            tracksBindingSource.DataSource = selAlbumDoa.getTracksUsingJoin((int)(dataGridView.Rows[rowClicked].Cells[0].Value));
            dataGridView2.DataSource = tracksBindingSource;
            dataGridView2.ShowCellToolTips = true;

            // Auto select the first row to WebVideo & kickstart the player
            if (dataGridView2.RowCount >= 1)
            {
                // Simulate row click                
                dataGridView2.Rows[0].Selected = true;
                dataGridView2_CellContentClick(dataGridView, new DataGridViewCellEventArgs(3, 0));

            }
        }



        // Add song into database
        private void bnt_AddAlbum_Click(object sender, EventArgs e)
        {
            // Capture user input
            if (txt_SongName.TextLength == 0 || txt_SourceURL.TextLength == 0 || txt_ImageURL.TextLength == 0 || txt_Artist.TextLength == 0)
            {
                MessageBox.Show("Incomplete inputs!"); return;
            }
            else
            {
                Album album = new Album
                {
                    SongName = txt_SongName.Text,
                    ArtistName = txt_Artist.Text,
                    ReleaseYear = Int32.Parse(txt_Year.Text),
                    ImageURL = txt_ImageURL.Text,
                    PlayURL = txt_SourceURL.Text,
                    Description = txt_Description.Text
                };

                // Insert into SQLite ALBUMS

                SQLiteDAO sqliteDb = new SQLiteDAO(sqliteConnectionString);

                SQLiteConnection sqlite_conn;
                sqlite_conn = sqliteDb.CreateConnection();

                // Create tables ALBUMS and TRACKS if they don't exist
                sqliteDb.CreateTables(sqlite_conn);

                sqliteDb.InsertAlbumData(sqlite_conn, album);

                // Retrieve Albums from SQLite database
                List<Album> readAlbum = sqliteDb.GetAlbumsData();

                foreach (var row in readAlbum)
                {
                    Console.WriteLine($"ID: {row.ID}, Title: {row.SongName}, Artist: {row.ArtistName}, Year: {row.ReleaseYear}, Image: {row.ImageURL}, VidURL: {row.PlayURL}, Description: {row.Description}");
                }
                albumBindingSource.DataSource = readAlbum;
                dataGridView1.DataSource = albumBindingSource;
            }

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gv = sender as DataGridView;

            // get the row number being clicked
            int rowClicked = gv.CurrentRow.Index;

            if (gv != null && gv.SelectedRows.Count > 0)
            {
                // load selected image
                String videoURL = gv.Rows[rowClicked].Cells[5].Value.ToString();

                if (webVideo != null && webVideo.CoreWebView2 != null)
                {
                    try
                    {
                        // Set the WebView2 URL
                        webVideo.CoreWebView2.Navigate(videoURL);

                        // Wait for the document to load and then request full-screen mode
                        webVideo.CoreWebView2.NavigationCompleted += (sender, args) =>
                        {
                            // JavaScript to request full-screen mode
                            webVideo.CoreWebView2.ExecuteScriptAsync("document.documentElement.requestFullscreen();");
                        };
                    }
                    catch (Exception ex) { }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
