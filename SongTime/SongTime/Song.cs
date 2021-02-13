using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongTime
{
    class Song
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Time { get; set; }

        public Song(string title, string artistname, int time)
        {
            Title = title;
            ArtistName = artistname;
            Time = time;
        }
    }
}
