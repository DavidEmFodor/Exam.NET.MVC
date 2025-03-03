using Microsoft.EntityFrameworkCore;

namespace ExamenDavidFodor.Models
{
    public class ExamenDavidFodorContext : DbContext
    {
        public ExamenDavidFodorContext(DbContextOptions<ExamenDavidFodorContext> options)
            : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Competicion> Competiciones { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<CompeticionesEquipos> CompeticionesEquipos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
