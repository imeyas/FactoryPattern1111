using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1111
{
    public class ListDataAccess : IDataAccess
    {
       
        public List<Product> LoadData()
        {
            Console.WriteLine($"\nI am reading data from the List database\n");
            return IDataAccess.products;
        }
        public List<Product> SaveData()
        {
            Console.WriteLine($"\nI am saving data to the List database\n");
            return IDataAccess.products;
        }
    }
}
