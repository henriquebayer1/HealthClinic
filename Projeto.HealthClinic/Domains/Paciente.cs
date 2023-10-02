using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {

        [Key]

        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(11)")]
        //COLOCAR MINIMUN LEGHT
        [Required(ErrorMessage = "O CPF e obrigatorio!")]

        public string? CPF { get; set; }


        //Referencia tabela usuario - FK

        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }

    }
}
