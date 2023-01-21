using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string MailParticipant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        [NotMapped]
        public bool MailProperty => MailParticipant.StartsWith("Mail");

        public virtual ICollection<Cagnotte> Cagnottes { get; set; }
        public virtual List<Participation> Participations { get; set; }

        public Participant(int participantId, string mailParticipant, string nom, string prenom)
        {
            ParticipantId = participantId;
            MailParticipant = mailParticipant;
            Nom = nom;
            Prenom = prenom;
        }

        public Participant()
        {
        }
    }
}
