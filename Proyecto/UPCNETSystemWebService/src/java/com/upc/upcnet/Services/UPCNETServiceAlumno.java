/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.AlumnoDAO;
import com.upc.upcnet.entidades.Alumno;
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
        AlumnoDAO alumnoDAO = new AlumnoDAO();        
        return alumnoDAO.getAlumnos();
    }

    @WebMethod(operationName = "setAlumno")
    public void setAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        alumnoDAO.setAlumno(_idAlumno, _nombre, _apellido, _dni, _edad, _correo, _direccion, _idCategoria, _idApoderado);
        
    }

    @WebMethod(operationName = "editAlumno")
    public void editAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado) {
        AlumnoDAO alumnoDAO = new AlumnoDAO();
        alumnoDAO.editAlumno(_idAlumno, _nombre, _apellido, _dni, _edad, _correo, _direccion, _idCategoria, _idApoderado);
        
    }
    
    
    
    
    
    
}
