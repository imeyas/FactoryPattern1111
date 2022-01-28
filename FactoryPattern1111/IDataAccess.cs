using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern1111
{
    public interface IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product() {Name = "C# Book", Price = 45.00},
            new Product() {Name = "Hammer", Price = 17.00}
        };
        public List<Product> LoadData()
        {
            return products;
        }
        public List<Product> SaveData()
        {
            return products;
        }

       
    }
}
