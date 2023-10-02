using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IProntuarioRepository
    {
        void Cadastrar(Prontuario prontuario);

        void Atualizar(Guid id, Prontuario novoProntuario);

        void Deletar(Guid id);

        Prontuario BuscarPorId(Guid id);

        List<Prontuario> ListarTodos();

    }
}
