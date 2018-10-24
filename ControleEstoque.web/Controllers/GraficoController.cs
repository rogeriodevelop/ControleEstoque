using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.web.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Graficos
        public ActionResult PerdaMes()
        {
            return View();
        }
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}