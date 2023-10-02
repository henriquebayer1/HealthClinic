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
    public class ProntuarioController : ControllerBase
    {
        private IProntuarioRepository _prontuarioRepository;

        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Prontuario prontuario)
        {

            try
            {

                _prontuarioRepository.Cadastrar(prontuario);

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
                return Ok(_prontuarioRepository.ListarTodos()); 

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

                return Ok(_prontuarioRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        
        
        
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Prontuario novoProntuario)
        {
            try
            {
                _prontuarioRepository.Atualizar(id, novoProntuario);

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
                _prontuarioRepository.Deletar(id);  

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        

      

    }
}
