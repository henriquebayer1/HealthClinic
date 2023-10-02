using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;
using Projeto.HealthClinic.Repositories;

namespace Projeto.HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacienteController : ControllerBase
    {


        private IPacienteRepository _pacienteRepository;

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {

            try
            {

                _pacienteRepository.Cadastrar(paciente);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_pacienteRepository.ListarTodos());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }



        }


        [HttpGet("{id}")]
        public IActionResult ListById(Guid id)
        {

            try
            {

                return Ok(_pacienteRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }



        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Paciente novoPaciente)
        {
            try
            {
                _pacienteRepository.Atualizar(id, novoPaciente);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _pacienteRepository.Deletar(id);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }











    }
}
