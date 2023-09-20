using CapaDatos.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace CapaNegocio.Acciones
{
    public class AccionesGuardar : AccionesBases
    {

        //Guardar los Datos en las tablas de la Base de Datos

        #region Guardar Anestesiologo
        public string registrarAnestesiologo(string ceduladelmedico, string nombremedico, string especialidad, char status)
        {
            string resultado = "";
            try
            {
                Anestesiologo anestesio;

                anestesio = new Anestesiologo
                {
                    Cedula_Anestesiologo = ceduladelmedico,
                    NombreMedico = nombremedico,
                    Especialidad = especialidad,
                    Status = status,

                };

                dbLibContext.Anestesiologos.InsertOnSubmit(anestesio);
                dbLibContext.SubmitChanges();

            resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Asistente
        public string registrarAsistente(string ceduladelmedico, string nombremedico, string especialidad, char status)
        {
            string resultado = "";
            try
            {
                Asistente asist;

                asist = new Asistente
                {
                    Cedula_Asistente = ceduladelmedico,
                    NombreMedico = nombremedico,
                    Especialidad = especialidad,
                    Status = status,

                };

                dbLibContext.Asistentes.InsertOnSubmit(asist);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Cirugia
        public string registrarCirugia(DateTime horadeoperacion, string cirugiarealizada, int idhistorialclinico, int idquirofano, int idcirujano, int idasistente, int idanestesiologo, char statuscirugia)
        {
            string resultado = "";
            try
            {
                Cirugia cirugia;

                cirugia = new Cirugia
                {
                    HoraOperacion = horadeoperacion,
                    CirugiaRealizada = cirugiarealizada,
                    HistorialClinicoID = idhistorialclinico,
                    QuirofanoID = idquirofano,
                    CirujanoID = idcirujano,
                    AsistenteID = idasistente,
                    AnestesiologoID = idanestesiologo,
                    Status = statuscirugia,

                };

                dbLibContext.Cirugias.InsertOnSubmit(cirugia);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Cirujano
        public string registrarCirujano(string ceduladelmedico, string nombremedico, string especialidad, char status)
        {
            string resultado = "";
            try
            {
                Cirujano ciruj;

                ciruj = new Cirujano
                {
                    Cedula_Cirujano = ceduladelmedico,
                    NombreMedico = nombremedico,
                    Especialidad = especialidad,
                    Status = status,

                };

                dbLibContext.Cirujanos.InsertOnSubmit(ciruj);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Historial Clinico
        public string registrarHistorialClinico(string motivoconsulta, string historialenfermedadactual,string antecedentespatologicosfamiliares, string antecedentespatologicospersonales, string habitostoxicos, string diagnostico, string tratamiento, string seguimiento,  char status)
        {
            string resultado = "";
            try
            {
                HistorialClinico historiacli;

                historiacli = new HistorialClinico
                {
                    MotivoConsulta = motivoconsulta,
                    HistoriaEnfermedadActual = historialenfermedadactual,
                    AntecedentesPatologicosFamiliares = antecedentespatologicosfamiliares,
                    AntecedentesPatologicosPersonales = antecedentespatologicospersonales,
                    HabitosToxicos = habitostoxicos,
                    Diagnostico = diagnostico,
                    Tratamiento = tratamiento,
                    Seguimiento = seguimiento,
                    Status = status,

                };

                dbLibContext.HistorialClinicos.InsertOnSubmit(historiacli);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Historial Paciente
        public string registrarPaciente(string cedulapaciente, int idhistorialclinico, string nombrepaciente, DateTime fechadenacimiento_txt, char genero, string direccion, string telefono, string ocupacion, string estadocivil, string escolaridad, string procedencia, char status)
        {
            string resultado = "";
            try
            {
                Paciente paciente;

                paciente = new Paciente
                {
                    Cedula = cedulapaciente,
                    HistorialClinicoID = idhistorialclinico,
                    Nombre = nombrepaciente,
                    FechaNacimiento = fechadenacimiento_txt,
                    Genero = genero,
                    Direccion = direccion,
                    Telefono = telefono,
                    Ocupacion = ocupacion,
                    EstadoCivil = estadocivil,
                    Escolaridad = escolaridad,
                    Procedencia = procedencia,
                    Status = status,

                };

                dbLibContext.Pacientes.InsertOnSubmit(paciente);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }

        #endregion

        #region Guardar Historial Quirofano
        public string registrarQuirofano(string nombrequirofano, char status)
        {
            string resultado = "";
            try
            {
                Quirofano quirofano;

                quirofano = new Quirofano
                {
                    NombreQuirofano = nombrequirofano,
                    Status = status,
                };

                dbLibContext.Quirofanos.InsertOnSubmit(quirofano);
                dbLibContext.SubmitChanges();

                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Guardar Usuario
        public string registrarUsuario(string nombre, string clave)
        {
            string resultado = "";
            try
            {
                using (SHA256 sHA256 = SHA256.Create())
                { 
                    byte[] inputBytes = Encoding.UTF8.GetBytes(clave);

                    byte[] hashBytes = sHA256.ComputeHash(inputBytes);

                    string hashString = BitConverter.ToString(hashBytes).Replace("-","").ToLower();

                    usuario usuario;

                    usuario = new usuario
                    {
                        usuario1 = nombre,
                        clave = hashString,
                    };

                    dbLibContext.usuarios.InsertOnSubmit(usuario);
                    dbLibContext.SubmitChanges();


                }




                resultado = "Registro completado";

            }
            catch (Exception)
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

    }
}
