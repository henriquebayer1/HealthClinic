using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {



        [Key]

        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A CRM e obrigatoria!")]

        public string? CRM { get; set; }

        //Referencia tabela clinica - FK

        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? clinica { get; set; }

        //Referencia tabela especialidade - FK

        public Guid IdEspecialidade { get; set; }

        [ForeignKey(nameof(IdEspecialidade))]
        public Especialidade? especialidade { get; set; }

        //Referencia tabela usuario - FK

        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }
    }
}
