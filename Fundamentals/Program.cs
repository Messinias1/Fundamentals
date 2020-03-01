﻿using System;
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
            // WITHOUT A CONSTRUCTOR
            //car1.make = "Saab";
            //car1.model = "9-3";
            //car1.price = 12000;
            Console.WriteLine(car1.make);

            Car car2 = new Car("Volvo", "s60", 20000);

            car2.model = "XC-90";
            Console.WriteLine(car2.make);
            Console.WriteLine(car2.model);

            // calling object method
            Console.WriteLine(car1.IsSwedish());

            Cat cat1 = new Cat("Yellow", "orange", 16);
            Console.WriteLine(cat1.age);

            Cat cat2 = new Cat();
            cat2.name = "Cluck";
            Console.WriteLine(cat1.IsOld());
        }
    }
}
