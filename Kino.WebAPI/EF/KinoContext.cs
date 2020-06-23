using Kino.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace Kino.WebAPI.EF
{
    public class KinoContext : DbContext
    {
        public KinoContext()
        {
        }
        public KinoContext(DbContextOptions<KinoContext> options)
           : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Filmovi> Filmovi { get; set; }
        //public DbSet<FilmoviZanrovi> FilmoviZanrovi { get; set; }
        public DbSet<Zanrovi> Zanrovi { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<Komentari> Komentari { get; set; }
        public DbSet<Kupci> Kupci { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Sale> Sjedista { get; set; }
        public DbSet<Projekcije> Projekcije { get; set; }
        public DbSet<Ulaznice> Ulaznice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["KinoDatabase"].ConnectionString);
            optionsBuilder.UseSqlServer("Server=.;Database=160102;Trusted_Connection=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
