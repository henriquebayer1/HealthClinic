using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{
    [Table(nameof(Especialidade))]
    public class Especialidade
    {

        [Key]

        public Guid IdEspecialidade { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome da especialidade e obrigatorio!")]

        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A descricao da especialidade e obrigatoria!")]

        public string? Descricao { get; set; }







    }
}
