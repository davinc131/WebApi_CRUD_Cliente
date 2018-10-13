using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Cliente.Models
{
    public class MvcClienteModel
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}