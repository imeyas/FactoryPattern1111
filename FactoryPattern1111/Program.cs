using System;

namespace FactoryPattern1111
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = VehicleFactory.GetVehicle();

            vehicle.Drive();

            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine($"\nWhat type of database would you like to create? List, Mongo or SQL...\n");
            var response = Console.ReadLine();

            var database = DataAccessFactory.GetDataAccessType(response);

            List<Product> products = database.LoadData();

            Console.WriteLine($"\nHere are the items in your product collection:\n");

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
            }

            database.SaveData();

        }
    }

    /*
     Possible steps:
Create an Interface named IVehicle that has a stubbed out public void Drive method
Create 2 new public classes that will conform to IVehicle
Example) Car, Motorcycle,  BigRig
These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
Now we will make our static VehicleFactory class
It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
Call this functionality in the Main method

    In one solution, you will need to create some new types.
A class called Product with 2 properties, Name and Price
An interface called IDataAccess with 2 methods, LoadData() and SaveData()
3 classes that implement the interface and its members (the methods), ListDataAccess, SQLDataAccess, and MongoDataAccess
Last you will need to create a class called DataAccessFactory


The 3 classes that implement your IDataAccess interface should provide implementations for the 2 methods 
LoadData(): Just print to the console “I am reading data from {whatever type class this is, i.e: list, SQL database, mongo database}” and then return a new list of Product.
SaveData(): Print “I am saving data to a {whatever type} database” to the console


Once those 3 classes have the methods implemented, you will need to fill out your factory
This shall be a public static class
There will be one method with the following signature: 				public static IDataAccess GetDataAccessType(string databaseType)
Switch on the databaseType variable
If a user types in “list” this should return a new instance of the ListDataAccess
If a user types in “sql” this should return a new instance of the SQLDataAccess
If a user types in “mongo” this should return a new instance of the MongoDataAccess


Lastly in the Main()
Ask the user what database they want to use: a List, SQL, or Mongo
Store their response in a variable
Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
Call the LoadData and SaveData methods of the IDataAccess variable
Run the program a few times using the different types.


     */
}