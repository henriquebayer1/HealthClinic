using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{

    [Table(nameof(Prontuario))]
    public class Prontuario
    {

        [Key]

        public Guid IdProntuario { get; set; } = Guid.NewGuid();


        [Column(TypeName = "VARCHAR(400)")]
        [Required(ErrorMessage = "A descricao do prontuario e obrigatoria!")]

        public string? Descricao { get; set; }


        //Referencia tabela paciente - FK

        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }
    }
}
