using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DebutValidite { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FinValidite { get; set; }

        //[ForeignKey("Categorie")]
        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}