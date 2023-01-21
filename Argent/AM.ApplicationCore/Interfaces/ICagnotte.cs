using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = AM.ApplicationCore.Domain.Type;

namespace AM.ApplicationCore.Interfaces
{
    public interface ICagnotte : IService<Cagnotte>
    {
        public IList<Cagnotte> GetCagnottesEnCours();
        public IList<Entreprise> deuxEntreprise(Type Type);
        public Entreprise en();
       
    }
}
