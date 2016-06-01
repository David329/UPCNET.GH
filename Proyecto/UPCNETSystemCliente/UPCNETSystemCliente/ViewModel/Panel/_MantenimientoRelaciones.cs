using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using UPCNETSystemCliente.UPCNETServiceCursoAlumno;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _MantenimientoRelaciones
    {

        public List<Relacion> objListRelacion { get; set;}

        public _MantenimientoRelaciones() { }

        public void CargarDatos(UPCNETServiceCursoAlumno.cursoAlumnoReporte[] objeto)
        {
            objListRelacion = new List<Relacion>();
            if(objListRelacion != null)
            {
                foreach (var item in objeto)
                {

                    Relacion objRelacion = new Relacion();

                    objRelacion.IDAlumno = item.idAlumno;
                    objRelacion.IDCurso = item.idCurso;
                    objRelacion.NombreAlumno = item.alumnoNombre;
                    objRelacion.ApellidoAlumno = item.alumnoApellido;
                    objRelacion.CursoNombre = item.cursoNombre;
                    objRelacion.ProfesorNombre = item.profesorNombre;
                    objRelacion.ProfesorApellido = item.profesorApellido;

                    objListRelacion.Add(objRelacion);
                }
            }
        }

        public class Relacion
        {
            public string IDAlumno { get; set; }
            public string IDCurso { get; set; }
            public string NombreAlumno { get; set; }
            public string ApellidoAlumno { get; set; }
            public string CursoNombre { get; set; }
            public string ProfesorNombre { get; set; }
            public string ProfesorApellido { get; set; }
        }
    }
}