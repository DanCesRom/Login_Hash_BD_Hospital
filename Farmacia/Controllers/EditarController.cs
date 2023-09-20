using CapaNegocio.Acciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farmacia.Controllers
{
    public class EditarController : Controller
    {
        // GET: Editar
        public AccionesEditar editar = new AccionesEditar();

        #region Controllador Vistas Editar Tablas
        public ActionResult Editar_Anestesiologo()
        {
            return View();
        }

        public ActionResult Editar_Asistente()
        {
            return View();
        }

        public ActionResult Editar_Cirugia()
        {
            return View();
        }


        public ActionResult Editar_Cirujano()
        {
            return View();
        }

        public ActionResult Editar_HistorialClinico()
        {
            return View();
        }

        public ActionResult Editar_Paciente()
        {
            return View();
        }

        public ActionResult Editar_Quirofano()
        {
            return View();
        }


        #endregion

        #region HttpPost Update Tablas

        [HttpPost]
        public ActionResult UpdateAnestesiologo(int id_anestesiologo, string cedula_txt, string nombre_txt, string especialidad_txt, char status_txt)
        {
            editar.UpdateAnestesiologo(id_anestesiologo, cedula_txt, nombre_txt, especialidad_txt, status_txt);
            TempData["AnestesiologoUpdateMessage"] = $"El Anestesiologo con el ID: {id_anestesiologo} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Anestesiologo", "Consultar");

        }

        [HttpPost]
        public ActionResult UpdateAsistente(int id_asistente, string cedula_txt, string nombre_txt, string especialidad_txt, char status_txt)
        {
            editar.UpdateAsistente(id_asistente, cedula_txt, nombre_txt, especialidad_txt, status_txt);
            TempData["AsistenteUpdateMessage"] = $"El Asistente con el ID: {id_asistente} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Asistente", "Consultar");

        }

        [HttpPost]
        public ActionResult UpdateCirugia(int idcirugia_txt, DateTime horaoperacion_txt, string cirugiarealizada_txt, int historial_txt, int idquirofano_txt, int idcirujano_txt, int idasistente_txt, int idanestesiologo_txt, char status_txt)
        {
            editar.UpdateCirugia(idcirugia_txt, horaoperacion_txt, cirugiarealizada_txt, historial_txt, idquirofano_txt, idcirujano_txt, idasistente_txt, idanestesiologo_txt, status_txt);
            TempData["CirugiaUpdateMessage"] = $"La Cirugia con el ID: {idcirugia_txt} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Cirugia", "Consultar");

        }

        [HttpPost]
        public ActionResult UpdateCirujano(int idcirujano_txt, string cedula_txt, string nombre_txt, string especialidad_txt, char status_txt)
        {
            editar.UpdateCirujano(idcirujano_txt, cedula_txt, nombre_txt, especialidad_txt, status_txt);
            TempData["CirujanoUpdateMessage"] = $"El Cirujano con el ID: {idcirujano_txt} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Cirujano", "Consultar");
        }

        [HttpPost]
        public ActionResult UpdateHistorialClinico(int idhistorialclinico_txt, string motivoconsulta_txt, string historialenfermedadactual_txt, string antecedentespatologicosfamiliares_txt, string antecedentespatologicospersonales_txt, string habitostoxicos_txt, string diagnostico_txt, string tratamiento_txt, string seguimiento_txt, char status_txt)
        {
            editar.UpdateHistorialClinico(idhistorialclinico_txt, motivoconsulta_txt, historialenfermedadactual_txt, antecedentespatologicosfamiliares_txt, antecedentespatologicospersonales_txt, habitostoxicos_txt, diagnostico_txt, tratamiento_txt, seguimiento_txt, status_txt);
            TempData["HistorialClinicoUpdateMessage"] = $"El Historial Clinico con el ID: {idhistorialclinico_txt} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_HistorialClinico", "Consultar");
        }

        [HttpPost]
        public ActionResult UpdatePaciente(int idpaciente_txt, string cedula_txt, string nombre_txt, DateTime fechanacimiento_txt, char genero_txt, string direccion_txt, string telefono_txt, string ocupacion_txt, string civil_txt, string escolaridad_txt, string procedencia_txt, char status_txt)
        {
            editar.UpdatePaciente(idpaciente_txt, cedula_txt, nombre_txt, fechanacimiento_txt, genero_txt, direccion_txt, telefono_txt, ocupacion_txt, civil_txt, escolaridad_txt, procedencia_txt, status_txt);
            TempData["PacienteUpdateMessage"] = $"El Paciente con el ID: {idpaciente_txt} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Paciente", "Consultar");

        }

        [HttpPost]
        public ActionResult UpdateQuirofano(int idquirofano_txt, string nombre_txt, char status_txt)
        {
            editar.UpdateQuirofano(idquirofano_txt, nombre_txt, status_txt);
            TempData["QuirofanoUpdateMessage"] = $"El Quirofano con el ID: {idquirofano_txt} ha sido modificado exitosamente";
            return RedirectToAction("Consultar_Quirofano", "Consultar");

        }

        #endregion

    }
}