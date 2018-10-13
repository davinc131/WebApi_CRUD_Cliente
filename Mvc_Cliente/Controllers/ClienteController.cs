using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Mvc_Cliente.Models;
using System.Net.Http.Formatting;

namespace Mvc_Cliente.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            IEnumerable<MvcClienteModel> clintList;
            HttpResponseMessage response = VariaveisGlobais.WebApiClient.GetAsync("Cliente").Result;
            clintList = response.Content.ReadAsAsync<IEnumerable<MvcClienteModel>>().Result;
            return View(clintList);
        }
    }
}