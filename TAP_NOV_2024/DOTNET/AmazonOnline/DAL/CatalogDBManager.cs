﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Catalog;
namespace DAL
{
    public static class CatalogDBManager
    {
        // CRUD Operations against database

        // read
        public static IEnumerable<Product> GetAllProducts()
        {

            // Invoke backend data into .NET application
            // needed database connectivity
            // you need to use 
            // 1. ADO.NET Object Model (JDBC) or  ---> ActiveX Data Objects
            // 2. Entity Framework (Hibernate)

            // 1. connect to database
            // query against database using SQL
            // get resultset from Query Processing
            // Create List of Products from resultset
            // return List of Products

            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kaust\Desktop\kaustubh data\TAP\Ravi_sir_MENTOR\src\TAP\TAP_NOV_2024\DOTNET\AmazonOnline\TesterApp\ECommerce.mdf"";Integrated Security=True";            
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers"; 
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;
             
            try
            {
                // using Connected data Access of ADO.NET
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["productID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int unitPrice = int.Parse(reader["price"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());

                    Product theProduct = new Product
                    {
                        ID = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };

                    allProducts.Add(theProduct);
                }
                reader.Close();
            }
            catch(SqlException exp)
            {
                string message = exp.Message;
            }

            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsUsingDisconnected()
        {
            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kaust\Desktop\kaustubh data\TAP\Ravi_sir_MENTOR\src\TAP\TAP_NOV_2024\DOTNET\AmazonOnline\TesterApp\ECommerce.mdf"";Integrated Security=True";
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                DataSet ds = new DataSet(); // Collection of Data
                // empty dataset

                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                da.Fill(ds);
                // dataset will be filled with results received from database

                // DataSet is collecction of DataTable objects retrived from database
                // after fill method

                DataTable dt = ds.Tables[0];
                // DataTable is a collection of DataTow Objects

                foreach (DataRow datarow in dt.Rows)
                {
                    int id = int.Parse(datarow["productID"].ToString());
                    string title = datarow["title"].ToString();
                    string description = datarow["description"].ToString();
                    float unitPrice = float.Parse(datarow["price"].ToString());
                    int quantity = int.Parse(datarow["quantity"].ToString());

                    allProducts.Add(new Product()
                    {
                        ID = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    });
                }
            }

            catch(SqlException exp)
            {
                string message = exp.Message;
            }

            return allProducts;
        }

        // create
        public static bool Insert(Product theProduct)
        {
            bool status = false;
            // uisng connected data access mode

            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kaust\Desktop\kaustubh data\TAP\Ravi_sir_MENTOR\src\TAP\TAP_NOV_2024\DOTNET\AmazonOnline\TesterApp\ECommerce.mdf"";Integrated Security=True";
                IDbCommand cmd = new SqlCommand();
            }

            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            finally
            {

            }
            // logic for insertion
            return status;
        }

        // update
        public static bool Update(Product theProduct)
        {
            bool status = false;
            // logic for updation
            return status;
        }

        // delete
        public static bool Delete(int productID)
        {
            bool status = false;
            // logic for deletion
            return status;
        }
    }
}
