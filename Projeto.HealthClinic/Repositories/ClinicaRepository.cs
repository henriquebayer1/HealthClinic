using Projeto.HealthClinic.Contexts;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;

namespace Projeto.HealthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Clinica novaClinica)
        {
            Clinica clinicaBuscada = ctx.Clinica.FirstOrDefault(f => f.IdClinica == id)!;

            clinicaBuscada.Endereco = novaClinica.Endereco;
            clinicaBuscada.CNPJ = novaClinica.CNPJ;
            clinicaBuscada.NomeFantasia = novaClinica.NomeFantasia;
            clinicaBuscada.RazaoSocial = novaClinica.RazaoSocial;
            clinicaBuscada.HorarioDeFuncionamento = novaClinica.HorarioDeFuncionamento;

            ctx.Update(clinicaBuscada);

            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(Guid id)
        {
            Clinica clinicaBuscada = ctx.Clinica.FirstOrDefault(f => f.IdClinica == id)!;

            if (clinicaBuscada! != null)
            {
                return clinicaBuscada!;

            }
            return null!;
           
        }

        public void Cadastrar(Clinica clinica)
        {
            ctx.Clinica.Add(clinica);

            ctx.SaveChanges();  
        }

        public void Deletar(Guid id)
        {
            Clinica clinicaBuscada = ctx.Clinica.FirstOrDefault(f => f.IdClinica == id)!;

            ctx.Remove(clinicaBuscada);

            ctx.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return ctx.Clinica.ToList();
        }
    }
}
