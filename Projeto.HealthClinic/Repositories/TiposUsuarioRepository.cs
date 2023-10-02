using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {


        private readonly HealthContext ctx;

        public TiposUsuarioRepository()
        {
            ctx = new HealthContext();
        }


        public void Atualizar(Guid id, TiposUsuario novoTipoUsuario)
        {
            TiposUsuario usuarioBuscado = ctx.TiposUsuario.FirstOrDefault(f => f.IdTipoUsuario == id)!;

            usuarioBuscado.Titulo = novoTipoUsuario.Titulo;

            ctx.TiposUsuario.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            TiposUsuario tiposUsuarioBuscado = ctx.TiposUsuario.FirstOrDefault(f => f.IdTipoUsuario == id)!;

            if (tiposUsuarioBuscado != null)
            {
                return tiposUsuarioBuscado;
            }
            return null!;

        }

        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            ctx.TiposUsuario.Add(tiposUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario UsuarioBuscado = ctx.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id)!;

            ctx.TiposUsuario.Remove(UsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {

            return ctx.TiposUsuario.ToList();

        }





    }
}
