using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infratructure.Configurations
{
    public class RendezVousConfiguration : IEntityTypeConfiguration<RendezVous>
    {
        public void Configure(EntityTypeBuilder<RendezVous> builder)
        {
           builder.HasKey(rv => new {rv.DateVaccination, rv.VaccinId, rv.CitoyenId});
            
           builder.HasOne(rv => rv.Vaccin)
                .WithMany(v => v.RendezVous)
                .HasForeignKey(rv => rv.VaccinId);

            builder.HasOne(rv => rv.Citoyen)
                .WithMany(v => v.RendezVous)
                .HasForeignKey(rv => rv.CitoyenId);

        }
    }
}
