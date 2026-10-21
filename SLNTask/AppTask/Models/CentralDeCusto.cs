
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTask.Models
{
    [Table("CentralDeCusto")]
    public class CentralDeCusto
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe o nome da central.")]
        [StringLength(250)]
        public string NomeCentral { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal? ValorMetaAnual { get; set; } = 0;
    }
}
