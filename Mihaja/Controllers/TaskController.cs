using Mihaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mihaja.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index(User user)
        {
            return View(DbConnexionTasks.ListeTasks(Session["username"].ToString()));
        }

        public ActionResult Modifier()
        {
            return View();
        }

        public ActionResult Create(FormCollection formCollection)
        {
            
            string taskname = formCollection["username"];
            Task task = new Task(formCollection["taskname"], Session["username"].ToString(),false);
            Session["idtsk"] = task.TaskId;
            DbConnexionTasks.AjoutTache(task);

            return RedirectToRoute("PageList");

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
           
            DbConnexionTasks.SuppresionTache(id);
            return RedirectToRoute("PageList");
        }
    }
}