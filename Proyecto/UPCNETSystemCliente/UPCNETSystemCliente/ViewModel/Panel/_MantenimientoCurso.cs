using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using UPCNETSystemCliente.UPCNETServiceCurso;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _MantenimientoCurso
    {
        public List<Curso> objListCurso { get; set; }

        public void CargarDatos(UPCNETServiceCurso.curso[] curso)
        {
            objListCurso = new List<Curso>();
            foreach (var item in curso)
            {
                Curso objCurso = new Curso();
                objCurso.IDCurso = item.IDCurso;
                objCurso.CicloDeCurso = item.CicloDeCurso;
                objCurso.MaxInasistencia = item.MaxInasistencia;
                objCurso.IDProfesor = item.IDProfesor;
                objCurso.Nombre = item.Nombre;

                objListCurso.Add(objCurso);
            }
        }
        
        public class Curso
        {
            public string IDCurso { get; set; }
            public int CicloDeCurso { get; set; }
            public int MaxInasistencia { get; set; }
            public string IDProfesor { get; set; }
            public string Nombre { get; set; }
        }
    }
}