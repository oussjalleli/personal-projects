using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Citoyen
    {
        //Properties
        public Addresse Adresse { get; set; }

        public int Age { get; set; }

        public String CIN { get; set; }

        [Key]
        public int CitoyenId { get; set; }

        public string Nom { get; set; }

        [Required]
        public int NumeroEvax { get; set; }

        public string Prenom { get; set; }

        public int Telephone { get; set; }

        //Relationships
        public virtual ICollection<RendezVous> RendezVous { get; set; }

        
    }   

      
}
