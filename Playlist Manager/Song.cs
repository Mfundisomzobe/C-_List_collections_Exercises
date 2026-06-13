using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_Manager
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; } // in seconds
        public int Year { get; set; }

        public Song(string title,string artist,int duration, int year)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Year = year;
            
        }
        public override string ToString()
        {
            return $"{Title} - {Artist} ({Year}) [{Duration / 60}m{Duration % 60}s]";
        }
    }
}
