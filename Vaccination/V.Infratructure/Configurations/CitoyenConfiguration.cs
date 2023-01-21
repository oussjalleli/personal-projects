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
    public class CitoyenConfiguration : IEntityTypeConfiguration<Citoyen>
    {
        public void Configure(EntityTypeBuilder<Citoyen> builder)
        {

            builder.OwnsOne(c => c.Adresse);

        }
    }
}
