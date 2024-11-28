using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Catalog;
namespace DAL
{
    public static class CatalogDBManager
    {
        public static IEnumerable<Product> GetAllProducts()
        {
            
            List<Product> allProducts = new List<Product>();

            // Invoke backend data into .NET application
            // needed database connectivity
            // you need to use 
            // 1. ADO.NET Object Model (JDBC) or  ---> ActiveX Data Objects
            // 2. Entity Framework (Hibernate)


            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kaust\Desktop\kaustubh data\TAP\Ravi_sir_MENTOR\src\TAP\TAP_NOV_2024\DOTNET\AmazonOnline\TesterApp\ECommerce.mdf"";Integrated Security=True";
            
            // 1. connect to database
            // query against database using SQL
            // get resultset from Query Processing
            // Create List of Products from resultset
            // return List of Products
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers"; 
            cmd.Connection = con;
            cmd.CommandText = query;

            IDataReader reader = new SqlDataReader();

            return allProducts;
        }


        

    }
}
