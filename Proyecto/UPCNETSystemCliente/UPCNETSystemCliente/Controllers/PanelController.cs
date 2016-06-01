using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Panel;
using UPCNETSystemCliente.UPCNETServiceAlumno;
using UPCNETSystemCliente.UPCNETServiceApoderado;
using UPCNETSystemCliente.UPCNETServiceProfesor;
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

        public ActionResult MantenimientoProfesores()
        {
            UPCNETServiceProfesorClient proxy = new UPCNETServiceProfesorClient();
            _MantenimientoProfesores objMantenimientoProfesor = new _MantenimientoProfesores();
            objMantenimientoProfesor.Procesar(proxy.getProfesor());
            return View(objMantenimientoProfesor);
        }

        public ActionResult MantenimientoApoderado()
        {
            UPCNETServiceApoderadoClient proxy = new UPCNETServiceApoderadoClient();
            _MantenimientoApoderado objMantenimientoApoderado = new _MantenimientoApoderado();
            objMantenimientoApoderado.Procesar(proxy.getApoderado());
            return View(objMantenimientoApoderado);
        }
        public ActionResult MantenimientoUsuarios()
        {
            UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
            _MantenimientoUsuarios objMantenimientoUsuarios = new _MantenimientoUsuarios();
            objMantenimientoUsuarios.Procesar(proxy.getAlumnos());
            return View(objMantenimientoUsuarios);
        }


        public ActionResult AddEditProfesor(string IDProfesor, string Modo)
        {
            _AddEditProfesor objAddEditProfesor = new _AddEditProfesor();
            objAddEditProfesor.Fill(IDProfesor, Modo);
            return View(objAddEditProfesor);
        }


        [HttpPost]
        public ActionResult AddEditProfesor(_AddEditProfesor objViewModel)
        {
            try
            {
                UPCNETServiceProfesor.profesor objProfesor = null;
                UPCNETServiceProfesorClient proxy = new UPCNETServiceProfesorClient();
                if (objViewModel.Modo == "Editar")
                {
                    objProfesor = proxy.getProfesorById(objViewModel.IDProfesor);
                    objProfesor.nombre = objViewModel.Nombre;
                    objProfesor.apellido = objViewModel.Apellido;
                    objProfesor.correo = objViewModel.Correo;
                    objProfesor.direccion = objViewModel.Direccion;
                    objProfesor.dni = objViewModel.DNI;
                    objProfesor.idProfesor = objViewModel.IDProfesor;
                    objProfesor.pass = objViewModel.Password;
                    objProfesor.edad = objViewModel.Edad;
                    objProfesor.sueldo = objViewModel.Sueldo;

                    proxy.editProfesor(objProfesor);
                }
                else
                {
                    objProfesor = new UPCNETServiceProfesor.profesor();


                    objProfesor.nombre = objViewModel.Nombre;
                    objProfesor.apellido = objViewModel.Apellido;
                    objProfesor.correo = objViewModel.Correo;
                    objProfesor.direccion = objViewModel.Direccion;
                    objProfesor.dni = objViewModel.DNI;
                    objProfesor.idProfesor = objViewModel.IDProfesor;
                    objProfesor.pass = objViewModel.Password;
                    objProfesor.edad = objViewModel.Edad;
                    objProfesor.sueldo = objViewModel.Sueldo;
                    objProfesor.edadSpecified = true;
                    objProfesor.sueldoSpecified = true;
                    objProfesor.dniSpecified = true;

                    proxy.setProfesor(objProfesor);
                }

                return RedirectToAction("MantenimientoProfesores", "Panel");



            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
        }



        public ActionResult AddEditUsuario(string IDAlumno,string Modo)
        {
            _AddEditUsuario objAddEditUsuario = new _AddEditUsuario();
            objAddEditUsuario.Fill(IDAlumno,Modo);
            return View(objAddEditUsuario);
        }


        [HttpPost]
        public ActionResult AddEditUsuario(_AddEditUsuario objViewModel)
        {
            try
            {
                UPCNETServiceAlumno.alumno objAlumno = null;
                UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
                if (objViewModel.Modo == "Editar")
                {
                    objAlumno = proxy.getAlumnoById(objViewModel.IDAlumno);
                    objAlumno.nombre = objViewModel.Nombre;
                    objAlumno.apellido = objViewModel.Apellido;
                    objAlumno.correo = objViewModel.Correo;
                    objAlumno.direccion = objViewModel.Direccion;
                    objAlumno.dni = objViewModel.DNI;
                    objAlumno.idAlumno = objViewModel.IDAlumno;
                    objAlumno.pass = objViewModel.Password;
                    objAlumno.edad = objViewModel.Edad;

                    proxy.editAlumno(objAlumno);
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
                    objAlumno.pass = objViewModel.Password;
                    objAlumno.edad = objViewModel.Edad;
                    objAlumno.dniSpecified = true;
                    objAlumno.edadSpecified = true;

                    proxy.setAlumno(objAlumno);
                }

                return RedirectToAction("MantenimientoUsuarios","Panel");

                  
                
            }
            catch(Exception ex)
            {
                return View(objViewModel);
            }
        }
    

    }
}
