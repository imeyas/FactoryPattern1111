using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1111
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("\nBuilding a new Motorcycle!\n");
        }
        public void Drive()
        {
            Console.WriteLine("\nDriving my Motorcycle!\n");
        }
    }
}
