using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IAgendamentosConsultaRepository
    {

        void Cadastrar(AgendamentosConsulta agendamento);

        void Atualizar(Guid id, AgendamentosConsulta novoAgendamento);

        void Deletar(Guid id);

        AgendamentosConsulta BuscarPorId(Guid id);

        List<AgendamentosConsulta> ListarTodos();

      
    }
}
