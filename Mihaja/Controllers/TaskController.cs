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

        public ActionResult Create()
        {
            return RedirectToRoute("AddModal");
        }

        public ActionResult Create1()
        {
            return RedirectToRoute("AddModal");
        }
    }
}