using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Habilitations.Models
{
    public class Job
    {
        public int ID { get; set; }

        public DateTime? DebutJob { get; set; }

        public DateTime? FinJob { get; set; }

        //[ForeignKey("Metier")]
        public int MetierId { get; set; }
        public virtual Metier Metier { get; set; }

        //[ForeignKey("User")]
    }
}