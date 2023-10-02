using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Paciente novoPaciente)
        {
            Paciente pacienteBuscado = ctx.Paciente.FirstOrDefault(f => f.IdPaciente == id)!;

            pacienteBuscado.CPF = novoPaciente.CPF;
            pacienteBuscado.IdUsuario = novoPaciente.IdUsuario;

            ctx.Paciente.Update(pacienteBuscado);

            ctx.SaveChanges();
        }

        public Paciente BuscarPorId(Guid id)
        {
           Paciente pacienteBuscado = ctx.Paciente.FirstOrDefault(f => f.IdPaciente == id)!;

            return pacienteBuscado!;

        }

        public void Cadastrar(Paciente paciente)
        {
            ctx.Paciente.Add(paciente);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.FirstOrDefault(f => f.IdPaciente == id)!;

            ctx.Paciente.Remove(pacienteBuscado);

            ctx.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return ctx.Paciente.ToList();
        }
    }
}
