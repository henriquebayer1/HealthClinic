using System.ComponentModel.DataAnnotations;

namespace Projeto.HealthClinic.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "o email e obrigatorio!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "a senha e obrigatoria!")]
        public string? Senha { get; set; }

    }
}
