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
            Car car1 = new Car("Saab", "9-3", 12000);
            //car1.make = "Saab";
            //car1.model = "9-3";
            //car1.price = 12000;
            Console.WriteLine(car1.make);

            Car car2 = new Car("Volvo", "s60", 20000);
            //car2.make = "Volvo";
            //car2.model = "s60";
            //car2.price = 20000;
            car2.model = "XC-90";
            Console.WriteLine(car2.make);
            Console.WriteLine(car2.model);

            Cat cat1 = new Cat();
            cat1.name = "Yellow";
            cat1.color = "Orange";
            cat1.age = 16;
            Console.WriteLine(cat1.age);
        }
    }
}
