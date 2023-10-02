using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Atualizar(Guid id, Especialidade especialidade);

        void Deletar(Guid id);

        Especialidade BuscarPorId(Guid id);

        List<Especialidade> ListarTodos();

    }
}
