﻿using System;
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

        //[ForeignKey("Categorie")]
        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}