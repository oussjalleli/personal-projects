using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services
{
    public class SParticipation: Service<Participation>, IParticipation
    {
        public SParticipation(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public int GetMontant(Cagnotte c)
        {
            return GetMany(p => c.CagnotteId == p.CagnotteFK).Select(p => p.Montant).Sum();
        }
        public int NombreCagnotte(Participant p)
        {
            return GetMany(d => d.ParticipantFK == p.ParticipantId).Count();
        }
    }
}
