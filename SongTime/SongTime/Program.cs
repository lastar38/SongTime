using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongTime
{
    class Program
    {
        static void Main(string[] args)
        {            
            var railgun = new Song("only my railgun", "fripSide", 255);
            var kizyuri = new Song("Love wit you", "fripSide", 302);
            var Kings = new Song("legendary future", "fripSide", 298);
            var oni = new Song("Riging Hope", "LiSA", 242);
            var sao = new Song("crossing field", "LiSA", 251);

            var songs = new Song[5] { railgun, kizyuri, Kings, oni, sao};

            foreach (var song in songs)
            {
                int min = song.Time / 60;
                int sec = song.Time % 60;
                Console.WriteLine($"{song.Title} {min}:{sec}");
            }
        }
    }
}
