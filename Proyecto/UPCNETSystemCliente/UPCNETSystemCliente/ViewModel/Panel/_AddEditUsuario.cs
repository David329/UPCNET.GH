using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UPCNETSystemCliente.UPCNETServiceAlumno;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _AddEditUsuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Password { get; set; }
        public string IDAlumno { get; set; }
        public int Edad { get; set; }
        public string Modo { get; set; }

        public _AddEditUsuario()
        {

        }
        public void Fill(string IDAlumno, string Modo)
        {
            this.IDAlumno = IDAlumno;

            if (IDAlumno != "" && IDAlumno!=null)
            {
                UPCNETServiceAlumnoClient proxy = new UPCNETServiceAlumnoClient();
                UPCNETServiceAlumno.alumno objAlumno = proxy.getAlumnoById(IDAlumno);

                this.Nombre = objAlumno.nombre;
                this.Apellido = objAlumno.apellido;
                this.Correo = objAlumno.correo;
                this.DNI = objAlumno.dni;
                this.Password = objAlumno.pass;
                this.Direccion = objAlumno.direccion;
                this.Edad = objAlumno.edad;
                

                
            }
            this.Modo = Modo;
        }
    }
}


