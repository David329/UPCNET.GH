using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPCNETCliente
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
        public String getIDCategoria()
        {
            return IDCategoria;
        }

        public void setIDCategoria(String IDCategoria)
        {
            this.IDCategoria = IDCategoria;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public String getApellido()
        {
            return Apellido;
        }

        public void setApellido(String Apellido)
        {
            this.Apellido = Apellido;
        }

        public String getCodigo()
        {
            return Codigo;
        }

        public void setCodigo(String Codigo)
        {
            this.Codigo = Codigo;
        }

        public String getCarrera()
        {
            return Carrera;
        }

        public void setCarrera(String Carrera)
        {
            this.Carrera = Carrera;
        }

        public String getDNI()
        {
            return DNI;
        }

        public void setDNI(String DNI)
        {
            this.DNI = DNI;
        }

        public String getCorreo()
        {
            return Correo;
        }

        public void setCorreo(String Correo)
        {
            this.Correo = Correo;
        }

        public String getFecha()
        {
            return Fecha;
        }

        public void setFecha(String Fecha)
        {
            this.Fecha = Fecha;
        }

    }
}
