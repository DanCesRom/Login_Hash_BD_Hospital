using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Database;
using System.Data;
using System.Data.SqlTypes;
using System.Net;

namespace CapaNegocio.Acciones
{
    public class AccionesConsulta : AccionesBases
    {
        #region Metodos de Listar / Listados de Tablas
        public List<Anestesiologo> listAnestesiologo()
        {
            return dbLibContext.Anestesiologos.ToList();
        }

        public List<Asistente> listAsistente()
        {
            return dbLibContext.Asistentes.ToList();
        }

        public List<Cirugia> listCirugia()
        {
            return dbLibContext.Cirugias.ToList();
        }

        public List<Cirujano> listCirujano()
        {
            return dbLibContext.Cirujanos.ToList();
        }

        public List<HistorialClinico> listHistorialClinico()
        {
            return dbLibContext.HistorialClinicos.ToList();
        }

        public List<Paciente> listPaciente()
        {
            return dbLibContext.Pacientes.ToList();
        }

        public List<Quirofano> listQuirofano()
        {
            return dbLibContext.Quirofanos.ToList();
        }

        public List<usuario> listUsuario()
        { 
            return dbLibContext.usuarios.ToList();
        }

        #endregion
    }
}
