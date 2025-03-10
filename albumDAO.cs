using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicWebPlayer
{
    internal class AlbumsDAO
    {        
        // Connection string to MySQL server at localhost
        string ConnectionString = "datasource=localhost;port=3307;username=root;password=root;database=music;";

        // Connection string to Verio MySQL server on the cloud
        //string ConnectionString = "DataSource='walmyadmin01.int.bizland.net';Port=3306;UserID='markapp';Password='a@5wGvEwd2,?vqM';Database='marktest';";
        //string ConnectionString = "DataSource='aescl1.veriomysql.com';UserID='aescl1';Password='Ces$ena516';Database='marktest';";



        public List<Album> getAllAlbums()
        {
            // start with an empty list
            List<Album> returnSongs = new List<Album>();

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            
            try { connection.Open(); } catch (Exception ex) { MessageBox.Show(ex.Message); return returnSongs; }
            

            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL FROM ALBUMS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album 
                    {
                        ID = reader.GetInt32(0),
                        SongName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        ReleaseYear = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                        PlayURL = reader.GetString(6)
                    };
                    returnSongs.Add(a);
                }
                connection.Close();
                return returnSongs;
            }
        }



        public List<Album> searchTitles(String searchPhrase)
        {
            // start with an empty list
            List<Album> returnSongs = new List<Album>();

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            // immediate line below invites injection attack
            //MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS WHERE ALBUM_TITLE LIKE '%" + searchPhrase +"%';", connection);

            // next few line prevent injection attack
            String searchWildcardText = "%" + searchPhrase + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL FROM ALBUMS WHERE ALBUM_TITLE LIKE @searchtext";
            command.Parameters.AddWithValue("@searchtext", searchWildcardText);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        SongName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        ReleaseYear = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                        PlayURL = reader.GetString(6)
                    };
                    returnSongs.Add(a);
                }
                connection.Close();
                return returnSongs;
            }
        }


        public String getDescription(String searchPhrase)
        {
            String returnDescription = "";

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            // immediate line below invites injection attack
            //MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS WHERE ALBUM_TITLE LIKE '%" + searchPhrase +"%';", connection);

            // next few line prevent injection attack
            String searchWildcardText = "%" + searchPhrase + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @searchtext";
            command.Parameters.AddWithValue("@searchtext", searchWildcardText);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {

                    returnDescription = reader.GetString(0);
                }
                connection.Close();
                return returnDescription;
            }
        }


        internal int addOneAlbum(Album oneAlbum)
        {
            int returnResult = 0;

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            
            // next few lines prevent injection attack
            MySqlCommand command = new MySqlCommand("INSERT IGNORE INTO ALBUMS(ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL) VALUES (@songname,@artist,@year,@imageurl,@desc,@sourceurl)", connection);
            command.Parameters.AddWithValue("@songname", oneAlbum.SongName);
            command.Parameters.AddWithValue("@artist", oneAlbum.ArtistName);
            command.Parameters.AddWithValue("@year", oneAlbum.ReleaseYear);
            command.Parameters.AddWithValue("@imageurl", oneAlbum.ImageURL);
            command.Parameters.AddWithValue("@desc", oneAlbum.Description);
            command.Parameters.AddWithValue("@sourceurl", oneAlbum.PlayURL);

            returnResult = command.ExecuteNonQuery();  // returns effected number of row(s)
            connection.Close();

            return returnResult;
        }


        public List<Track> getTracksForAlbum(int albumID)
        {
            // start with an empty list
            List<Track> returnTracks = new List<Track>();

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

           
            // next few line prevent injection attack          
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT number, track_title, video_url, lyrics, ID FROM TRACKS WHERE ALBUMS_ID = @searchID";
            //command.CommandText = "SELECT tracks.number AS track_number, albums.ALBUM_TITLE AS album_title, `track_title`, `video_url`, `lyrics` FROM `tracks` JOIN albums ON albums.ID = tracks.albums_ID ORDER BY tracks.albums_ID, tracks.ID";
            command.Parameters.AddWithValue("@searchID", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track tr = new Track
                    {
                        Number = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        VideoURL = reader.GetString(2),
                        Lyrics = reader.GetString(3),
                        ID = reader.GetInt32(4),
                    };
                    returnTracks.Add(tr);
                }
                connection.Close();                
            }
            return returnTracks;
        }


        public List<JObject> getTracksUsingJoin(int albumID)
        {
            // start with an empty list
            List<JObject> returnTracks = new List<JObject>();

            // connect to the MySQL server
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();


            // load tracks from selected album          
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.number AS track_number, albums.ALBUM_TITLE AS album_title, `track_title`, `video_url`, `lyrics` FROM `tracks` JOIN albums ON albums.ID = tracks.albums_ID WHERE tracks.albums_ID = @selAlbumID ORDER BY tracks.albums_ID, tracks.ID";
            command.Parameters.AddWithValue("@selAlbumID", albumID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    JObject newTrack = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    };
                    returnTracks.Add(newTrack);
                }
                connection.Close();
            }

            if (returnTracks.Count > 0)
            {
                return returnTracks;
            }
            else
            {
                // load single track from the album itself
                connection.Open();
                command.CommandText = "SELECT 1 AS track_number, `ALBUM_TITLE` AS album_title, `DESCRIPTION` AS lyrics, `URL` AS video_url FROM `albums` WHERE ID = @selAlbumID";
                //command.Parameters.AddWithValue("@selAlbumID", albumID);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject newTrack = new JObject();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            newTrack.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        };
                        returnTracks.Add(newTrack);
                    }
                }
                connection.Close();
                return returnTracks;
            }                    
            
        }

    }
}
