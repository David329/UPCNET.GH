using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPCNETSystemCliente.UPCNETServiceCursoClase;
namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _AddEditHorario
    {
        public string IDHorario { get; set; }
        public string IDCurso { get; set; }
        public string Dia { get; set; }
        public string HoraIni { get; set; }
        public string HoraFin { get; set; }
        public string Modo { get; set; }

        public _AddEditHorario() { }

        public void Fill(string IDHorario, string Modo)
        {
            this.IDHorario = IDHorario;
            if(IDHorario != "" && IDHorario != null)
            {
                UPCNETServiceCursoClaseClient proxy = new UPCNETServiceCursoClaseClient();
                UPCNETServiceCursoClase.cursoClaseReporte[] cursos = proxy.getCursoClases();
                foreach (var item in cursos)
                {
                    if(item.iDClase == IDHorario)
                    {
                        this.IDCurso = item.iDCurso;
                        this.Dia = item.dia;
                        this.HoraIni = item.horaIni;
                        this.HoraFin = item.horaFin;
                    }
                }
            }
            this.Modo = Modo;
        }
    }
}