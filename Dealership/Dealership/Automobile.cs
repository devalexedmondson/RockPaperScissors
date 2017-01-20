using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Automobile
    {
        public string make;
        public string model;
        public int year;
        public int mileage;
        public string color;
        public double price; 

        public Automobile (string make, string model, int year, int mileage, string color, double price)
        {//whatever i'm passing in will become the new variables
            this.make = make;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.color = color;
            this.price = price;
        }

        public void Drive()
        {
            Console.WriteLine("Vroom, vroom");
        }
    }
}
