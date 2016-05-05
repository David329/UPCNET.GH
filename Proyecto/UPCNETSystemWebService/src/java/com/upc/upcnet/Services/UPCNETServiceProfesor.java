/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.ProfesorDAO;
import com.upc.upcnet.entidades.Profesor;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

@WebService(serviceName = "UPCNETServiceProfesor")
public class UPCNETServiceProfesor {

    @WebMethod(operationName = "getProfesor")
    public List<Profesor> getProfesor() {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        return profesorDAO.getProfesores();
    }

    @WebMethod(operationName = "setProfesor")
    public void setProfesor(String _idProfesor, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _sueldo) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        profesorDAO.setProfesor(_idProfesor, _nombre, _apellido, _dni, _edad, _correo, _direccion, _sueldo);
        
    }

    @WebMethod(operationName = "editProfesor")
    public void editProfesor(String _idProfesor, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _sueldo) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        profesorDAO.editProfesor(_idProfesor, _nombre, _apellido, _dni, _edad, _correo, _direccion, _sueldo);        
    }
    
    
}
