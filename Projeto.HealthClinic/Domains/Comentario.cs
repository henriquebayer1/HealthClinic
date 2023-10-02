using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; }  = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required]

        public string? DescricaoComentario { get; set; }


        //Referencia tabela usuario - FK

        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }

        //Referencia tabela consulta - FK

        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta? consulta { get; set; }



    }
}
