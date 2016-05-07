using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Profesor
    {
        private String IdProfesor;
        private String Nombre;
        private String Apellido;
        private String DNI;
        private String Edad;
        private String Correo;
        private String Direccion;
        private String Sueldo;

        public Profesor(String nombre, String apellido, String idprofesor, String carrera, String dni, String correo,
                 String direccion, String sueldo, String edad)
        {
            this.IdProfesor = idprofesor;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Edad = edad;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Sueldo = sueldo;
        }


        public String getIdProfesor() { return IdProfesor; }
        public String getNombre() { return Nombre; }
        public String getApellido() { return Apellido; }
        public String getDNI() { return DNI; }
        public String getEdad() { return Edad; }
        public String getCorreo() { return Correo; }
        public String getDireccion() { return Direccion; }
        public String getSueldo() { return Sueldo; }


    }
}