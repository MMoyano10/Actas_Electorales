using Microsoft.EntityFrameworkCore;
using Votaciones.Models;

namespace Votaciones.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Acta> Actas { get; set; }
        public DbSet<Canton> Canton { get; set; }
        public DbSet<Jrv> Jrv { get; set; }
        public DbSet<Parroquia> Parroquia { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Recinto> Recinto { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<JrvNovedade> Jrv_Novedades { get; set; }
        public DbSet<MembershipUser> MembershipUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Jrv>()
            .Property(j => j.IdJrv)
            .HasColumnName("id_jrv");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<JrvNovedade>()
                .Property(j => j.IdNovedades)
                .HasColumnName("id_novedades");

            modelBuilder.Entity<Jrv>()
               .HasOne(j => j.IdCantonNavigation)
               .WithMany(c => c.Jrvs)
               .HasForeignKey(j => j.IdCanton);

            modelBuilder.Entity<Jrv>()
                .HasOne(j => j.IdParroquiaNavigation)
                .WithMany(p => p.Jrvs)
                .HasForeignKey(j => j.IdParroquia);

            modelBuilder.Entity<Jrv>()
                .HasOne(j => j.IdProvinciaNavigation)
                .WithMany(p => p.Jrvs)
                .HasForeignKey(j => j.IdProvincia);

            modelBuilder.Entity<Jrv>()
                .HasOne(j => j.IdRecintoNavigation)
                .WithMany(p => p.Jrvs)
                .HasForeignKey(j => j.IdRecinto);

            modelBuilder.Entity<Jrv>()
                .HasOne(j => j.IdRegionNavigation)
                .WithMany(p => p.Jrvs)
                .HasForeignKey(j => j.IdRegion);

            modelBuilder.Entity<Acta>()
                .HasOne(j => j.IdParroquiaNavigation)
                .WithMany(p => p.Acta)
                .HasForeignKey(j => j.IdParroquia);

        }
    }
}
