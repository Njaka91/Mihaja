using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Mihaja.Models
{
    public class DbConnexionUser
    {
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todomihaja"].ConnectionString);

        public static Boolean CheckUser (User user)
        {
            var req = $"SELECT * FROM public.user WHERE name = '{user.UserName}' AND password = '{user.UserPassword}'";
            var hasUser = false;

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.Read();
                connectionString.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            return hasUser;
        }
    }
}