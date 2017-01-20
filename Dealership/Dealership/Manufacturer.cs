using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Manufacturer
    {
        public Automobile CreateVehicle()
        {// Use this to build a player!
            Console.WriteLine("Enter a make");
            string make = Console.ReadLine();
            Console.WriteLine("Enter a model");
            string model = Console.ReadLine();
            Console.WriteLine("Enter a make");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a mileage");
            int mileage = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();
            Console.WriteLine("Enter a price");
            double price = double.Parse(Console.ReadLine());
            return new Automobile(make, model, year, mileage, color, price);
        }
    }
}
