using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Cliente.Models
{
    public class MvcClienteModel
    {
        public int ClienteID { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}