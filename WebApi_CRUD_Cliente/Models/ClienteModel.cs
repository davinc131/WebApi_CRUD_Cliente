using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_CRUD_Cliente.Models
{
    public class ClienteModel
    {
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelCliente { get; set; }
        public string CelCliente { get; set; }

        public ClienteModel()
        {

        }

        public ClienteModel(int codigo, string nome, string email, string tel, string cel)
        {
            CodigoCliente = codigo;
            NomeCliente = nome;
            EmailCliente = email;
            TelCliente = tel;
            CelCliente = cel;
        }
    }
}