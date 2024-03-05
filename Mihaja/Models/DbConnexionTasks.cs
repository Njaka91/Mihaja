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

        public static List<Task> ListeTasks (Task task)
        {
            var req = $"SELECT * FROM public.task WHERE taskname = '{task.TaskName}' AND taskuser = '{task.TaskUser}' ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();
            }
            catch (Exception e)
            {

                throw e;
            }

            return null;
        }
    }
}