using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPCNETSystemCliente.UPCNETServiceCurso;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _AddEditCurso
    {
        public string IDCurso { get; set; }
        public int CicloDeCurso { get; set; }
        public int MaxInasistencia { get; set; }
        public string IDProfesor { get; set; }
        public string Nombre { get; set; }
        public string Modo { get; set; }

        public _AddEditCurso() { }

        public void Fill(string IDCurso, string Modo)
        {
            this.IDCurso = IDCurso;
            if(IDCurso != "" && IDCurso != null)
            {
                UPCNETServiceCursoClient proxy = new UPCNETServiceCursoClient();
                UPCNETServiceCurso.curso objCurso = proxy.getCursoById(IDCurso);
                this.CicloDeCurso = objCurso.cicloDeCurso;
                this.MaxInasistencia = objCurso.maxInasistencia;
                this.IDProfesor = objCurso.idProfesor;
                this.Nombre = objCurso.nombre;
            }
            this.Modo = Modo;
        }
    }
}