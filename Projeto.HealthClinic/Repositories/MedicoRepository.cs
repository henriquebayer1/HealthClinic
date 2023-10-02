using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Medico novoMedico)
        {
            Medico medicoBuscado = ctx.Medico.FirstOrDefault(f => f.IdMedico == id)!;
            
           
            medicoBuscado.CRM = novoMedico.CRM;
            medicoBuscado.IdUsuario = novoMedico.IdUsuario;
            medicoBuscado.IdEspecialidade = novoMedico.IdEspecialidade;
            medicoBuscado.IdClinica = novoMedico.IdClinica;

            ctx.Medico.Update(medicoBuscado);

            ctx.SaveChanges();
        }

        public Medico BuscarPorId(Guid id)
        {

            try
            {
                return ctx.Medico.Select(m => new Medico

                {
                    IdMedico = m.IdMedico,
                    CRM = m.CRM,
                    IdEspecialidade = m.IdEspecialidade,
                    IdUsuario = m.IdUsuario,
                    IdClinica = m.IdClinica

                }




                    ).FirstOrDefault(f => f.IdMedico == id)!;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Cadastrar(Medico medico)
        {
            ctx.Medico.Add(medico);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medicoBuscado = ctx.Medico.FirstOrDefault(f => f.IdMedico == id)!;

            ctx.Medico.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medico.ToList();
        }
    }
}
