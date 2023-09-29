using Microsoft.EntityFrameworkCore;
using ProyectoOlimpiadas.Data.Models;

namespace ProyectoOlimpiadas.Data
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<DatosMedicos> DatosMedicos { get; set; }
        public DbSet<Enfermero> Enfermero { get; set; }
        public DbSet<Llamadas> Llamadas { get; set; }
        public DbSet<ObraSocial> ObraSocial { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Telefono> Telefono { get; set; }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se declaran la llave primarias ye el nombre de las tablas
            modelBuilder.Entity<Area>().HasKey(a => a.id); modelBuilder.Entity<Area>().ToTable("Areas");
            modelBuilder.Entity<DatosMedicos>().HasKey(a => a.id); modelBuilder.Entity<DatosMedicos>().ToTable("DatosMedicos");
            modelBuilder.Entity<Enfermero>().HasKey(a => a.id); modelBuilder.Entity<Enfermero>().ToTable("Enfermero");
            modelBuilder.Entity<Llamadas>().HasKey(a => a.id); modelBuilder.Entity<Llamadas>().ToTable("Llamadas");
            modelBuilder.Entity<ObraSocial>().HasKey(a => a.id); modelBuilder.Entity<ObraSocial>().ToTable("ObraSocial");
            modelBuilder.Entity<Paciente>().HasKey(a => a.id); modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<Telefono>().HasKey(a => a.id); modelBuilder.Entity<Telefono>().ToTable("Telefono");
        }
    }
}
