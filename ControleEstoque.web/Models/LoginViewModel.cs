using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe a Usuário")]
        [Display (Name ="Usuário: ") ]
        public String Usuario { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]     
        [Display(Name = "Senha: ")]
        [DataType(DataType.Password)]
        public String Senha { get; set; }

        [Display(Name = "Lembrar-me")]
        public bool LembrarMe { get; set; }
    }

}