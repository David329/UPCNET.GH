using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using UPCNETSystemCliente.UPCNETServiceCursoClase;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _MantenimientoHorario
    {

        public List<Horario> objListHorario { get; set; }

        public void CargarDatos(UPCNETServiceCursoClase.cursoClaseReporte[] cursoclase)
        {
            objListHorario = new List<Horario>();
            if (cursoclase != null)
            {
                foreach (var item in cursoclase)
                {
                    Horario objCursoClase = new Horario();
                    objCursoClase.IDHorario = item.iDClase;
                    objCursoClase.NombreAlumno = item.alumnoNombre;
                    objCursoClase.ApellidoAlumno = item.alumnoApellido;
                    objCursoClase.NombreDelCurso = item.cursoNombre;
                    objCursoClase.NombreDelProfesor = item.profesorNombre;
                    objCursoClase.ApellidoProfesor = item.profesorApellido;
                    objCursoClase.Dia = item.dia;
                    objCursoClase.HoraInicio = item.horaIni;
                    objCursoClase.HoraFin = item.horaFin;

                    objListHorario.Add(objCursoClase);
                }
            }
        }
        
        public class Horario
        {
            public string IDHorario { get; set; }
            public string NombreAlumno { get; set; }
            public string ApellidoAlumno { get; set; }
            public string NombreDelCurso { get; set; }
            public string NombreDelProfesor { get; set; }
            public string ApellidoProfesor { get; set; }
            public string Dia { get; set; }
            public string HoraInicio { get; set; }
            public string HoraFin { get; set; }
        }
    }
}