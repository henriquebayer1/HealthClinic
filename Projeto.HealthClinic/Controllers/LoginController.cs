using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projeto.HealthClinic.Domains;
using Projeto.HealthClinic.Interfaces;
using Projeto.HealthClinic.Repositories;
using Projeto.HealthClinic.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Projeto.HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {

            _usuarioRepository = new UsuarioRepository();

        }

        [HttpPost]

        public IActionResult Login(LoginViewModel usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.Login(usuario.Email, usuario.Senha);

                if (usuario == null)
                {
                    return NotFound("Email ou senha invalidos");

                }

                //Caso encontre o usuario, prossegue para a criacao do token


                // 1 - Definir as informacoes ou (clains) que serao fornecidos no token (PAYLOAD)

                var claims = new[]
                {

                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email,usuarioBuscado.Email!),
                    new Claim(JwtRegisteredClaimNames.Name,usuarioBuscado.Nome!),
                    new Claim(ClaimTypes.Role ,usuarioBuscado.TiposUsuario!.Titulo!)


                };

                // 2 - Definir a chave de acesso ao token

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("CodeFirst-chave-autenticacao-webapi-dev"));

                // 3 - Definir as credenciais do token (HEADER)

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // 4 - Gerar Token

                var token = new JwtSecurityToken
                    (
                    //emissor do token
                    issuer: "webapi.HealthClinic.codeFirst.manha",

                    //DESTINATARIO DO TOKEN
                    audience: "webapi.HealthClinic.codeFirst.manha",

                    //DADOS DEFINIDOS NAS CLAINS(INFORMACOES)
                    claims: claims,

                    //TEMPO DE EXPIRACAO DO TOKEN
                    expires: DateTime.Now.AddMinutes(5),

                    //CREDENCIAIS DO TOKEN
                    signingCredentials: creds

                    );

                // 5 Retornar o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)

                });

            }
            catch (Exception)
            {

                throw;
            }



        }








    }
}
