using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MRS.Api.ViewModel
{
    public class RegistrarViewModel
    {
        [Required(ErrorMessage = ") campo {0} é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = ") campo {0} é obrigatório")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não são iguais")]
        public string ConfirmacaoSenha { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = ") campo {0} é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = ") campo {0} é obrigatório")]
        public string Senha { get; set; }


    }

}
