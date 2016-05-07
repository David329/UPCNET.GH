using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.UPCNETSystemWebService;

namespace UPCNETSystemCliente.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            UPCNETServiceClient proxy = new UPCNETServiceClient();
            UPCNETSystemWebService.alumno[] Ian = proxy.Enviar_Alumnos();
            return View();
        }

    }
}
