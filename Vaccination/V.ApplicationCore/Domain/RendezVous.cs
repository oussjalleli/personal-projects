using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{ 
    public class RendezVous
    {
        public string CodeInfermiere { get; set; }

        public DateTime DateVaccination { get; set; }

        public int NbrDoses { get; set; }
        
        public int VaccinId { get; set; }
        
        public virtual Vaccin Vaccin { get; set; }

        public int CitoyenId { get; set; }

        public virtual Citoyen Citoyen { get; set; }

    }

}
