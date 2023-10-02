using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        void Deletar(Guid id);

        Comentario BuscarPorId(Guid id);

        List<Comentario> ListarTodos();

    }
}
