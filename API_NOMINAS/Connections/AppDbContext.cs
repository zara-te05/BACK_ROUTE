using API_NOMINAS.Entidades.Estructura;
using API_NOMINAS.Entidades.Operaciones;
using Microsoft.EntityFrameworkCore;

namespace API_NOMINAS.Connections
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Puesto> Puesto { get; set; } 
        public DbSet<Nomina> Nomina { get; set; }

    }
}
