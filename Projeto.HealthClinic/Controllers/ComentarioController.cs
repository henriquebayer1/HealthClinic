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
    public class ComentarioController : ControllerBase
    {


        private readonly IComentarioRepository _ComentarioRepository;
        public ComentarioController()
        {
            _ComentarioRepository = new ComentarioRepository();

        }

        [HttpGet("Listar Todos")]
        public IActionResult ListarTodos()
        {

            try
            {
                return Ok(_ComentarioRepository.ListarTodos());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        [HttpPost]
        public IActionResult Cadastar(Comentario comentario)
        {

            try
            {
                _ComentarioRepository.Cadastrar(comentario);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id)
        {

            try
            {

                _ComentarioRepository.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {

            try
            {


                return Ok(_ComentarioRepository.BuscarPorId(id));


            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

    }
}
