using CursoEFCore8.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CursoEFCore8
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Genero>().HasKey(x => x.Id);
            modelBuilder.Entity<Genero>().Property(x => x.Nombre).HasMaxLength(150);

            modelBuilder.Entity<Actor>().Property(x => x.Nombre).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(x => x.FechaNacimiento).HasColumnType("date");
            modelBuilder.Entity<Actor>().Property(x => x.Fortuna).HasPrecision(18,2);

        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();

    }
}
