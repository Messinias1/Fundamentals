using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        // static method is contained on class itself
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        // an object method to do whate the static method is doing
        public int getSongCount()
        {
            return songCount;
        }
    }
}
