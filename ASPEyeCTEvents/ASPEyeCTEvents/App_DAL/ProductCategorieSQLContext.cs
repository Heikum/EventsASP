﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents.App_DAL
{
    public class ProductCategorieSQLContext : IProductCategorieContext
    {
        public List<ProductCategorie> GetAllCategories()
        {
            List<ProductCategorie> categories = new List<ProductCategorie>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM PRODUCTCAT ORDER BY id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(CreateProductCategorieFromReader(reader));
                        }
                    }
                }
            }
            return categories;
        }

        public void Insert(ProductCategorie productCategorie)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO PRODUCTCAT (productcat_id, naam)" +
                               "VALUES (@productcatid, @naam)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productcatid", productCategorie.Id);
                    command.Parameters.AddWithValue("@naam", productCategorie.Naam);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(ProductCategorie productCategorie)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE PRODUCTCAT" +
                               " SET productcat_id = @productcatid, naam = @naam" +
                               " WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", productCategorie.Id);
                    command.Parameters.AddWithValue("@productcatid", productCategorie.ProductCatId);
                    command.Parameters.AddWithValue("@naam", productCategorie.Naam);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(ProductCategorie productCategorie)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM PRODUCTCAT WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", productCategorie.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private ProductCategorie CreateProductCategorieFromReader(SqlDataReader reader)
        {
            return new ProductCategorie(
                Convert.ToInt32(reader["id"]),
                Convert.ToInt32(reader["productcat_id"]),
                Convert.ToString(reader["naam"])
            );
        }
    }
}