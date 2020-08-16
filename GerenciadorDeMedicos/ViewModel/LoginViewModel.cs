using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeMedicos.ViewModel
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O E-mail do usuario é obrigatório")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha do usuario é obrigatória")]
        public string Senha { get; set; }
    }
}
