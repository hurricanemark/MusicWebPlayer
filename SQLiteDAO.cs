using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sqlCreateALBUMSStmt = "PRAGMA foreign_keys = ON; CREATE TABLE IF NOT EXISTS ALBUMS (rowid INTEGER PRIMARY KEY, ALBUM_TITLE TEXT NOT NULL, ARTIST TEXT NOT NULL, YEAR INTEGER NOT NULL, IMAGE_NAME TEXT NOT NULL, DESCRIPTION TEXT NOT NULL, URL TEXT NOT NULL)";
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
            string sqlCreateTRACKSStmt = "PRAGMA foreign_keys = ON; CREATE TABLE IF NOT EXISTS TRACKS(rowid INTEGER PRIMARY KEY, track_title TEXT DEFAULT NULL, number INTEGER DEFAULT NULL, video_url TEXT DEFAULT NULL, lyrics TEXT, albums_ID INTEGER NOT NULL, FOREIGN KEY (albums_ID) REFERENCES ALBUMS(rowid))";
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

        public int InsertTrackData(SQLiteConnection sql_conn, Track newTr, int albumID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            
            sqlite_cmd.CommandText = "INSERT INTO TRACKS(track_title, number, video_url, lyrics, albums_ID) " +
                                     "VALUES (" + newTr.Name + ", " + newTr.Number + ", " + newTr.VideoURL +", " + newTr.Lyrics + ", " + albumID + ") ";
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
    }
}
