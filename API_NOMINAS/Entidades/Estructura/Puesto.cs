using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_NOMINAS.Entidades.Estructura
{
    public class Puesto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double SalarioBase { get; set; }
        [Required]
        public int DepartamentoId { get; set; }
        [Required]
        public Departamento Departamento { get; set; }
    }
}
