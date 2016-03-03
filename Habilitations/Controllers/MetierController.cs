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
            else
            {
                users = null;
            }

            return View(users);
        }
        
        //
        // GET: /Metier/Get

        public ActionResult Get()
        {
            //var metiers = db.Metiers.Select(c => new { c.ID, c.Nom });

            var metiers = db.Metiers.Select(m => new { id = m.ID, nom = m.Nom, categorieId = m.CategorieId, categorieNom = m.Categorie.Nom }).OrderBy(m => new { m.categorieId });

            return Json(metiers, JsonRequestBehavior.AllowGet);
        }


        //
        // GET: /Metier/List/5

        public ActionResult List(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            //var jobs = db.Jobs.Where(j => j.ID.Equals(user.ID));
            var jobs = from j in db.Jobs
                       where j.UserId == user.ID
                       select j;

            return View(jobs);
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
                System.Diagnostics.Debug.WriteLine(job);
                db.Jobs.Add(job);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(job);
        }

    }
}
