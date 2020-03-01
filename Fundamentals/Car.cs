using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Car
    {
        public string model;
        public string make;
        public int price;

        // constructor, a special method that gets called when you create an object
        public Car(string aMake, string aModel, int aPrice)
        {
            this.model = aModel;
            this.make = aMake;
            this.price = aPrice;
        }
    }
}
