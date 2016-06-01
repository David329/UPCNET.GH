/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.CursoAlumnoDAO;
import com.upc.upcnet.entidades.AlumnoCurso;
import com.upc.upcnet.entidades.CursoAlumnoReporte;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Petith
 */
@WebService(serviceName = "UPCNETServiceCursoAlumno")
public class UPCNETServiceCursoAlumno {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getCursoAlumnos")
    public List<CursoAlumnoReporte> getCursoAlumnos() {
        CursoAlumnoDAO cursoAlumnoDAO = new CursoAlumnoDAO();
        List<CursoAlumnoReporte> lista = cursoAlumnoDAO.getCursoAlumnos();
        return lista;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getCursoAlumnoById")
    public CursoAlumnoReporte getCursoAlumnoById(@WebParam(name = "idCurso") String idCurso, @WebParam(name = "idAlumno") String idAlumno) {
         CursoAlumnoDAO cursoAlumnoDAO = new CursoAlumnoDAO();
        List<CursoAlumnoReporte> lista = cursoAlumnoDAO.getCursoAlumnoById(idCurso, idAlumno);
        return lista.get(0);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "setCursoAlumno")
    public void setCursoAlumno(AlumnoCurso objAlumnoCurso) {
        CursoAlumnoDAO cursoAlumnoDAO = new CursoAlumnoDAO();
        cursoAlumnoDAO.setCursoAlumno(objAlumnoCurso);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "editAlumno")
    public void editAlumno(AlumnoCurso objAlumnoCurso) {
        CursoAlumnoDAO cursoAlumnoDAO = new CursoAlumnoDAO();
        cursoAlumnoDAO.editAlumno(objAlumnoCurso);
    }
    
    
}
