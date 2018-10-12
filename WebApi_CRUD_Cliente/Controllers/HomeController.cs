using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;
using WebApi_CRUD_Cliente.Models;
using System.Windows.Forms;

namespace WebApi_CRUD_Cliente.Controllers
{
    public class HomeController : Controller
    {
        private const string Endereco = "http://localhost:56482/api/cliente";

        #region Chamadas de Views

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Title = "Cadastro";

            return View();
        }

        public ActionResult Listagem()
        {
            ViewBag.Title = "Listagem";

            return View();
        }

        public ActionResult Alteracao()
        {
            ViewBag.Title = "Alteração";

            return View();
        }

        #endregion

        [HttpPost]
        public JsonResult Cadastrar(string Dado)
        {
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public async JsonResult CadastrarCliente(int codigo, string nome, string email, string telefone, string celular)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        await client.PostAsync(Endereco, new ObjectContent<ClienteModel>(new ClienteModel()
        //        {
        //            CodigoCliente = codigo,
        //            NomeCliente = nome,
        //            EmailCliente = email,
        //            TelCliente = telefone,
        //            CelCliente = celular
        //        }, new JsonMediaTypeFormatter())).ContinueWith(t =>
        //        {
        //            return t.Status;
        //        });
        //    }
        //    return null;
        //}

    }
}
