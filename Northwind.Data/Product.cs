using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    public class Product
    {
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string CategoryName { get; set; }
    }
}
