using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1111
{
    public static class VehicleFactory
    {
       public static string name = "vehicleType";
        public static IVehicle GetVehicle()
        {
            Console.WriteLine($"\nPlease enter the amount of tires for the vehicle, 2 or 4...\n");
            bool userInput = int.TryParse(Console.ReadLine(), out int amountOfTires);
            
            switch (amountOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
