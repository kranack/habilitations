using Habilitations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Habilitations.Controllers
{
    public class MetierController : Controller
    {
        private USerDBContext db = new USerDBContext();

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

    }
}
