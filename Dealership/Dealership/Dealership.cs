using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class Dealership
    {
        public Inventory inventory;

        public Dealership()
        {
            inventory = new Inventory();
        }

        public void AddVehicle(Automobile automobile)
        {
            inventory.automobiles.Add(automobile);
        }
        public void RemoveVehicle(Automobile automobile)
        {
        inventory.automobiles.Remove(automobile);
        }
    }
}
