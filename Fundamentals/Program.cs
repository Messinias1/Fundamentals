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
            Dog dog1 = new Dog("Caleb", "Husky", 5);

            Dog dog2 = new Dog("Heidi", "Husky", 13);

            Console.WriteLine(dog1.name + " " + dog1.age);
            Console.WriteLine(dog2.name + " " + dog2.age);
        }
    }
}
