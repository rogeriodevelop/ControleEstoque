using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.web.Models
{
    public class LoginViewModel
    {
        [Display (Name ="Usuário: ") ]
        public String Usuario { get; set; }

        [Display(Name = "Senha: ")]
        public String Senha { get; set; }

        [Display(Name = "Lembrar-me")]
        public bool LembrarMe { get; set; }
    }

}