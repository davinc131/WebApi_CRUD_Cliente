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

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new MvcClienteModel());
            }
            else
            {
                HttpResponseMessage response = VariaveisGlobais.WebApiClient.GetAsync("Cliente/"+id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MvcClienteModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(MvcClienteModel clienteModel)
        {
            if (clienteModel.ClienteID == 0)
            {
                HttpResponseMessage response = VariaveisGlobais.WebApiClient.PostAsJsonAsync("Cliente", clienteModel).Result;
                TempData["SuccessMessage"] = "Salvo com sucesso!";
            }
            else
            {
                HttpResponseMessage response = VariaveisGlobais.WebApiClient.PutAsJsonAsync("Cliente/"+clienteModel.ClienteID, clienteModel).Result;
                TempData["SuccessMessage"] = "Alterado com sucesso!";
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = VariaveisGlobais.WebApiClient.DeleteAsync("Cliente/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deletado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}