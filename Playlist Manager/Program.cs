using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist_Manager
{
    public class Program
    {
        static void Main(string[] args)
        {
            var playlist = new List<Song>();
           playlist.AddRange(new Song[] { new Song("Bohemian Rhapsody", "Queen", 354, 1975),
                                          new Song("Imagine", "John Lennon", 183, 1971),
                                          new Song("Billie Jean", "Michael Jackson", 294, 1983),
                                          new Song("Shape of You", "Ed Sheeran", 233, 2017),
                                          new Song("Blinding Lights", "The Weeknd", 200, 2020)});

            // Exercise 3.1: Sort by title (alphabetical)
            // TODO: Display songs sorted by title
            Console.WriteLine("Song by Title");
            Console.WriteLine("==============");
            var byTitle = playlist.OrderBy(p => p.Title).ToList();
        

            foreach (var title in byTitle) 
            {
                    Console.WriteLine(title);
            }
            Console.WriteLine();

            // Exercise 3.2: Sort by year (oldest first)
            // TODO: Display songs sorted by year
            Console.WriteLine("Song by Year");
            Console.WriteLine("==============");
            var byYear = playlist.OrderBy(p => p.Year).ToList();
          
            foreach (var year in byYear)
            {
                Console.WriteLine(year);
            }
            Console.WriteLine();
            // Exercise 3.3: Sort by duration (shortest to longest)
            // TODO: Display songs sorted by duration
            Console.WriteLine("Song by duration");
            Console.WriteLine("==============");
            var byDuration = playlist.OrderBy(p=>p.Duration).ToList();

            foreach(var duration in byDuration)
            {
                Console.WriteLine(duration);
            }
            Console.WriteLine();
            // Exercise 3.4: Sort by artist, then by title
            // TODO: Use ThenBy() to sort by artist, then title
            Console.WriteLine("Song by artist");
            Console.WriteLine("==============");
            var byArtist= playlist.OrderBy(p => p.Artist).ToList();

            foreach (var artist in byArtist)
            {
                Console.WriteLine(artist);
            }
            Console.WriteLine();
            // Exercise 3.5: Create a reversed list
            // TODO: Display songs in reverse order of their addition
            Console.WriteLine("Song by artist");
            Console.WriteLine("==============");
            var reversedList = playlist.ToList();
            reversedList.Reverse();

            foreach (var song in reversedList)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();

            


            Console.ReadLine();
        }
    }
}
