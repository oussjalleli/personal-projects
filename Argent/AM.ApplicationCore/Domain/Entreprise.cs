using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    public class Entreprise
    {
         public int EntrepriseId { get; set; }
        public string NomEntreprise { get; set; }
        public string MailEntreprise { get; set; }
        public string AdresseEntreprise { get; set; }

        [NotMapped]
        public bool MailProperty => MailEntreprise.StartsWith("Mail");

        public virtual IList<Cagnotte> Cagnottes { get; set; }

        public Entreprise(int entrepriseId, string nomEntreprise, string mailEntreprise, string adresseEntreprise)
        {
            EntrepriseId = entrepriseId;
            NomEntreprise = nomEntreprise;
            MailEntreprise = mailEntreprise;
            AdresseEntreprise = adresseEntreprise;
        }

        public Entreprise()
        {
        }

        public override string ToString()
        {
            return "IdEntreprise: " + EntrepriseId + " NomEntreprise: " + NomEntreprise + " Adresse Email: " + MailEntreprise + " Adresse Entreprise: " + AdresseEntreprise;
        }
        

        
    }
}
