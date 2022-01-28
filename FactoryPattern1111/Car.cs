using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1111
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("\nBuilding a new Car!\n");
        }
        public void Drive()
        {
            Console.WriteLine("\nDriving my Car!\n");
        }
    }
}
