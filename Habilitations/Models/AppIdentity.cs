using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Habilitations.Models
{
    public class AppIdentity
    {
    }

    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Metier> Metiers { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}