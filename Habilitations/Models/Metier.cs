using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Habilitations.Models
{
    public class Metier
    {
        public int ID { get; set; }
        [Required]
        public string Nom { get; set; }

        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }
    }

    public class MetiersDBContext : DbContext
    {
        public DbSet<Metier> Metiers { get; set; }
    }
}