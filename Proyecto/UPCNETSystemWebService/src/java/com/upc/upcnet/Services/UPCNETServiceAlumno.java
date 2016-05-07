/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.AlumnoDAO;
import com.upc.upcnet.entidades.Alumno;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Petith
 */
@WebService(serviceName = "UPCNETServiceAlumno")
public class UPCNETServiceAlumno {

    @WebMethod(operationName = "getAlumnos")
    public List<Alumno> getAlumnos() {
       // AlumnoDAO alumnoDAO = new AlumnoDAO(); 
            List<Alumno> lista = new ArrayList<>(); 
            Alumno a = new Alumno(); Alumno b = new Alumno();
            a.setApellido("Maguiña");   a.setNombre("Ian");  a.setIdAlumno("001"); a.setPass("123");a.setCorreo("whaat@duspace.com");
            b.setNombre("Persona"); b.setApellido("Aleatoria"); b.setIdAlumno("user"); b.setPass("1234");b.setCorreo("rcm@duspace.com");
           
            lista.add(a); lista.add(b);
        return lista;
    }

    @WebMethod(operationName = "setAlumno")
    public void setAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado, String _pass) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        alumnoDAO.setAlumno(_idAlumno, _nombre, _apellido, _dni, _edad, _correo, _direccion, _idCategoria, _idApoderado, _pass);
        
    }

    @WebMethod(operationName = "editAlumno")
    public void editAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado, String _pass) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        alumnoDAO.editAlumno(_idAlumno, _nombre, _apellido, _dni, _edad, _correo, _direccion, _idCategoria, _idApoderado, _pass);
        
    }

    @WebMethod(operationName = "validarLogin")
    public boolean validarLogin(String _idAlumno, String _pass) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        return alumnoDAO.validarLogin(_idAlumno, _pass);
    }

    @WebMethod(operationName = "getAlumnoById")
    public Alumno getAlumnoById(String _idAlumno) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        List<Alumno> alumnos = alumnoDAO.getAlumnosById(_idAlumno);
        return alumnos.get(0);
    }   
}
