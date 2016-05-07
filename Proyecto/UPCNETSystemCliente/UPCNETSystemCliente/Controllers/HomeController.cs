using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Login;
using UPCNETSystemCliente.UPCNETServiceAlumno;
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

            UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
            UPCNETServiceAlumno.alumno[] lista = proxy.getAlumnos();

            bool existe_cuenta = false;
            string nombre = "";
            string email = "";
            foreach (var item in lista)
            {
                if (objLoginViewModel.UsuarioCodigo == item.idAlumno && objLoginViewModel.UsuarioPassword == item.pass) {
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
                return RedirectToAction("Administrador","Panel");
            }
            else {
                ModelState.AddModelError("", ValidationString.CampoUsuarioIncorrecto);
                ModelState.AddModelError("", ValidationString.CampoPasswordIncorrecto);
            }

            return View();
        }

    }
}
