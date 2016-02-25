using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Habilitations.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Matricule { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }
        [Required]
        public DateTime DateEntree { get; set; }
    }

    public class USerDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}