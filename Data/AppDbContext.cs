using GestionAcademica.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionAcademica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Docente> Docentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Docente>().ToTable("Docente");
            modelBuilder.Entity<Curso>().ToTable("Curso");

            modelBuilder.Entity<Curso>()
                .HasOne<Docente>() 
                .WithMany()         
                .HasForeignKey(c => c.IdDocente); 
        }
    }
}

