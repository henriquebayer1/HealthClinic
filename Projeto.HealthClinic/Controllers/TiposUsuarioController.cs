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
    public class TiposUsuarioController : ControllerBase
    {

        public ITiposUsuarioRepository? _TiposUsuarioRepository;


        public TiposUsuarioController()
        {
            _TiposUsuarioRepository = new TiposUsuarioRepository();
        }


        [HttpPost]

        public IActionResult Post(TiposUsuario tiposUsuario)
        {

            try
            {

                _TiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201);
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

                _TiposUsuarioRepository.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]

        public IActionResult ListarPorId(Guid id)
        {

            try
            {

                TiposUsuario tiposUsuarioBuscado = _TiposUsuarioRepository.BuscarPorId(id);

                return Ok(tiposUsuarioBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpPut]
        public IActionResult AtualizarTitulo(Guid id, TiposUsuario novoTipoUsuario)
        {
            try
            {

                _TiposUsuarioRepository.Atualizar(id, novoTipoUsuario);

                return StatusCode(201);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }




        }

        [HttpGet("Listar Todos")]

        public IActionResult ListarTodos()
        {

            try
            {
                return Ok(_TiposUsuarioRepository.Listar());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }



    }
}
