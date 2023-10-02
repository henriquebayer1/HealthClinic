using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{

    [Table(nameof(Consulta))]
    public class Consulta
    {


        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A descricao da consulta e obrigatoria!")]

        public string? DescricaoConsulta { get; set; }

        //Referencia tabela Paciente - FK

        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }

        //Referencia tabela medico - FK

        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }

        //Referencia tabela clinica - FK

        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? clinica { get; set; }

        //Referencia tabela Prontuario - FK

        public Guid IdProntuario { get; set; }

        [ForeignKey(nameof(IdProntuario))]
        public Prontuario? prontuario { get; set; }



    }
}
