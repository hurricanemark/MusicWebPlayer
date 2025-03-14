using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace MusicWebPlayer
{
    internal class SQLiteDAO
    {
        private string _connectionString = "Data Source=rolemimusic.db; Version=3;";

        public SQLiteDAO(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=rolemimusic.db; Version=3; New = True; Compress = True; ");

            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sqlite_conn;
        }

        public int CreateTables(SQLiteConnection sql_conn)
        {
            // Create ALBUMS table
            /*
            CREATE TABLE IF NOT EXISTS ALBUMS (
                rowid INTEGER PRIMARY KEY,
                ALBUM_TITLE TEXT NOT NULL,
                ARTIST TEXT NOT NULL,
                YEAR INTEGER NOT NULL,
                IMAGE_NAME TEXT NOT NULL,
                DESCRIPTION TEXT NOT NULL,
                URL TEXT NOT NULL
            );
             */
            SQLiteCommand sqlite_cmd;
            string sqlCreateALBUMSStmt = "PRAGMA foreign_keys = ON; CREATE TABLE IF NOT EXISTS ALBUMS (rowid INTEGER PRIMARY KEY, ALBUM_TITLE TEXT NOT NULL UNIQUE, ARTIST TEXT NOT NULL, YEAR INTEGER NOT NULL, IMAGE_NAME TEXT NOT NULL, DESCRIPTION TEXT NOT NULL, URL TEXT NOT NULL)";
            sqlite_cmd = sql_conn.CreateCommand();
            //sql_conn.Open();
            sqlite_cmd.CommandText = sqlCreateALBUMSStmt;
            sqlite_cmd.ExecuteNonQuery();

            // Create TRACKS table
            /*
            CREATE TABLE IF NOT EXISTS TRACKS (
                rowid INTEGER PRIMARY KEY,
                track_title TEXT DEFAULT NULL,
                number INTEGER DEFAULT NULL,
                video_url TEXT DEFAULT NULL,
                lyrics TEXT,
                albums_ID INTEGER NOT NULL,
                FOREIGN KEY (albums_ID) REFERENCES ALBUMS(rowid)
            );
             */
            string sqlCreateTRACKSStmt = "PRAGMA foreign_keys = ON; CREATE TABLE IF NOT EXISTS TRACKS(rowid INTEGER PRIMARY KEY, track_title TEXT DEFAULT NULL, number TEXT DEFAULT NULL, video_url TEXT DEFAULT NULL, lyrics TEXT, albums_ID INTEGER NOT NULL, FOREIGN KEY (albums_ID) REFERENCES ALBUMS(rowid))";
            sqlite_cmd.CommandText = sqlCreateTRACKSStmt;
            int returnCode = sqlite_cmd.ExecuteNonQuery();
            sql_conn.Close();

            return returnCode;

        }


        public int InsertAlbumData(SQLiteConnection sql_conn, Album newAlbm)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            sql_conn.Open();

            sqlite_cmd.CommandText = "INSERT INTO ALBUMS(ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL) " +
                                     "VALUES (@Title, @Artist, @Year, @ImageURL, @Description, @VideoUrl) ON CONFLICT(ALBUM_TITLE) DO NOTHING";
            sqlite_cmd.Parameters.AddWithValue("@Title", newAlbm.SongName);
            sqlite_cmd.Parameters.AddWithValue("@Artist", newAlbm.ArtistName);
            sqlite_cmd.Parameters.AddWithValue("@Year", newAlbm.ReleaseYear);
            sqlite_cmd.Parameters.AddWithValue("@ImageURL", newAlbm.ImageURL);
            sqlite_cmd.Parameters.AddWithValue("@Description", newAlbm.Description);
            sqlite_cmd.Parameters.AddWithValue("@VideoUrl", newAlbm.PlayURL);
            int returnCode = sqlite_cmd.ExecuteNonQuery();
            sql_conn.Close() ;
            return returnCode;
        }

        public int InsertSingleAlbum(SQLiteConnection sql_conn, Album album)
        {
            int insertStatus = 0;
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {

                string query = "INSERT INTO ALBUMS (ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL) " +
                               "VALUES (@Title, @Artist, @Year, @ImageURL, @Description, @VideoUrl) ON CONFLICT(ALBUM_TITLE) DO NOTHING";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Use parameterized queries to safely insert values
                    cmd.Parameters.AddWithValue("@Title", album.SongName);
                    cmd.Parameters.AddWithValue("@Artist", album.ArtistName);
                    cmd.Parameters.AddWithValue("@Year", album.ReleaseYear);
                    cmd.Parameters.AddWithValue("@ImageURL", album.ImageURL);
                    cmd.Parameters.AddWithValue("@Description", album.Description);
                    cmd.Parameters.AddWithValue("@VideoUrl", album.PlayURL);
                    insertStatus = cmd.ExecuteNonQuery();
                }
            }
            return insertStatus;
        }

        public int InsertTrackData(SQLiteConnection sql_conn, Track newTr)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO TRACKS(track_title, number, video_url, lyrics, albums_ID) " +
                                     "VALUES (@TrackName, @TrackNumber, @VideoURL, @Lyrics, @AlbumID)";

            sqlite_cmd.Parameters.AddWithValue("@TrackName", newTr.Name);
            sqlite_cmd.Parameters.AddWithValue("@TrackNumber", newTr.Number);
            sqlite_cmd.Parameters.AddWithValue("@VideoURL", newTr.VideoURL);
            sqlite_cmd.Parameters.AddWithValue("@Lyrics", newTr.Lyrics);
            sqlite_cmd.Parameters.AddWithValue("@AlbumID", newTr.Albums_ID);
            
            int returnCode = sqlite_cmd.ExecuteNonQuery();
            sql_conn.Close() ;
            return returnCode;
        }



        public List<Album> GetAlbumsData()
        {
            // start with an empty list
            List<Album> albums = new List<Album>();

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                string sqlCmdStmt = "SELECT rowid, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL FROM ALBUMS";
                using (SQLiteCommand cmd = new SQLiteCommand(sqlCmdStmt, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Album album = new Album
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("rowid")),
                                SongName = reader.GetString(reader.GetOrdinal("ALBUM_TITLE")),
                                ArtistName = reader.GetString(reader.GetOrdinal("ARTIST")),
                                ReleaseYear = reader.GetInt32(reader.GetOrdinal("YEAR")),
                                ImageURL = reader.GetString(reader.GetOrdinal("IMAGE_NAME")),
                                Description = reader.GetString(reader.GetOrdinal("DESCRIPTION")),
                                PlayURL = reader.GetString(reader.GetOrdinal("URL"))
                            };
                            albums.Add(album);
                        }
                    }
                }
            }

            return albums;
        }


        public Album GetAlbumByID(int albumID)
        {
            Album album = new Album();
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                string sqlCmdStmt = "SELECT rowid, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL FROM ALBUMS WHERE rowid = @ALBUMID";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.AddWithValue("@ALBUMID", albumID);
                cmd.CommandText = sqlCmdStmt;
                cmd.Connection = conn;
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            album.ID = reader.GetInt32(reader.GetOrdinal("rowid"));
                            album.SongName = reader.GetString(reader.GetOrdinal("ALBUM_TITLE"));
                            album.ArtistName = reader.GetString(reader.GetOrdinal("ARTIST"));
                            album.ReleaseYear = reader.GetInt32(reader.GetOrdinal("YEAR"));
                            album.ImageURL = reader.GetString(reader.GetOrdinal("IMAGE_NAME"));
                            album.Description = reader.GetString(reader.GetOrdinal("DESCRIPTION"));
                            album.PlayURL = reader.GetString(reader.GetOrdinal("URL"));
                        }
                    }
                }
                conn.Close();
            }
            return album;
        }


        public List<Album> SearchAlbumTitles(String SearchText)
        {
            // start with an empty list
            List<Album> albums = new List<Album>();

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                string sqlCmdStmt = "SELECT rowid, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION, URL FROM ALBUMS WHERE ALBUM_TITLE LIKE @searchPatern";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.AddWithValue("@searchPatern", "%" + SearchText + "%");
                cmd.CommandText = sqlCmdStmt;
                cmd.Connection = conn;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Album album = new Album
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("rowid")),
                            SongName = reader.GetString(reader.GetOrdinal("ALBUM_TITLE")),
                            ArtistName = reader.GetString(reader.GetOrdinal("ARTIST")),
                            ReleaseYear = reader.GetInt32(reader.GetOrdinal("YEAR")),
                            ImageURL = reader.GetString(reader.GetOrdinal("IMAGE_NAME")),
                            Description = reader.GetString(reader.GetOrdinal("DESCRIPTION")),
                            PlayURL = reader.GetString(reader.GetOrdinal("URL"))
                        };
                        albums.Add(album);
                    }
                }
                
            }

            return albums;
        }


        public String getAlbumDescription(string searchAlbumID)
        {
            String returnDescription = "";

            // connect to the SQLite server
            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                String sqlCmdStmnt = "SELECT DESCRIPTION FROM ALBUMS WHERE rowid = @searchtext";
                SQLiteCommand cmd = new SQLiteCommand(sqlCmdStmnt, conn);
                cmd.Parameters.AddWithValue("@searchtext", searchAlbumID);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        returnDescription = reader.GetOrdinal("DESCRIPTION").ToString();
                    }
                }
                conn.Close();
                return returnDescription;
            }
        }

        public List<Track> getTracksByAlbumID(string albumID)
        {
            // start with an empty list
            List<Track> tracks = new List<Track>();

            using (SQLiteConnection conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                string sqlCmdStmt = "SELECT rowid, track_title, number, video_url, lyrics, albums_ID  FROM TRACKS WHERE albums_ID = @albumid";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Parameters.AddWithValue("@albumid", albumID);
                cmd.CommandText = sqlCmdStmt;
                cmd.Connection = conn;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Track track = new Track
                        {
                            //Number = reader.GetInt32(reader.GetOrdinal("rowid")),
                            Name = reader.GetString(reader.GetOrdinal("track_title")),
                            Number = reader.GetString(reader.GetOrdinal("number")),
                            VideoURL = reader.GetString(reader.GetOrdinal("video_url")),
                            Lyrics = reader.GetString(reader.GetOrdinal("lyrics")),
                            Albums_ID = reader.GetInt32(reader.GetOrdinal("albums_ID"))
                        };
                        tracks.Add(track);
                    }
                }

            }

            return tracks;
        }
    }
}
