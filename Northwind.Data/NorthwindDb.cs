using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Northwind.Data
{
    public class NorthwindDb
    {
        private string _connectionString;

        public NorthwindDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Product> Search(string categoryName, int? minUnitsInStock)
        {

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT p.ProductName, p.QuantityPerUnit, p.UnitPrice, " +
                                  "p.UnitsInStock, c.CategoryName " +
                                  "FROM Products p " +
                                  "JOIN Categories c " +
                                  "ON p.CategoryId = c.CategoryId " +
                                  "WHERE 1=1";

            if (!String.IsNullOrEmpty(categoryName))
            {
                command.CommandText += " AND c.CategoryName = @categoryName";
                command.Parameters.AddWithValue("@categoryName", categoryName);
            }

            if (minUnitsInStock != null)
            {
                command.CommandText += " AND p.UnitsInStock >= @min";
                command.Parameters.AddWithValue("@min", minUnitsInStock);
            }
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product();
                p.Name = (string)reader["ProductName"];
                p.CategoryName = (string)reader["CategoryName"];
                p.QuantityPerUnit = (string)reader["QuantityPerUnit"];
                p.UnitPrice = (decimal)reader["UnitPrice"];
                p.UnitsInStock = (short)reader["UnitsInStock"];
                products.Add(p);
            }

            return products;

        }
    }
}