using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class CentreVaccination 
    {
        //Properties
        public int Capacite { get; set; }

        public int CentreVaccinationId { get; set; }

        public int NbChaises { get; set; }

        public int NumTelephone { get; set; }

        public string ResponsableCentre { get; set; }

        //Relationships
        public virtual ICollection<Vaccin> Vaccins { get; set; }


       
    }
}
