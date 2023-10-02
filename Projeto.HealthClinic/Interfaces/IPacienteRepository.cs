using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Atualizar(Guid id, Paciente novoPaciente);

        void Deletar(Guid id);

        Paciente BuscarPorId(Guid id);

        List<Paciente> ListarTodos();

    }
}
