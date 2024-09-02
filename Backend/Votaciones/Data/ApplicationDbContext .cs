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
        public DbSet<Canton> Cantones { get; set; }
        public DbSet<Jrv> Jrvs { get; set; }
        public DbSet<Parroquium> Parroquias { get; set; }
        public DbSet<Provincium> Provincias { get; set; }
        public DbSet<Recinto> Recintos { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<JrvNovedade> JrvNovedades { get; set; }
        public DbSet<MembershipUser> MembershipUsers { get; set; }
    }
}
