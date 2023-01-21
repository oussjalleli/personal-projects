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
    public class CagnotteC : IEntityTypeConfiguration<Cagnotte>
    {
        public void Configure(EntityTypeBuilder<Cagnotte> builder)
        {
            //Many to Many
            builder.HasMany(f => f.participants)
            .WithMany(p => p.Cagnottes)
            .UsingEntity(
                j => j.ToTable("Participation")
                );//Table d'association

            //One To Many
            builder.HasOne(f => f.Entreprise)
                .WithMany(p => p.Cagnottes);
               
        }
    }
}
