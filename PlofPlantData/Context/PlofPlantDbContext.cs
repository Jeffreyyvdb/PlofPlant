using Microsoft.EntityFrameworkCore;
using PlofPlantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlofPlantData.Context
{
    public class PlofPlantDbContext : DbContext
    {
        // dotnet ef migrations add [migration naam]

        // dotnet ef database update

        // SQL RANDOM DATE 
        // SELECT DATEADD(day, FLOOR(RAND()*(0-(-3000)+1))-3000, GETDATE()) AS DateAdd;

        // https://jike.in/?qa=718422/sql-server-windows-azure-sql-database-identity-auto-increment-column-skips-values
        // http://www.aisoftwarellc.com/blog/post/sql-server-identity-values-jump-by-1000-when-it-is-restarted/2033

        public PlofPlantDbContext()
        {
        }
        public PlofPlantDbContext(DbContextOptions<PlofPlantDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("server=.;database=PlofPlantDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Patient>()
            //    .Property(b => b.IsActief)
            //    .HasDefaultValue(true);

            //modelBuilder.Entity<Notitie>()
            //    .Property(b => b.IsActief)
            //    .HasDefaultValue(true);
        }

        public DbSet<Kas> Kassen { get; set; }
        public DbSet<KasData> KasData { get; set; }
        public DbSet<Verdieping> Verdiepingen { get; set; }
        public DbSet<VerdiepingData> VerdiepingData { get; set; }
        public DbSet<Plant> Planten { get; set; }
    }
}
