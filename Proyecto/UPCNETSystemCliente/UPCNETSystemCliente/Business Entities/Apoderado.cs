using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class Apoderado
    {
        private String IdApoderado;
        private String Nombre;
        private String Apellido;
        private String DNI;
        private String Edad;
        private String Correo;
        private String Direccion;
        private String Condicion;

        public Apoderado(String nombre, String apellido, String idapoderado, String carrera, String dni, String correo,
                 String direccion, String condicion, String edad)
        {
            this.IdApoderado = idapoderado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Edad = edad;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Condicion = condicion;
        }
        public String getIdApoderado() { return IdApoderado; }
        public String getNombre() { return Nombre; }
        public String getApellido() { return Apellido; }
        public String getDNI() { return DNI; }
        public String getEdad() { return Edad; }
        public String getCorreo() { return Correo; }
        public String getDireccion() { return Direccion; }
        public String getCondicion() { return Condicion; }



    }
}