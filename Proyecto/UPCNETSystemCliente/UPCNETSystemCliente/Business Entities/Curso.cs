using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Curso
    {
        private String IdCurso;
        private String CicloDeCurso;
        private String MaxInasistencia;
        private String IdProfesor;

        public Curso(string idCurso, string cicloDeCurso, string maxInasistencia, string idProfesor)
        {
            IdCurso = idCurso;
            CicloDeCurso = cicloDeCurso;
            MaxInasistencia = maxInasistencia;
            IdProfesor = idProfesor;
        }

        public String getIdCurso() { return IdCurso; }
        public String getCicloDeCurso() { return CicloDeCurso; }
        public String getMaxInasitencia() { return MaxInasistencia; }
        public String getIdProfesor() { return IdProfesor; }

    }
}