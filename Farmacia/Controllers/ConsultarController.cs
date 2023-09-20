using CapaDatos.Database;
using CapaNegocio.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farmacia.Controllers
{
    public class ConsultarController : Controller
    {
        public AccionesConsulta consultar = new AccionesConsulta();
        // GET: Consultar
        #region  Vistas de Mostrar de Consultas 
        public ActionResult Consultar_Anestesiologo()
        {
            List<Anestesiologo> anestesiologo = consultar.listAnestesiologo();
            return View(anestesiologo);

        }

        public ActionResult Consultar_Asistente()
        {
            List<Asistente> asistente = consultar.listAsistente();
            return View(asistente);

        }

        public ActionResult Consultar_Cirugia()
        {
            List<Cirugia> cirugia = consultar.listCirugia();
            return View(cirugia);

        }

        public ActionResult Consultar_Cirujano()
        {
            List<Cirujano> cirujano = consultar.listCirujano();
            return View(cirujano);
        }

        public ActionResult Consultar_HistorialClinico()
        {
            List<HistorialClinico> historialclinico = consultar.listHistorialClinico();
            return View(historialclinico);
        }

        public ActionResult Consultar_Paciente()
        { 
            List<Paciente> paciente = consultar.listPaciente();
            return View(paciente);
        }

        public ActionResult Consultar_Quirofano()
        { 
            List<Quirofano> quirofano = consultar.listQuirofano();
            return View(quirofano);
        }

        #endregion

    }
}