using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Habilitations.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        [Required]
        public string Nom { get; set; }

        public virtual ICollection<Metier> Metiers { get; set; }
    }

    public class CategoriesDBContext : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
    }
}