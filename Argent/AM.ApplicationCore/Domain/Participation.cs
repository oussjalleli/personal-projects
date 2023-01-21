using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Participation
    {
        public int Montant { get; set; }
        [Key]
        [Column(Order =1)]
        public int CagnotteFK { get; set; }
        public virtual Cagnotte Cagnotte { get; set; }
        [Key]
        [Column(Order =2)]
        public int ParticipantFK { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
