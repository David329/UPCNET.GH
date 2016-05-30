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

        public ActionResult AddEditUsuario(string IDAlumno)
        {
            _AddEditUsuario objAddEditUsuario = new _AddEditUsuario();
            objAddEditUsuario.Fill(IDAlumno);
            return View(objAddEditUsuario);
        }

/*
        [HttpPost]
        public ActionResult AddEditUsuario(_AddEditUsuario objViewModel)
        {
            try
            {
                UPCNETServiceAlumno.alumno objAlumno = null;
                UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
                if(objViewModel.IDAlumno !="" && objViewModel.IDAlumno!=null)
                {
                    objAlumno = proxy.getAlumnoById(objViewModel.IDAlumno);
                }
                else
                {
                    objAlumno = new UPCNETServiceAlumno.alumno();
                    objAlumno.nombre = objViewModel.Nombre;
                    objAlumno.apellido = objViewModel.Apellido;
                    objAlumno.correo = objViewModel.Correo;
                    objAlumno.direccion = objViewModel.Direccion;
                    objAlumno.dni = objViewModel.DNI;
                    objAlumno.idAlumno = objViewModel.IDAlumno;

                  
                }
            }
            catch(Exception ex)
            {
                return View(objViewModel);
            }
        }
      /*
        [HttpPost]
        public ActionResult AddEditDistrito(AddEditDistritoViewModel objViewModel)
        {
            try
            {
                Distrito objDistrito = null;
                ONPEEntities context = new ONPEEntities();

                if (objViewModel.DistritoId.HasValue)
                    objDistrito = context.Distrito.FirstOrDefault(
                                 x => x.DistritoId == objViewModel.DistritoId);
                else
                {
                    objDistrito = new Distrito();
                    context.Distrito.Add(objDistrito);
                }

                objDistrito.Descripcion = objViewModel.Descripcion;
                objDistrito.Estado = "ACT";

                context.SaveChanges();
                return RedirectToAction("LstDistrito");
            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
        } */

    }
}
