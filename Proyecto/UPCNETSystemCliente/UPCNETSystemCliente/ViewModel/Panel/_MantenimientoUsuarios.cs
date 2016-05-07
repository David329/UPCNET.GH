using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using UPCNETSystemCliente.UPCNETServiceAlumno;

namespace UPCNETSystemCliente.ViewModel.Panel
{
    public class _MantenimientoUsuarios
    {
        public List<Alumno> ListObjetos { get; set; }

        public void Procesar(UPCNETServiceAlumno.alumno[] alumnos) {
            ListObjetos = new List<Alumno>();
            foreach (var item in alumnos)
            {
                Alumno objAlumno = new Alumno();
                objAlumno.Nombre = item.nombre;
                objAlumno.Apellido = item.apellido;
                objAlumno.Email = item.correo;
                objAlumno.Usuario = item.idAlumno;
                objAlumno.Password = item.pass;

                ListObjetos.Add(objAlumno);
            }
        }
    }

    public class Alumno {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}