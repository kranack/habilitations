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
        // GET: /Metier/Add/5

        public ActionResult Add(int id = 0)
        {
            User user = db.Users.Find(id);
            DbSet<Categorie> categories = db.Categories;
            System.Diagnostics.Debug.WriteLine(user.Matricule);
            foreach(Categorie categorie in categories) {
                System.Diagnostics.Debug.WriteLine(categorie.Nom);
            }
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        //
        // POST: /Metier/Add

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Job job)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View(job);
        }

    }
}
