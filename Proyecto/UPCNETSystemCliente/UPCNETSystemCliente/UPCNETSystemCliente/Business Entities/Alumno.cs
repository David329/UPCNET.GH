using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Alumno
    {
       
        private String Nombre;
        private String Apellido;
        private String Codigo;
        private String Carrera;
        private String DNI;
        private String Correo;
        private String Fecha;
        private String IDCategoria;

        public Alumno(String nombre, String apellido, String codigo, String carrera, String dni, String correo,
                 String fecha, String idCategoria)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Codigo = codigo;
            this.Carrera = carrera;
            this.DNI = dni;
            this.Correo = correo;
            this.Fecha = fecha;
            this.IDCategoria = idCategoria;
        }
        public String getNombre() { return Nombre;}
        public String getApellido() { return Apellido; }
        public String getCodigo() { return Codigo; }
        public String getCarrera() { return Carrera; }
        public String getDNI() { return DNI; }
        public String getCorreo() { return Correo; }
        public String getFecha() { return Fecha; }
        public String getIDCategoria() { return IDCategoria; }




    }
        
   
}