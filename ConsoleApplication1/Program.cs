using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindDb db = new NorthwindDb(Properties.Settings.Default.ConStr);
            IEnumerable<Product> products = db.Search("Beverages", 50);
            products.ToList().ForEach(p =>
            {
                Console.WriteLine($"{p.Name} - {p.CategoryName} - {p.UnitsInStock}");
            });

            Console.ReadKey(true);
        }
    }
}
