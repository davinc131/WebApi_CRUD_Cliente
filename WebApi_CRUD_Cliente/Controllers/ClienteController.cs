using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_CRUD_Cliente.Models;

namespace WebApi_CRUD_Cliente.Controllers
{
    [RoutePrefix("api")]
    public class ClienteController : ApiController
    {
        private static List<ClienteModel> listaClientes = new List<ClienteModel>();

        [AcceptVerbs("POST")]
        [Route("cliente")]
        public string CadastrarCliente(ClienteModel cliente)
        {
            if(cliente.CodigoCliente != null || cliente.CodigoCliente != 0 || cliente.NomeCliente != "" || cliente.EmailCliente != "" || cliente.TelCliente != "" || cliente.CelCliente != "")
            {
                listaClientes.Add(cliente);
                return "Cliente cadastrado com sucesso!";
            }
            else
            {
                return "Preenha os campos necessários!";
            }
        }

        [AcceptVerbs("PUT")]
        [Route("cliente")]
        public string AlterarCliente(ClienteModel cliente)
        {
            listaClientes.Where(n => n.CodigoCliente == cliente.CodigoCliente)
                         .Select(s =>
                         {
                             s.CodigoCliente = cliente.CodigoCliente;
                             s.NomeCliente = cliente.NomeCliente;
                             s.EmailCliente = cliente.EmailCliente;
                             s.TelCliente = cliente.TelCliente;
                             s.CelCliente = cliente.CelCliente;

                             return s;

                         }).ToList();

            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("cliente/{codigo}")]
        public string ExcluirCliente(int codigo)
        {
            ClienteModel cliente = listaClientes.Where(n => n.CodigoCliente == codigo)
                                                .Select(n => n)
                                                .First();

            listaClientes.Remove(cliente);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("cliente/{codigo}")]
        public ClienteModel ConsultarClientePorCodigo(int codigo)
        {
            ClienteModel cliente = listaClientes.Where(n => n.CodigoCliente == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return cliente;
        }

        [AcceptVerbs("GET")]
        [Route("cliente")]
        public List<ClienteModel> ListarClientes()
        {
            return listaClientes;
        }
    }
}
