using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind.Data;

namespace WebApplication6.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CategoryName { get; set; }
        public int? MinUnitsInStock { get; set; }
    }
}