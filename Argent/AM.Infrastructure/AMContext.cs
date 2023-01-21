using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure
{
    public class AMContext: DbContext
    {

        public DbSet<Participant> participants { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Cagnotte> Cagnottes { get; set; }
        public DbSet<Participation> Participations { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=ArgentDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }


        public AMContext()
        {
            
        }

        public AMContext(DbContextOptions<AMContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CagnotteC());
            modelBuilder.ApplyConfiguration(new EntrepriseC());
            modelBuilder.ApplyConfiguration(new ParticipantC());
            modelBuilder.ApplyConfiguration(new ParticipationC());


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .Properties<string>()
                .HaveAnnotation("MailProperty", true);
        }

    }
}
