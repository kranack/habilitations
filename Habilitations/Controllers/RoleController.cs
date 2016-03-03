using Habilitations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Habilitations.Controllers
{
    public class RoleController : Controller
    {
        private AppDBContext db = new AppDBContext();


        //
        // GET: /Role/List

        public ActionResult List(int id = 0)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user.Roles);
        }

        //
        // GET: /Role/Get

        public ActionResult Get()
        {
            var roles = db.Roles.Select(r => new { id = r.ID, nom = r.Nom });

            return Json(roles, JsonRequestBehavior.AllowGet);
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
            int userId = id;

            return View(userId);
        }

        //
        // POST: /Metier/Add

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(int userId, int roleId)
        {
            Role role = db.Roles.Find(roleId);
            User user = db.Users.Find(userId);

            if (role != null || user != null)
            {
                user.Roles.Add(role);
                role.Users.Add(user);
                db.SaveChanges();

                return RedirectToAction("List", new { id = userId });
            }

            return View(userId);
        }

    }
}
