using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Consulta novaConsulta)
        {
            Consulta consultaBuscada = ctx.Consulta.FirstOrDefault(f => f.IdConsulta == id)!;

            consultaBuscada.DescricaoConsulta = novaConsulta.DescricaoConsulta;
            consultaBuscada.IdClinica = novaConsulta.IdClinica;
            consultaBuscada.IdPaciente = novaConsulta.IdPaciente;
            consultaBuscada.IdMedico = novaConsulta.IdMedico;
            consultaBuscada.IdProntuario = novaConsulta.IdProntuario;

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public Consulta BuscarPorId(Guid id)
        {
            Consulta consultaBuscada = ctx.Consulta.FirstOrDefault(f => f.IdConsulta == id)!;

            return consultaBuscada!;

        }

        public void Cadastrar(Consulta consulta)
        {
            ctx.Consulta.Add(consulta);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta consultaBuscada = ctx.Consulta.FirstOrDefault(f => f.IdConsulta == id)!;

            ctx.Consulta.Remove(consultaBuscada);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarTodos()
        {
            return ctx.Consulta.ToList();
        }
    }
}
