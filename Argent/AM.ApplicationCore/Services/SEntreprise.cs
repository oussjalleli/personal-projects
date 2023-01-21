using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services
{
    public class SEntreprise : Service<Entreprise>, IEntreprise
    {
        public SEntreprise(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        
    }
}
