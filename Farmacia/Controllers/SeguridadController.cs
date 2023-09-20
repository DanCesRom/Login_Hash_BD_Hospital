using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CapaDatos.Database;
using CapaNegocio.Acciones;
using Farmacia.Models;
using static System.Collections.Specialized.BitVector32;

namespace Farmacia.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
        public AccionesConsulta confirmar = new AccionesConsulta();

        #region Controlador-Vista
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logoutadm()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        #endregion

        #region HttpPost Conexion Iniciar Sesion

        [HttpPost]
        public ActionResult LoginUsuario(string user, string Password)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(Password);

                byte[] hashBytes = sHA256.ComputeHash(inputBytes);

                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                var users = confirmar.listUsuario().ToList();

                if (users.Exists(x => x.usuario1.ToLower() == user.ToLower() && x.clave == hashString))
                {
                    var autuser = users.FirstOrDefault(x => x.usuario1.ToLower() == user.ToLower() && x.clave == hashString);

                    Session["NombreUsuario"] = user;
                    Session["NivelAccesso"] = "1";
                    return RedirectToAction("Eleccion", "Home");
                }

                else if (user =="Admin" && Password == "modify")
                {

                    Session["NombreUsuario"] = user;
                    Session["NivelAccesso"] = "0";
                    return RedirectToAction("Add_Usuario", "AddInfo");
                }

                else
                {
                    ViewBag.ErrorMessage = "Usuario o Contraseña incorrectos.";
                    return View("Login");
                }

            }

        }

        #endregion

    }
}