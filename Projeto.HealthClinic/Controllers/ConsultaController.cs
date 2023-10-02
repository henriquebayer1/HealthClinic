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
    public class ConsultaController : ControllerBase
    {

        private readonly IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();

        }


        [HttpPost]
        public IActionResult Cadastrar(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);

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
                return Ok(_consultaRepository.ListarTodos());

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

                return Ok(_consultaRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Consulta novaConsulta)
        {
            try
            {
                _consultaRepository.Atualizar(id, novaConsulta);


                return StatusCode(202);
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

                _consultaRepository.Deletar(id);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }









    }
}
