﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection
               (@"server=(localdb)\mssqllocaldb;
                initial catalog=ETrade;
                 integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();

            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection
                (@"server=(localdb)\mssqllocaldb;
                initial catalog=ETrade;
                 integrated security=true");

            if(connection.State == ConnectionState.Closed)
                connection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Products",connection);

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            reader.Close();
            connection.Close();

            return dt;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);
            sqlCommand.Parameters.AddWithValue("@name",product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id",_connection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.ExecuteNonQuery();

            _connection.Close();
        }


    }
}
