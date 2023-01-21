using AM.ApplicationCore.Domain;
using AM.Infratructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    public class VContext : DbContext
    {
        public DbSet<Vaccin> Vaccins { get; set; }
        public DbSet<Citoyen> Citoyens { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<CentreVaccination> CentreVaccinations { get; set; }

        public VContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);

            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog = VaccinGasmiSkander;Integrated Security=true";
            dbContextOptionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CitoyenConfiguration());
            modelBuilder.ApplyConfiguration(new RendezVousConfiguration());

        }

        

    }
}