using CapaNegocio.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace Farmacia.Controllers
{
    public class EliminarController : Controller
    {
        public AccionesEliminar eliminar = new AccionesEliminar();

        #region HttpPost de Eliminar

        [HttpPost]
        public ActionResult DelAnestesiologo(int id = 0)
        {
            eliminar.DelAnestesiologo(id);
            TempData["AnestesiologoDeleteMessage"] = $"El Anestesiologo con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Anestesiologo", "Consultar");
        }

        [HttpPost]
        public ActionResult DelAsistente(int id)
        {
            eliminar.DelAsistente(id);
            TempData["AsistenteDeleteMessage"] = $"El Asistente con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Asistente", "Consultar");
        }

        [HttpPost]
        public ActionResult DelCirugia(int id)
        {
            eliminar.DelCirugia(id);
            TempData["CirugiaDeleteMessage"] = $"La cirugia con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Cirugia", "Consultar");
        }

        [HttpPost]
        public ActionResult DelCirujano(int id)
        {
            eliminar.DelCirujano(id);
            TempData["CirujanoDeleteMessage"] = $"El Cirujano con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Cirujano", "Consultar");
        }

        [HttpPost]
        public ActionResult DelHistorialClinico(int id)
        {
            eliminar.DelHistorialClinico(id);
            TempData["HistorialClinicoDeleteMessage"] = $"El Historial Clinico con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_HistorialClinico", "Consultar");
        }

        [HttpPost]
        public ActionResult DelPaciente(int id)
        {
            eliminar.DelPaciente(id);
            TempData["PacienteDeleteMessage"] = $"El Paciente con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Paciente", "Consultar");
        }

        [HttpPost]
        public ActionResult DelQuirofano(int id)
        {
            eliminar.DelQuirofano(id);
            TempData["QuirofanoDeleteMessage"] = $"El Quirofano con el ID: {id} ha sido eliminada exitosamente";
            return RedirectToAction("Consultar_Quirofano", "Consultar");
        }
        #endregion
    }
}