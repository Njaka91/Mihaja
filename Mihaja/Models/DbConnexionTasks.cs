using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Mihaja.Models
{
    public class DbConnexionTasks
    {
        public static NpgsqlConnection connectionString =
           new NpgsqlConnection(ConfigurationManager.ConnectionStrings["todomihaja"].ConnectionString);

        public static List<Task> ListeTasks (string user)
        {
            List<Task> tasks = new List<Task>();
            var req = $"SELECT taskname, taskuser, statement FROM public.task WHERE taskuser = '{user}' ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var task = new Task(reader.GetString(0), reader.GetString(1),reader.GetBoolean(2));
                    tasks.Add(task);
                }
                connectionString.Close();
            }
            catch (Exception e)
            {

                throw e;
            }

            return tasks;
        }
    }
}