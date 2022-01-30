using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class NominaDB:DbContext
    {
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Decimo_Tercero> Decimo_Terceros { get; set; }
        public DbSet<Decimo_Cuarto> Decimo_Cuartos { get; set; }
        public DbSet<Fondo_reserva> Fondo_reservas { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }
        public DbSet<Roles> Roles { get; set; }


        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "server=DESKTOP-FAR92HR; initial catalog=SGA1; trusted_connection=true;"
                );
        }
        public NominaDB() : base()
        {

        }
        public NominaDB(DbContextOptions<NominaDB> opciones)
            : base(opciones)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion uno a muchos, personal y decimo tercero
          
            modelBuilder.Entity<Decimo_Tercero>()
                .HasOne(tercero => tercero.Personal)
                .WithMany(personal => personal.Decimos_Terceros)
                .HasForeignKey(tercero => tercero.PersonalId);

            //Relaciones uno a muchos, personal y decimo cuarto
            modelBuilder.Entity<Decimo_Cuarto>()
                .HasOne(cuarto => cuarto.Personal)
                .WithMany(personal => personal.Decimos_Cuartos)
                .HasForeignKey(cuarto => cuarto.PersonalId);

            //Relaciones uno a muchos, personal y fondos de reserva
            modelBuilder.Entity<Fondo_reserva>()
               .HasOne(reserva => reserva.Personal)
               .WithMany(personal => personal.Fondo_reserva)
               .HasForeignKey(reserva => reserva.PersonalId);

            //Relaciones uno a muchos, personal y vacaciones
            modelBuilder.Entity<Vacaciones>()
               .HasOne(vacaciones => vacaciones.Personal)
               .WithMany(personal => personal.Vacaciones)
               .HasForeignKey(vacaciones => vacaciones.PersonalId);

            //Relaciones uno a muchos, personal y roles
            modelBuilder.Entity<Roles>()
               .HasOne(roles => roles.Personal)
               .WithMany(personal => personal.Roles)
               .HasForeignKey(roles => roles.PersonalId);

            //Relacion uno a uno 
            modelBuilder.Entity<Departamento>()
                .HasOne(dep => dep.Personal)
                .WithOne(personal => personal.Departamento)
                .HasForeignKey<Departamento>(dep => dep.PersonalId);
        }
    }
}
