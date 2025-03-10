using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicWebPlayer
{
    internal class Album
    {
        public int ID { get; set; }
        public String SongName { get; set; }
        public String ArtistName { get; set; }
        public int ReleaseYear { get; set; }
        public String ImageURL { get; set; }
        public String PlayURL { get; set; }
        public String Description { get; set; }

    }
}
