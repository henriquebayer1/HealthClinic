using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Atualizar(Guid id, Consulta novoConsulta);

        void Deletar(Guid id);

        Consulta BuscarPorId(Guid id);

        List<Consulta> ListarTodos();

    }
}
