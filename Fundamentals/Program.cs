using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Song comeAsYouAre = new Song("Come As You Are", "Nirvana", 200);
            Song smellsLikeTeenSpirit = new Song("Smells Like Teen Spirit", "Nirvana", 250);

            // object method
            Console.WriteLine(comeAsYouAre.getSongCount());
            // static method
            Console.WriteLine(Song.songCount);
        }
    }
}
