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
    public void setProfesor(Profesor objProfesor) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        profesorDAO.setProfesor(objProfesor);
        
    }

    @WebMethod(operationName = "editProfesor")
    public void editProfesor(Profesor objProfesor) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        profesorDAO.editProfesor(objProfesor);        
    }

    @WebMethod(operationName = "validarLogin")
    public boolean validarLogin(String _idProfesor, String _pass) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        return profesorDAO.validarLogin(_idProfesor, _pass);
    }

    @WebMethod(operationName = "getProfesorById")
    public Profesor getProfesorById(String _idProfesor) {
        ProfesorDAO profesorDAO = new ProfesorDAO();
        List<Profesor> profesores = profesorDAO.getProfesorById(_idProfesor);
        return profesores.get(0);
    }
}
