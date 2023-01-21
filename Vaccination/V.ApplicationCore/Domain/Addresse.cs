using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Addresse
    {
        //Properties
        public int CdePostal { get; set; }
        public int Rue { get; set; }
        public string Ville { get; set; }

    }
}
