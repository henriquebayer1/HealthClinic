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
    public class EspecialidadeController : ControllerBase
    {

        private IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Especialidade especialidade)
        {

            try
            {

                _especialidadeRepository.Cadastrar(especialidade);

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
                return Ok(_especialidadeRepository.ListarTodos());

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

                return Ok(_especialidadeRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }



        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Especialidade novaEspecialidade)
        {
            try
            {
                _especialidadeRepository.Atualizar(id, novaEspecialidade);

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
                _especialidadeRepository.Deletar(id);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


    }
}
