using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealership dealership = new Dealership();
            Manufacturer manufacture = new Manufacturer();
            Automobile car = manufacture.CreateVehicle();
            dealership.AddVehicle(car);
        }
    }
}
