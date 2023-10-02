using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HealthContext ctx;

        public EspecialidadeRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Especialidade novaEspecialidade)
        {
            Especialidade especialidadeBuscada = ctx.Especialidade.FirstOrDefault(f => f.IdEspecialidade == id)!;

            especialidadeBuscada.Nome = novaEspecialidade.Nome;
            especialidadeBuscada.Descricao = novaEspecialidade.Descricao;
           
            ctx.Especialidade.Update(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public Especialidade BuscarPorId(Guid id)
        {
            Especialidade especialidadeBuscada = ctx.Especialidade.FirstOrDefault(f => f.IdEspecialidade == id)!;

            return especialidadeBuscada!;

        }

        public void Cadastrar(Especialidade especialidade)
        {
            ctx.Especialidade.Add(especialidade);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Especialidade especialidadeBuscada = ctx.Especialidade.FirstOrDefault(f => f.IdEspecialidade == id)!;

            ctx.Especialidade.Remove(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Especialidade> ListarTodos()
        {
            return ctx.Especialidade.ToList();
        }
    }
}
