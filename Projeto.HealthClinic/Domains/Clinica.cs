using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{

    [Index(nameof(CNPJ), IsUnique = true)]
    [Table(nameof(Clinica))]
    public class Clinica
    {

        [Key]

        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "CNPJ e obrigatorio!")]
        [StringLength(14)]
        public string? CNPJ { get; set; }


        [Column(TypeName = "VARCHAR(150)")]
        [Required(ErrorMessage = "Endereco e obrigatorio!")]

        public string? Endereco { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia e obrigatorio!")]

        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O horario de funcionamento e obrigatorio!")]

        public string? HorarioDeFuncionamento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A razao social e obrigatoria!")]

        public string? RazaoSocial { get; set; }



    }
}
