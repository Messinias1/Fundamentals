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
            Game game1 = new Game("Skyrim", "Bethesda", "M");
            Game game2 = new Game("Fallout 3", "Bethesda", "M");

            Console.WriteLine(game1.Rating);
            Console.WriteLine(game2.Title);
        }
    }
}
