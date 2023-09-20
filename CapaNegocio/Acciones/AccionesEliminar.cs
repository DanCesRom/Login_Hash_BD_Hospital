using CapaDatos.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Acciones
{
    public class AccionesEliminar : AccionesBases
    {
        #region Eliminar Anestesiologo
        public string DelAnestesiologo(int id)
        {
            string resultado = "";
            Anestesiologo anestiolo = dbLibContext.Anestesiologos.FirstOrDefault(x => x.AnestesiologoID == id);

            if (anestiolo != null)
            {
                dbLibContext.Anestesiologos.DeleteOnSubmit(anestiolo);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Eliminar Asistente
        public string DelAsistente(int id)
        {
            string resultado = "";
            Asistente asistente = dbLibContext.Asistentes.FirstOrDefault(x => x.AsistenteID== id);

            if (asistente != null)
            {
                dbLibContext.Asistentes.DeleteOnSubmit(asistente);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Eliminar Cirugia
        public string DelCirugia(int id)
        {
            string resultado = "";
            Cirugia cirugia= dbLibContext.Cirugias.FirstOrDefault(x => x.CirugiaID== id);

            if (cirugia != null)
            {
                dbLibContext.Cirugias.DeleteOnSubmit(cirugia);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Eliminar Cirujano
        public string DelCirujano(int id)
        {
            string resultado = "";
            Cirujano cirujano = dbLibContext.Cirujanos.FirstOrDefault(x => x.CirujanoID== id);

            if (cirujano != null)
            {
                dbLibContext.Cirujanos.DeleteOnSubmit(cirujano);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Eliminar Historial Clinico
        public string DelHistorialClinico(int id)
        {
            string resultado = "";
            HistorialClinico historial = dbLibContext.HistorialClinicos.FirstOrDefault(x => x.HistorialClinicoID== id);

            if (historial != null)
            {
                dbLibContext.HistorialClinicos.DeleteOnSubmit(historial);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }

            return resultado;
        }
        #endregion

        #region Eliminar Paciente
        public string DelPaciente(int id)
        {
            string resultado = "";
            Paciente paciente= dbLibContext.Pacientes.FirstOrDefault(x => x.PacienteID== id);

            if (paciente != null)
            {
                dbLibContext.Pacientes.DeleteOnSubmit(paciente);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

            }
            else
            {
                resultado = "Hubo un fallo";
            }


            return resultado;
        }
        #endregion

        #region Eliminar Quirofano
        public string DelQuirofano(int id)
        {
            string resultado = "";
            Quirofano quirofano = dbLibContext.Quirofanos.FirstOrDefault(x => x.QuirofanoID== id);

            if (quirofano != null)
            {
                dbLibContext.Quirofanos.DeleteOnSubmit(quirofano);
                dbLibContext.SubmitChanges();

                resultado = "Eliminar Completado";

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
