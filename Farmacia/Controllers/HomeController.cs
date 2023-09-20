using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaModelo;
using CapaNegocio.Acciones;
using Microsoft.Ajax.Utilities;

namespace Farmacia.Controllers
{
    public class HomeController : Controller
    {
        public AccionesConsulta consultar = new AccionesConsulta();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Eleccion()
        {
            return View();
        }

        public ActionResult Auditorio()
        {
            ViewBag.Message = "Pagina de Auditorio.";
            return View();
        }

    }
}