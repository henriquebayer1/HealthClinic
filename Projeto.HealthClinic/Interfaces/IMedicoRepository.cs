using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Atualizar(Guid id, Medico novoMedico);

        void Deletar(Guid id);

        Medico BuscarPorId(Guid id);

        List<Medico> ListarTodos();

    }
}
