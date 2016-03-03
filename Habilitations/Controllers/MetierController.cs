using Habilitations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Habilitations.Controllers
{
    public class MetierController : Controller
    {
        private AppDBContext db = new AppDBContext();

        //
        // GET: /Metier/

        public ActionResult Index(string searchString)
        {
            var users = from u in db.Users
                         select u;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.Matricule.Contains(searchString));
            }

            return View(users);
        }
        
        //
        // GET: /Metier/Get

        public ActionResult Get()
        {
            var categories = db.Metiers.Select(c => new { c.ID, c.Nom }).OrderBy(c => new { c.CategorieId });

            return Json(categories, JsonRequestBehavior.AllowGet);
        }
        //
        // GET: /Metier/Add/5

        public ActionResult Add(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            Job job = new Job();
            job.UserId = user.ID;
            return View(job);
        }

        //
        // POST: /Metier/Add

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(job);
        }

    }
}
