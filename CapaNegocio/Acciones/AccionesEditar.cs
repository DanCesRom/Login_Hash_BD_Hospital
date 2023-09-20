using CapaDatos.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Acciones
{
    public class AccionesEditar : AccionesBases
    {
        //Modificar los Datos en las tablas de la Base de Datos

        #region Editar Anestesiologo
        public string UpdateAnestesiologo(int id, string dni, string nombre, string especialidad, char status)
        {
            string resultado = "";
            Anestesiologo anestesiologo = dbLibContext.Anestesiologos.FirstOrDefault(x => x.AnestesiologoID == id);

            if (anestesiologo != null)
            {
                anestesiologo.AnestesiologoID = id;
                anestesiologo.Cedula_Anestesiologo = dni;
                anestesiologo.NombreMedico = nombre;
                anestesiologo.Especialidad = especialidad;
                anestesiologo.Status = status;

                dbLibContext.Anestesiologos.GetModifiedMembers(anestesiologo);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Asistente
        public string UpdateAsistente(int id, string dni, string nombre, string especialidad, char status)
        {
            string resultado = "";
            Asistente asistente = dbLibContext.Asistentes.FirstOrDefault(x => x.AsistenteID == id);

            if (asistente != null)
            {
                asistente.AsistenteID = id;
                asistente.Cedula_Asistente = dni;
                asistente.NombreMedico = nombre;
                asistente.Especialidad = especialidad;
                asistente.Status = status;

                dbLibContext.Asistentes.GetModifiedMembers(asistente);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Cirugia
        public string UpdateCirugia(int idcirugia, DateTime horaoperacion, string cirugiarealizada, int historial, int idquirofano, int idcirujano, int idasistente, int idanestesiologo, char status)
        {
            string resultado = "";
            Cirugia cirugia= dbLibContext.Cirugias.FirstOrDefault(x => x.CirugiaID== idcirugia);

            if (cirugia != null)
            {
                cirugia.CirugiaID = idcirugia;
                cirugia.HoraOperacion = horaoperacion;
                cirugia.CirugiaRealizada = cirugiarealizada;
                cirugia.HistorialClinicoID  = historial;
                cirugia.QuirofanoID = idquirofano;
                cirugia.CirujanoID = idcirujano;
                cirugia.AsistenteID = idasistente;
                cirugia.AnestesiologoID = idanestesiologo;
                cirugia.Status = status;

                dbLibContext.Cirugias.GetModifiedMembers(cirugia);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Cirujano
        public string UpdateCirujano(int id, string dni, string nombre, string especialidad, char status)
        {
            string resultado = "";
            Cirujano cirujano= dbLibContext.Cirujanos.FirstOrDefault(x => x.CirujanoID== id);

            if (cirujano != null)
            {
                cirujano.CirujanoID = id;
                cirujano.Cedula_Cirujano = dni;
                cirujano.NombreMedico = nombre;
                cirujano.Especialidad = especialidad;
                cirujano.Status = status;

                dbLibContext.Cirujanos.GetModifiedMembers(cirujano);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Historial Clinico
        public string UpdateHistorialClinico(int idhistorialclinico, string motivoconsulta, string historialenfermedadactual, string antecedentespatologicosfamiliares, string antecedentespatologicospersonales, string habitostoxicos, string diagnostico, string tratamiento, string seguimiento, char status)
        {
            string resultado = "";
            HistorialClinico historial= dbLibContext.HistorialClinicos.FirstOrDefault(x => x.HistorialClinicoID== idhistorialclinico);

            if (historial!= null)
            {
                historial.HistorialClinicoID = idhistorialclinico;
                historial.MotivoConsulta = motivoconsulta;
                historial.HistoriaEnfermedadActual = historialenfermedadactual;
                historial.AntecedentesPatologicosFamiliares = antecedentespatologicosfamiliares;
                historial.AntecedentesPatologicosPersonales = antecedentespatologicospersonales;
                historial.HabitosToxicos = habitostoxicos;
                historial.Diagnostico = diagnostico;
                historial.Tratamiento = tratamiento;
                historial.Seguimiento = seguimiento;
                historial.Status = status;

                dbLibContext.HistorialClinicos.GetModifiedMembers(historial);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Historial Clinico
        public string UpdatePaciente(int idpaciente, string cedula, string nombre, DateTime fechanacimiento, char genero, string direccion, string telefono, string ocupacion, string civil, string escolaridad, string procedencia, char status)
        {
            string resultado = "";
            Paciente paciente = dbLibContext.Pacientes.FirstOrDefault(x => x.PacienteID== idpaciente);

            if (paciente != null)
            {
                paciente.PacienteID = idpaciente;
                paciente.Cedula = cedula;
                paciente.Nombre = nombre;
                paciente.FechaNacimiento = fechanacimiento;
                paciente.Genero = genero;
                paciente.Direccion = direccion;
                paciente.Telefono = telefono;
                paciente.Ocupacion = ocupacion;
                paciente.EstadoCivil = civil;
                paciente.Escolaridad = escolaridad;
                paciente.Procedencia = procedencia;
                paciente.Status = status;

                dbLibContext.Pacientes.GetModifiedMembers(paciente);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Editar Anestesiologo
        public string UpdateQuirofano(int idquirofano, string nombre, char status)
        {
            string resultado = "";
            Quirofano quirofano= dbLibContext.Quirofanos.FirstOrDefault(x => x.QuirofanoID== idquirofano);

            if (quirofano != null)
            {
                quirofano.QuirofanoID = idquirofano;
                quirofano.NombreQuirofano = nombre;
                quirofano.Status = status;

                dbLibContext.Quirofanos.GetModifiedMembers(quirofano);
                dbLibContext.SubmitChanges();

                resultado = "Modificacion Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

    }
}
