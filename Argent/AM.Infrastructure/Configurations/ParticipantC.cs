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
    public class ParticipantC : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            //Many to Many
            builder.HasMany(f => f.Cagnottes)
            .WithMany(p => p.participants)
            .UsingEntity(
                j => j.ToTable("Participation")
                );//Table d'association
        }
    }
}