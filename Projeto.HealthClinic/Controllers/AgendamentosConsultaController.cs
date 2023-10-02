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
    public class AgendamentosConsultaController : ControllerBase
    {
        private readonly IAgendamentosConsultaRepository _agendamentosConsultaRepository;

        public AgendamentosConsultaController()
        {
            _agendamentosConsultaRepository = new AgendamentosConsultaRepository();

        }


        [HttpPost]
        public IActionResult Cadastrar(AgendamentosConsulta agendamento)
        {
            try
            {
                _agendamentosConsultaRepository.Cadastrar(agendamento);

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
                return Ok(_agendamentosConsultaRepository.ListarTodos());

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

                return Ok(_agendamentosConsultaRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, AgendamentosConsulta novoAgendamento)
        {
            try
            {
                _agendamentosConsultaRepository.Atualizar(id, novoAgendamento);


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

                _agendamentosConsultaRepository.Deletar(id);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


    }
}
