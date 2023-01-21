using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ParticipationC : IEntityTypeConfiguration<Participation>
    {
        public void Configure(EntityTypeBuilder<Participation> builder)
        {
            builder.HasKey(t => new
            {
                t.ParticipantFK,
                t.CagnotteFK
                 });

            builder.HasOne(t => t.Participant)
               .WithMany(f => f.Participations)
               .HasForeignKey(t => t.ParticipantFK);

            builder.HasOne(t => t.Cagnotte)
              .WithMany(p => p.Participations)
              .HasForeignKey(t => t.CagnotteFK);
        }
    }
}
