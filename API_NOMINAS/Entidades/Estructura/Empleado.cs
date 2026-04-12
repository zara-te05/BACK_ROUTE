using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_NOMINAS.Entidades.Estructura
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string NameEmpleado { get; set; } = string.Empty;
        public int idPuesto { get; set; }
        public Puesto Puesto { get; set; }

    }
}