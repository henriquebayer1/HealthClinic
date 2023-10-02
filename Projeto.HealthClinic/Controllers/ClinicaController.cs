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
    public class ClinicaController : ControllerBase
    {

        private readonly IClinicaRepository _clinicaRepository;


        public ClinicaController()
        {
                _clinicaRepository = new ClinicaRepository();

        }



        [HttpPost]
        public IActionResult Cadastrar(Clinica clinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);

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
                return Ok(_clinicaRepository.ListarTodos());

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
                return Ok(_clinicaRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }



        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, Clinica novaClinica)
        {

            try
            {
                _clinicaRepository.Atualizar(id, novaClinica);

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
                _clinicaRepository.Deletar(id);

                return Ok();
            }
            catch (Exception e)
            {


                return BadRequest(e.Message);

            }


        }



    }
}
