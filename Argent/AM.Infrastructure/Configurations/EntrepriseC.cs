using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class EntrepriseC : IEntityTypeConfiguration<Entreprise>

    {
        public void Configure(EntityTypeBuilder<Entreprise> builder)
        {
            

          
        }
    }
}
