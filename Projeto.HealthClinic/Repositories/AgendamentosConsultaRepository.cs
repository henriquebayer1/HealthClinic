using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class AgendamentosConsultaRepository : IAgendamentosConsultaRepository
    {
        private readonly HealthContext ctx;

        public AgendamentosConsultaRepository()
        {
            ctx = new HealthContext(); 

        }


        public void Atualizar(Guid id, AgendamentosConsulta novoAgendamento)
        {

            AgendamentosConsulta agendamentoConsultaBuscado = ctx.AgendamentosConsulta.Find(id)!;

            if (agendamentoConsultaBuscado != null)
            {

                agendamentoConsultaBuscado.DataConsulta = novoAgendamento.DataConsulta;
                agendamentoConsultaBuscado.HorarioConsulta = novoAgendamento.HorarioConsulta;
                agendamentoConsultaBuscado.IdMedico = novoAgendamento.IdMedico;
                agendamentoConsultaBuscado.IdPaciente = novoAgendamento.IdPaciente;



            }

            ctx.AgendamentosConsulta.Update(agendamentoConsultaBuscado!);

            ctx.SaveChanges();


        }

        public AgendamentosConsulta BuscarPorId(Guid id)
        {
            
          return  ctx.AgendamentosConsulta.Select(a => new AgendamentosConsulta
            {
                IdAgendamentoConsulta = a.IdAgendamentoConsulta,
                IdMedico = a.IdMedico,
                IdPaciente = a.IdPaciente,
                DataConsulta = a.DataConsulta,
                HorarioConsulta = a.HorarioConsulta


            }).FirstOrDefault(f => f.IdAgendamentoConsulta == id)!;


        }

        public void Cadastrar(AgendamentosConsulta agendamento)
        {
            ctx.AgendamentosConsulta.Add(agendamento);

            ctx.SaveChanges();
            
        }

        public void Deletar(Guid id)
        {
            AgendamentosConsulta agendamentoBuscado = ctx.AgendamentosConsulta.FirstOrDefault(f => f.IdAgendamentoConsulta == id)!;


            ctx.AgendamentosConsulta.Remove(agendamentoBuscado);

            ctx.SaveChanges();


        }

        public List<AgendamentosConsulta> ListarTodos()
        {
            return ctx.AgendamentosConsulta.ToList();

        }
    }
}
