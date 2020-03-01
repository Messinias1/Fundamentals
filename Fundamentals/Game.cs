using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Game
    {
        public string developer;
        private string rating;

        public Game(string aTitle, string aDeveloper, string aRating)
        {
            Title = aTitle;
            developer = aDeveloper;
            Rating = aRating;
        }
        // getters and setter
        public string Title { get; set; }
        public string Rating
        {
            get { return rating; }
            set {
                if (value == "E" || value == "E10" || value == "T" || value == "M")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
