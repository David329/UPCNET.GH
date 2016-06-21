using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Login;
using UPCNETSystemCliente.UPCNETServiceAlumno;
using UPCNETSystemCliente.UPCNETServiceAdministrador;
using UPCNETSystemCliente.Globalization;
using UPCNETSystemCliente.Helpers;

namespace UPCNETSystemCliente.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Login() {
            _LoginViewModel objLoginViewModel = new _LoginViewModel();
            return View(objLoginViewModel);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(_LoginViewModel objLoginViewModel)
        {

            if (!ModelState.IsValid) {
                return View(objLoginViewModel);
            }
            
            //Adminstrador
            UPCNETServiceAdministradorClient proxy = new UPCNETServiceAdministradorClient();
            UPCNETServiceAdministrador.administrador[] lista = proxy.getAdministrador();

            bool existe_cuenta = false;
            string nombre = "";
            string email = "";
            string id = "";
            foreach (var item in lista)
            {
                if (objLoginViewModel.UsuarioCodigo == item.IDAdministrador && objLoginViewModel.UsuarioPassword == item.pass) {
                    existe_cuenta = true;
                    nombre = item.nombre;
                    email = item.correo;
                    break;
                }
            }

            if (existe_cuenta == true)
            {
                Session.Set(SessionKey.Nombre, nombre);
                Session.Set(SessionKey.Email, email);
                return RedirectToAction("Administrador", "Panel");
            }
            else {
                ModelState.AddModelError("", ValidationString.CampoUsuarioIncorrecto);
                ModelState.AddModelError("", ValidationString.CampoPasswordIncorrecto);
            }


            //Alumno
            UPCNETServiceAlumnoClient proxyAl = new UPCNETServiceAlumnoClient();
            UPCNETServiceAlumno.alumno[] listaAl = proxyAl.getAlumnos();

            foreach (var item in listaAl)
            {
                if (objLoginViewModel.UsuarioCodigo == item.idAlumno && objLoginViewModel.UsuarioPassword == item.pass)
                {
                    existe_cuenta = true;
                    nombre = item.nombre;
                    email = item.correo;
                    id = item.idAlumno;
                    break;
                }
            }

            if (existe_cuenta == true)
            {
                Session.Set(SessionKey.Nombre, nombre);
                Session.Set(SessionKey.Email, email);
                Session["idAlumno"] = id;
                return RedirectToAction("Alumno", "Alumno");
            }
            else
            {
                ModelState.AddModelError("", ValidationString.CampoUsuarioIncorrecto);
                ModelState.AddModelError("", ValidationString.CampoPasswordIncorrecto);
            }

            return View();
        }

    }
}
