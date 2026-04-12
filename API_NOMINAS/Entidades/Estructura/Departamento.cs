using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_NOMINAS.Entidades.Estructura
{
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string DepartamentName { get; set; } = string.Empty;
        public List<Puesto> Puestos { get; set; }
    }
}
