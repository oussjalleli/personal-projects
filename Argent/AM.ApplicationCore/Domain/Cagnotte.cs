using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum Type
    {
        CadeauCommun,
        DépenseàPlusieurs,
        ProjetSolitaire,
        Autres
    }
    public class Cagnotte
    {
        public int CagnotteId { get; set; }
        [Required(ErrorMessage ="This field shouldn''t be left blank")]
        public string Titre { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Photo { get; set; }
        [Range(0,int.MaxValue)]
        public int SommeDemandée { get; set; }
        public Type Type { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateLimite { get; set; }

        public virtual  ICollection<Participant> participants { get; set; }
        
        public virtual int EntrepriseId { get; set; }
        public virtual Entreprise Entreprise { get; set; }
        public virtual IList<Participation> Participations { get; set; }

        public Cagnotte(int cagnotteId, string titre, string description, string photo, int sommeDemandée, Type type, DateTime dateLimite)
        {
            CagnotteId = cagnotteId;
            Titre = titre;
            Description = description;
            Photo = photo;
            SommeDemandée = sommeDemandée;
            Type = type;
            DateLimite = dateLimite;
        }

        public Cagnotte()
        {
        }
    }
}
