
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe a descrição.")]
        [StringLength(250)]
        public string Descricao { get; set; } = string.Empty;

        public bool? Ativo { get; set; }
    }
}
