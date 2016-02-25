using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Habilitations.Models
{
    public class Job
    {
        public int ID { get; set; }

        public DateTime? DebutJob { get; set; }

        public DateTime? FinJob { get; set; }

        public int MetierId { get; set; }
        public Metier Metier { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}