using Mono_praksa1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.SqlClient;


namespace Mono_praksa1.Repository
{
    public class CharacterRepository
    {
        public CharacterRepository() { }
        
        public string connectionString = @"Data Source=DESKTOP-RN0M5JB;Initial Catalog=master;Integrated Security=True";
        public List<Character> GetAll()
        {
            List<Character> characters = new List<Character>();
            SqlConnection connection = new SqlConnection(connectionString);
            string fetchAll = "Select * from Characters";
            SqlCommand get = new SqlCommand(fetchAll, connection);
            SqlDataReader reader = get.ExecuteReader();
            connection.Open();
            while (reader.HasRows)
            {
                characters.Add(new Character { Id = reader.GetInt32(0), Name = reader.GetString(1), Surname = reader.GetString(2) });
            }
            return characters;
        }

    }
}
