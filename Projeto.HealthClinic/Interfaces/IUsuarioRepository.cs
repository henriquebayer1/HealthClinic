using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IUsuarioRepository
    {

        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario Login(string email, string senha);

        void Deletar(Guid id);

        List<Usuario> Listar();

        string Atualizar(Usuario usuario, Guid id);

    }
}
