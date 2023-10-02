using Microsoft.EntityFrameworkCore;
using Projeto.HealthClinic.Domains;

namespace Projeto.HealthClinic.Contexts
{
    public class HealthContext : DbContext
    {

       public DbSet<AgendamentosConsulta> AgendamentosConsulta { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Comentario> Comentario{ get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        //Define as opcoes de construcao do banco(String Conexao)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE01-S15; Database = Health_Clinic_CodeFirst; User Id = SA; Pwd = Senai@134; TrustServerCertificate = true;");
        }



    }
}
