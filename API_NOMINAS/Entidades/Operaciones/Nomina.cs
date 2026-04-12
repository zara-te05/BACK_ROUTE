using API_NOMINAS.Entidades.Estructura;
using System.ComponentModel.DataAnnotations;

namespace API_NOMINAS.Entidades.Operaciones
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

        public DateTime Fecha { get; set; }

        public double SalarioBase { get; set; }
        public double Bonos { get; set; }
        public double Deducciones { get; set; }

        public double Total { get; set; }
    }
}
