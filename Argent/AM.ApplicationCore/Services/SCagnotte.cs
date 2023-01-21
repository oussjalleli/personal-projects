using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = AM.ApplicationCore.Domain.Type;
namespace AM.ApplicationCore.Services
{
    public class SCagnotte : Service<Cagnotte>, ICagnotte
    {
        public SCagnotte(IUnitOfWork unitOfWork) : base(unitOfWork) { }



        public IList<Cagnotte> GetCagnottesEnCours()
        {
            var currentCagnottes = GetMany(c => c.DateLimite > DateTime.Now).ToList();
            return currentCagnottes;
        }
        public IList<Entreprise> deuxEntreprise(Type Type)
        {
            return GetAll()
        .Where(c => c.Type == Type)
        .GroupBy(c => c.Entreprise)
        .OrderByDescending(g => g.Count())
        .Take(2)
        .Select(g => g.Key)
        .ToList();
        }
        public Entreprise en()
        {
            return (Entreprise)GetAll().ToList().OrderByDescending(g => g.Participations.Count()).Take(1).Select(g => g.Entreprise);
        }

        public List<Cagnotte> GetNom(string nom)
        {
            List<Cagnotte> listcagnotte = new List<Cagnotte>();
            foreach (var cagnotte in this.GetAll())
            {

                if (cagnotte.Titre == nom)
                {
                    listcagnotte.Add(cagnotte);
                }
            }
            return listcagnotte;
            
        }

        
    }
}
