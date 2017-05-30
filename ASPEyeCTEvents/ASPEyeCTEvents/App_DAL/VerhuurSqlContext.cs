﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ASPEyeCTEvents.Models;

namespace ASPEyeCTEvents.App_DAL
{
    public class VerhuurSqlContext : IVerhuurContext
    {
        public List<Verhuurd> GetAllVerhuurd()
        {
            List<Verhuurd> verhuurden = new List<Verhuurd>();
            using (SqlConnection connection = database.Connection)
            {
                string query = "Select * FROM Verhuurd Order By id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            verhuurden.Add(CreateProductFromReader(reader));
                        }
                    }
                }
            }
            return verhuurden;

        }
       

    public void Insert(Verhuurd verhuurd)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Verhuurd (productexemplaar_id, res_pb_id, datumIn, datumUit, Prijs, Betaald)" +
                               "VALUES (@productexemplaar_id, @res_pb_id, @datumIn, @datumUit, @Prijs, @Betaald)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productexemplaar_id", verhuurd.ProductExemplaarId);
                    command.Parameters.AddWithValue("@res_pb_id", verhuurd.GroepsLidId);
                    command.Parameters.AddWithValue("@datumIn", verhuurd.DatumIn);
                    command.Parameters.AddWithValue("@datumUit", verhuurd.DatumUit);
                    command.Parameters.AddWithValue("@prijs", verhuurd.Prijs);
                    command.Parameters.AddWithValue("@betaald", verhuurd.Betaald);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Verhuurd verhuurd)
        {
            string query = "UPDATE Verhuurd" +
                           " SET productexemplaar_id = @productexemplaar_id, res_pb_id = @res_pb_id, datumIn = @datumIn, datumUit = @datumUit, Prijs = @Prijs, Betaald = @betaald" +
                           " WHERE id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", verhuurd.Id);
                command.Parameters.AddWithValue("@productexemplaar_id", verhuurd.ProductExemplaarId);
                command.Parameters.AddWithValue("@res_pb_id", verhuurd.GroepsLidId);
                command.Parameters.AddWithValue("@datumIn", verhuurd.DatumIn);
                command.Parameters.AddWithValue("@datumUit", verhuurd.DatumUit);
                command.Parameters.AddWithValue("@prijs", verhuurd.Prijs);
                command.Parameters.AddWithValue("@betaald", verhuurd.Betaald);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(Verhuurd verhuurd)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Verhuurd WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", verhuurd.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private Verhuurd CreateProductFromReader(SqlDataReader reader)
        {
            return new Verhuurd(
                Convert.ToInt32(reader["id"]),
                Convert.ToInt32(reader["productexemplaar_id"]),
                Convert.ToInt32(reader["res_pb_id"]),
                Convert.ToDateTime(reader["datumIn"]),
                Convert.ToDateTime(reader["DatumUit"]),
                Convert.ToDouble(reader["prijs"]),
                Convert.ToBoolean(reader["betaald"]));
        }
    }
}