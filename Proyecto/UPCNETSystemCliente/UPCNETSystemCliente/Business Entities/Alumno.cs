using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Alumno
    {
        private String IdAlumno;
        private String Nombre;
        private String Apellido;
        private String Codigo;
        private String Carrera;
        private String DNI;
        private String Correo;
        private String Fecha;
        private String IDCategoria;
        private String IDApoderado;
        private String Pass;

        public Alumno(string idAlumno, string nombre, string apellido, string codigo, string carrera, string dNI, string correo, string fecha, string iDCategoria,string IDApoderado,string Pass)
        {
            IdAlumno = idAlumno;
            Nombre = nombre;
            Apellido = apellido;
            Codigo = codigo;
            Carrera = carrera;
            DNI = dNI;
            Correo = correo;
            Fecha = fecha;
            IDCategoria = iDCategoria;
            this.IDApoderado = IDApoderado;
            this.Pass = Pass;
        }

        public String getIdAlumno() { return IdAlumno; }
        public String getNombre() { return Nombre; }
        public String getApellido() { return Apellido; }
        public String getCodigo() { return Codigo; }
        public String getCarrera() { return Carrera; }
        public String getDNI() { return DNI; }
        public String getCorreo() { return Correo; }
        public String getFecha() { return Fecha; }
        public String getIDCategoria() { return IDCategoria; }
        public String getIDApoderado() { return IDApoderado; }
        public String getPass() { return Pass; }

    }
}