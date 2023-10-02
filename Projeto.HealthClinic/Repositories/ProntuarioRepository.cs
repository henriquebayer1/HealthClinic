using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class ProntuarioRepository : IProntuarioRepository
    {

        private readonly HealthContext ctx;

        public ProntuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Prontuario novoProntuario)
        {
           Prontuario prontuarioBuscado  = ctx.Prontuario.FirstOrDefault(f => f.IdProntuario == id)!;

            prontuarioBuscado.Descricao = novoProntuario.Descricao;
            prontuarioBuscado.IdPaciente = novoProntuario.IdPaciente;

            ctx.Prontuario.Update(prontuarioBuscado);

            ctx.SaveChanges();
        }

        public Prontuario BuscarPorId(Guid id)
        {
            Prontuario prontuarioBuscado = ctx.Prontuario.FirstOrDefault(f => f.IdProntuario == id)!;

            return prontuarioBuscado!;

        }

        public void Cadastrar(Prontuario prontuario)
        {
            ctx.Prontuario.Add(prontuario);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Prontuario prontuarioBuscado = ctx.Prontuario.FirstOrDefault(f => f.IdProntuario == id)!;

            ctx.Prontuario.Remove(prontuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Prontuario> ListarTodos()
        {
            return ctx.Prontuario.ToList();
        }
    }
}
