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
            int[,] numberGrid = { {1, 2 }, {3, 4 }, {5, 6 } };

            int[,] myArray = new int[2, 3];
            myArray[0, 0] = 5;
            Console.WriteLine(myArray[0, 0]);

            int uBound0 = numberGrid.GetUpperBound(0);
            int uBound1 = numberGrid.GetUpperBound(1);
            for (int i = 0; i <= uBound0; i++)
            {
                for (int j = 0; j <= uBound1; j++)
                {
                    int res = numberGrid[i, j];
                    Console.WriteLine(res);
                }
            }
        }
    }
}
