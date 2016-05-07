using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Login;

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

        [HttpPost]
        public ActionResult Login(_LoginViewModel objLoginViewModel)
        {
            return View();
        }

        public ActionResult Principal_Administrador() {
            return View();
        }

    }
}
