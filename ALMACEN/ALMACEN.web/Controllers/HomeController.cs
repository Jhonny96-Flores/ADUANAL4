using Almacen.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALMACEN.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var serviciosBL = new ServiciosBL();
            var listaServicios = serviciosBL.ObtenerServiciosActivos();

            ViewBag.adminWebsiteUrl = ConfigurationManager.AppSettings["adminWebsiteUrl"];
            return View(listaServicios);
        }
    }
}