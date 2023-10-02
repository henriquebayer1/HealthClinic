using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IClinicaRepository
    {

        void Cadastrar(Clinica clinica);

        void Atualizar(Guid id, Clinica novaClinica);

        void Deletar(Guid id);

        Clinica BuscarPorId(Guid id);

        List<Clinica> ListarTodos();




    }
}
