using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto.HealthClinic.Domains
{
    [Index(nameof(Email), IsUnique = true)]
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome e obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email e obrigatorio!")]
        public string? Email { get; set; }


        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "A senha e obrigatoria!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 a 60 caracteres")]
        public string? Senha { get; set; }

        //Referencia tabela tipoUsuario - FK

        [Required(ErrorMessage = "O tipo de usuario e obrigatorio!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        
        public TiposUsuario? TiposUsuario { get; set; }



    }
}
