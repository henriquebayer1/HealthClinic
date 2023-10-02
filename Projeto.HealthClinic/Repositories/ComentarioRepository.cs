using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;
        public ComentarioRepository()
        {
            ctx = new HealthContext();

        }

        public Comentario BuscarPorId(Guid id)
        {
            Comentario comentarioBuscado = ctx.Comentario.FirstOrDefault(f => f.IdComentario == id)!;

            if (comentarioBuscado != null)
            {
                return comentarioBuscado;
            }
            return null!;
        }

        public void Cadastrar(Comentario comentario)
        {
            ctx.Comentario.Add(comentario);

            ctx.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            Comentario comentarioBuscado = ctx.Comentario.FirstOrDefault(f => f.IdComentario == id)!;

            ctx.Comentario.Remove(comentarioBuscado!);

            ctx.SaveChanges();

        }

        public List<Comentario> ListarTodos()
        {
            return ctx.Comentario.ToList();
        }
    }
}
