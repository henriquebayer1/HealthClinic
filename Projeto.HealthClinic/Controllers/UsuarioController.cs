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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }


        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

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
                return Ok(_usuarioRepository.BuscarPorId(id));


            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        [HttpGet]
        public IActionResult Listar()
        {

            try
            {
                return Ok(_usuarioRepository.Listar());


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
                _usuarioRepository.Deletar(id);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }

        [HttpPut("Atualizar")]
        public IActionResult Atualizar(Usuario usuarioAtualizado, Guid id)
        {
            try
            {
                _usuarioRepository.Atualizar(usuarioAtualizado, id);


                return Ok("Usuario Atualizado");

            }
            catch (Exception e)
            {

                return NotFound("Email ou senha invalidos");
            }

        }



    }
}
