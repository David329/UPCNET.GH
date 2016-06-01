using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPCNETSystemCliente.ViewModel.Panel;
using UPCNETSystemCliente.UPCNETServiceAlumno;
using UPCNETSystemCliente.UPCNETServiceApoderado;
using UPCNETSystemCliente.UPCNETServiceProfesor;
using UPCNETSystemCliente.UPCNETServiceCurso;
using UPCNETSystemCliente.UPCNETServiceCursoClase;
using UPCNETSystemCliente.UPCNETServiceCursoAlumno;
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
        public ActionResult AddEditApoderado(string IDApoderado, string Modo)
        {
            _AddEditApoderado objAddEditApoderado = new _AddEditApoderado();
            objAddEditApoderado.Fill(IDApoderado, Modo);
            return View(objAddEditApoderado);
        }
        [HttpPost]
        public ActionResult AddEditApoderado(_AddEditApoderado objViewModel)
        {
            try
            {
                UPCNETServiceApoderado.apoderado objApoderado = null;
                UPCNETServiceApoderadoClient proxy = new UPCNETServiceApoderadoClient();
                if (objViewModel.Modo == "Editar")
                {
                    objApoderado = proxy.getApoderadoById(objViewModel.IDApoderado);
                    objApoderado.nombre = objViewModel.Nombre;
                    objApoderado.apellido = objViewModel.Apellido;
                    objApoderado.correo = objViewModel.Correo;
                    objApoderado.direccion = objViewModel.Direccion;
                    objApoderado.DNI = objViewModel.DNI;
                    objApoderado.IDApoderado = objViewModel.IDApoderado;
                    objApoderado.pass = objViewModel.Password;
                    objApoderado.edad = objViewModel.Edad;
                    objApoderado.condicion = objViewModel.Condicion;

                    proxy.editApoderado(objApoderado);
                }
                else
                {
                    objApoderado = new UPCNETServiceApoderado.apoderado();


                    objApoderado.nombre = objViewModel.Nombre;
                    objApoderado.apellido = objViewModel.Apellido;
                    objApoderado.correo = objViewModel.Correo;
                    objApoderado.direccion = objViewModel.Direccion;
                    objApoderado.DNI = objViewModel.DNI;
                    objApoderado.IDApoderado = objViewModel.IDApoderado;
                    objApoderado.pass = objViewModel.Password;
                    objApoderado.edad = objViewModel.Edad;
                    objApoderado.condicion = objViewModel.Condicion;

                    proxy.setApoderado(objApoderado);
                }

                return RedirectToAction("MantenimientoApoderado", "Panel");



            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
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
        public ActionResult MantenimientoCurso()
        {
            UPCNETServiceCursoClient proxy = new UPCNETServiceCursoClient();
            _MantenimientoCurso objMantenimientoCurso = new _MantenimientoCurso();
            objMantenimientoCurso.CargarDatos(proxy.getCursos());
            return View(objMantenimientoCurso);
        }
        public ActionResult AddEditCurso(string IDCurso, string Modo)
        {
            _AddEditCurso objAddEditCurso = new _AddEditCurso();
            objAddEditCurso.Fill(IDCurso, Modo);
            return View(objAddEditCurso);
        }
        [HttpPost]
        public ActionResult AddEditCurso(_AddEditCurso objViewModel)
        {
            try
            {
                UPCNETServiceCurso.curso objCurso = null;
                UPCNETServiceCursoClient proxy = new UPCNETServiceCursoClient();
                if (objViewModel.Modo == "Editar")
                {
                    objCurso = proxy.getCursoById(objViewModel.IDCurso);
                    objCurso.idCurso = objViewModel.IDCurso;
                    objCurso.nombre = objViewModel.Nombre;
                    objCurso.cicloDeCurso = objViewModel.CicloDeCurso;
                    objCurso.maxInasistencia = objViewModel.MaxInasistencia;
                    objCurso.idProfesor = objViewModel.IDProfesor;

                    proxy.editCurso(objCurso);
                }
                else
                {
                    objCurso = new UPCNETServiceCurso.curso();


                    objCurso.idCurso = objViewModel.IDCurso;
                    objCurso.nombre = objViewModel.Nombre;
                    objCurso.cicloDeCurso = objViewModel.CicloDeCurso;
                    objCurso.maxInasistencia = objViewModel.MaxInasistencia;
                    objCurso.idProfesor = objViewModel.IDProfesor;

                    proxy.setCurso(objCurso);
                }

                return RedirectToAction("MantenimientoCurso", "Panel");



            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
        }
        public ActionResult MantenimientoHorario()
        {
            UPCNETServiceCursoClaseClient proxy = new UPCNETServiceCursoClaseClient();
            _MantenimientoHorario objMantenimientoHorario = new _MantenimientoHorario();
            objMantenimientoHorario.CargarDatos(proxy.getCursoClases());
            return View(objMantenimientoHorario);
        }

        public ActionResult AddEditHorario(string IDHorario, string Modo)
        {
            _AddEditHorario objAddEditHorario = new _AddEditHorario();
            objAddEditHorario.Fill(IDHorario, Modo);
            return View(objAddEditHorario);
        }
        [HttpPost]
        public ActionResult AddEditHorario(_AddEditHorario objViewModel)
        {
            try
            {
                UPCNETServiceCursoClase.cursoClaseReporte objCursoClaseReporte = null;
                UPCNETServiceCursoClaseClient proxy = new UPCNETServiceCursoClaseClient();
                if (objViewModel.Modo == "Editar")
                {
                    objCursoClaseReporte = proxy.getCursoClaseById(objViewModel.IDHorario);

                    UPCNETServiceCursoClase.cursoClase objCursoClase = new UPCNETServiceCursoClase.cursoClase();
                    objCursoClase.idClase = objCursoClaseReporte.iDClase;
                    objCursoClase.idCurso = objCursoClaseReporte.iDCurso;
                    objCursoClase.dia = objCursoClaseReporte.dia;
                    objCursoClase.horaIni = objCursoClaseReporte.horaIni;
                    objCursoClase.horaFin = objCursoClaseReporte.horaFin;

                    proxy.setCursoClase(objCursoClase);
                }
                else
                {
                    UPCNETServiceCursoClase.cursoClase objCursoClase = new UPCNETServiceCursoClase.cursoClase();


                    objCursoClase.idClase = objViewModel.IDHorario;
                    objCursoClase.idCurso = objViewModel.IDCurso;
                    objCursoClase.dia = objViewModel.Dia;
                    objCursoClase.horaIni = objViewModel.HoraIni;
                    objCursoClase.horaFin = objViewModel.HoraFin;

                    proxy.setCursoClase(objCursoClase);
                }

                return RedirectToAction("MantenimientoHorario", "Panel");



            }
            catch (Exception ex)
            {
                return View(objViewModel);
            }
        }

        public ActionResult MantenimientoRelacion()
        {
            UPCNETServiceCursoAlumnoClient proxy = new UPCNETServiceCursoAlumnoClient();
            _MantenimientoRelaciones objMantenimientoRelaciones = new _MantenimientoRelaciones();
            objMantenimientoRelaciones.CargarDatos(proxy.getCursoAlumnos());
            return View(objMantenimientoRelaciones);
        }
    }
}
