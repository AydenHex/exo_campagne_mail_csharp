using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinesssCampagneMail.Models
{
    public class Mail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }

        public int CampagneId { get; set; }
        public Campagne Campagne { get; set; }

        public Mail() { }

        public Mail(string nom, string prenom, string email, int campagneId)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.CampagneId = campagneId;
        }

        public Mail(string[] dataMail, int campagneId)
        {
            this.nom = dataMail[0];
            this.prenom = dataMail[1];
            this.email = dataMail[2];
            this.CampagneId = campagneId;
        }
    }

}
