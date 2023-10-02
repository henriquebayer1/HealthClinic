using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.HealthClinic.Domains
{

    [Table(nameof(AgendamentosConsulta))]
    public class AgendamentosConsulta
    {

        [Key]
        public Guid IdAgendamentoConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data da consulta e obrigatoria!")]
        public DateTime DataConsulta { get; set; }

        [Column(TypeName = "TIME(7)")]
        [Required(ErrorMessage = "O horario da consulta e obrigatoria!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan HorarioConsulta { get; set; }



        //Referencia tabela Paciente - FK

        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }


        //Referencia tabela medico - FK

        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }



    }
}
