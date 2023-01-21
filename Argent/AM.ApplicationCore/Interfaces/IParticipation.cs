using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IParticipation: IService<Participation>
    {
        public int GetMontant(Cagnotte c);
        public int NombreCagnotte(Participant p);
    }
}
