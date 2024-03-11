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
            var req = $"SELECT id, taskname, taskuser, statement FROM public.task WHERE taskuser = '{user}' ORDER BY id ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var task = new Task(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetBoolean(3));
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

        public static void AjoutTache (Task task)
        {
            var req = $"INSERT INTO public.task(taskname, taskuser, statement)VALUES( '{task.TaskName}', '{task.TaskUser}', '{task.TaskStatement}'); ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand (req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void SuppresionTache (int id)
        {
            var req = $"DELETE FROM public.task WHERE id = '{id}' ";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery ();
                connectionString.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public static void Edittask (int id, Task task)
        {
            var req = $"UPDATE public.task SET taskname= '{task.TaskName}' , statement= '{task.TaskStatement}'  WHERE id = '{id}'";

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}