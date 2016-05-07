using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Seccion
    {
        private String IdSecClase;
        private String IdSeccion;
        private String IdAlumno;
        private String IdCurso;
        private String Pc1;
        private String Pc2;
        private String Pc3;
        private String Ep;
        private String Ef;
        private String Retirado;
        private String Inasistencias;

        public Seccion(string idSecClase, string idSeccion, string idAlumno, string idCurso, string pc1, string pc2, string pc3, string ep, string ef, string retirado, string inasistencias)
        {
            IdSecClase = idSecClase;
            IdSeccion = idSeccion;
            IdAlumno = idAlumno;
            IdCurso = idCurso;
            Pc1 = pc1;
            Pc2 = pc2;
            Pc3 = pc3;
            Ep = ep;
            Ef = ef;
            Retirado = retirado;
            Inasistencias = inasistencias;
        }

        public String getIdSecClase() { return IdSecClase; }
        public String getIdSeccion() { return IdSeccion; }
        public String getIdAlumno() { return IdAlumno; }
        public String getIdCurso() { return IdCurso; }
        public String getPc1() { return Pc1; }
        public String getPc2() { return Pc2; }
        public String getEp() { return Ep; }
        public String getEf() { return Ef; }
        public String getRetirado() { return Retirado; }
        public String getInasistencias() { return Inasistencias; }
           

    }
}