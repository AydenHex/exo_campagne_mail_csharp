using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinesssCampagneMail.Models
{
    public class Campagne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nom { get; set; }
        public List<Mail> mails { get; set; }

        public Campagne(string nom)
        {
            this.nom = nom;
            this.mails = new List<Mail>();
        }
    }
}
