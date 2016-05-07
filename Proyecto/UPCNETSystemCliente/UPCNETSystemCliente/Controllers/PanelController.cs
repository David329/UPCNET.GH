using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Panel;
using UPCNETSystemCliente.UPCNETServiceAlumno;
using UPCNETSystemCliente.Globalization;
using UPCNETSystemCliente.Helpers;

namespace UPCNETSystemCliente.Controllers
{
    public class PanelController : BaseController
    {

        public ActionResult Administrador()
        {

            return RedirectToAction("MantenimientoUsuarios");
        }

        public ActionResult MantenimientoUsuarios()
        {
            UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
            _MantenimientoUsuarios objMantenimientoUsuarios = new _MantenimientoUsuarios();
            objMantenimientoUsuarios.Procesar(proxy.getAlumnos());
            return View(objMantenimientoUsuarios);
        }

    }
}
