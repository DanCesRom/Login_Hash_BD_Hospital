using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocio.Acciones;
using Microsoft.Win32;

namespace Farmacia.Controllers
{
    public class AddInfoController : Controller
    {
        // GET: EmpleadosAdd

        #region Controlador de Vistas Guardar
        public AccionesGuardar guardar = new AccionesGuardar();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add_Anestesiologo()
        {
            return View();
        }

        public ActionResult Add_Asistente()
        {
            return View();
        }

        public ActionResult Add_Cirugia()
        {
            return View();
        }

        public ActionResult Add_Cirujano()
        {
            return View();
        }

        public ActionResult Add_HistorialClinico()
        {
            return View();
        }

        public ActionResult Add_Paciente()
        {
            return View();
        }

        public ActionResult Add_Quirofano()
        {
            return View();
        }

        public ActionResult Add_Usuario()
        {
            return View();
        }

        #endregion

        #region HttpPost Registrar

        #region HttpPost Registrar a Tabla Anestesiologo
        [HttpPost]
        public ActionResult registrarAnestesiologo(string ceduladelmedico_txt, string nombredelmedico_txt = "", string especialidaddelmedico_txt = "", char statusdelmedico_txt = 'A')
        {
            string resultado = guardar.registrarAnestesiologo(ceduladelmedico_txt, nombredelmedico_txt, especialidaddelmedico_txt, statusdelmedico_txt);

            if (resultado == "Registro completado") { TempData["AnestesiologoRegisterMessage"] = $"El Quirofano: {nombredelmedico_txt} ha sido agregado exitosamente"; }
            else { TempData["AnestesiologoRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Anestesiologo", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Asistente
        [HttpPost]
        public ActionResult registrarAsistente(string ceduladelmedico_txt, string nombredelmedico_txt = "", string especialidaddelmedico_txt = "", char statusdelmedico_txt = 'A')
        {
            string resultado = guardar.registrarAsistente(ceduladelmedico_txt, nombredelmedico_txt, especialidaddelmedico_txt, statusdelmedico_txt);

            if (resultado == "Registro completado") { TempData["AsistenteRegisterMessage"] = $"El Asistente: {nombredelmedico_txt} ha sido agregado exitosamente"; }
            else { TempData["AsistenteRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Asistente", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Cirugia
        [HttpPost]
        public ActionResult registrarCirugia(DateTime horadeoperacion_txt = new DateTime(), string cirugiarealizada_txt = "", int idhistorialclinico_txt = 0, int idquirofano_txt = 0, int idcirujano_txt = 0, int idasistente_txt = 0, int idanestesiologo_txt = 0, char statuscirugia_txt = 'A')
        {
            string resultado = guardar.registrarCirugia(horadeoperacion_txt, cirugiarealizada_txt, idhistorialclinico_txt, idquirofano_txt, idcirujano_txt, idasistente_txt, idanestesiologo_txt, statuscirugia_txt);

            if (resultado == "Registro completado") { TempData["CirugiaRegisterMessage"] = $"La Cirugia con ha sido agregada exitosamente"; }
            else { TempData["CirugiaRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Cirugia", "Consultar");
        }

        #endregion

        #region HttpPost Registrar a Tabla Cirujano
        [HttpPost]
        public ActionResult registrarCirujano(string ceduladelmedico_txt = "", string nombredelmedico_txt = "", string especialidaddelmedico_txt = "", char statusdelmedico_txt = 'A')
        {
            string resultado = guardar.registrarCirujano(ceduladelmedico_txt, nombredelmedico_txt, especialidaddelmedico_txt, statusdelmedico_txt);

            if (resultado == "Registro completado") { TempData["CirujanoRegisterMessage"] = $"El Cirujano: {nombredelmedico_txt} ha sido agregado exitosamente"; }
            else { TempData["CirujanoRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Cirujano", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Historial Clinico
        [HttpPost]
        public ActionResult registrarHistorialClinico( string motivoconsulta_txt = "", string historialenfermedadactual_txt = "", string antecedentespatologicosfamiliares_txt = "", string antecedentespatologicospersonales_txt = "", string habitostoxicos_txt = "", string diagnostico_txt = "", string tratamiento_txt = "", string seguimiento_txt = "", char statusdelmedico_txt = 'A')
        {
            string resultado = guardar.registrarHistorialClinico(motivoconsulta_txt, historialenfermedadactual_txt, antecedentespatologicosfamiliares_txt, antecedentespatologicospersonales_txt, habitostoxicos_txt, diagnostico_txt, tratamiento_txt, seguimiento_txt, statusdelmedico_txt);

            if (resultado == "Registro completado") { TempData["HistorialRegisterMessage"] = $"El historial Clinico ha sido agregado exitosamente"; }
            else { TempData["HistorialRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_HistorialClinico", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Paciente
        [HttpPost]
        public ActionResult registrarPaciente(string cedulapaciente_txt, int idhistorialclinico_txt, string nombrepaciente_txt, DateTime fechadenacimiento_txt, char genero_txt, string direccion_txt, string telefono_txt, string ocupacion_txt, string estadocivil_txt, string escolaridad_txt, string procedencia_txt, char status_txt)
        {
            string resultado = guardar.registrarPaciente(cedulapaciente_txt, idhistorialclinico_txt, nombrepaciente_txt, fechadenacimiento_txt, genero_txt, direccion_txt, telefono_txt, ocupacion_txt, estadocivil_txt, escolaridad_txt, procedencia_txt, status_txt);

            if (resultado == "Registro completado") { TempData["PacienteRegisterMessage"] = $"El Paciente con la Cedula: {cedulapaciente_txt}  ha sido agregado exitosamente"; }
            else { TempData["PacienteRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Paciente", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Quirofano
        [HttpPost]
        public ActionResult registrarQuirofano(string nombrequirofano_txt, char status_txt)
        {
            string resultado = guardar.registrarQuirofano(nombrequirofano_txt, status_txt);

            if (resultado == "Registro completado") { TempData["QuirofanoRegisterMessage"] = $"El Quirfano con el nombre: {nombrequirofano_txt}  ha sido agregado exitosamente"; }
            else { TempData["QuirofanoRegisterErrorMessage"] = $"{resultado}."; }

            return RedirectToAction("Consultar_Quirofano", "Consultar");
        }
        #endregion

        #region HttpPost Registrar a Tabla Usuario
        [HttpPost]
        public ActionResult registrarUsuario(string nombreusuario_txt, string claveusuario_txt)
        {
            string resultado = guardar.registrarUsuario(nombreusuario_txt, claveusuario_txt);

            return RedirectToAction("Login", "Seguridad");
        }
        #endregion

        #endregion
    }
}
