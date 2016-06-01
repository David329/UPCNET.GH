/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.CursoDAO;
import com.upc.upcnet.entidades.Curso;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Petith
 */
@WebService(serviceName = "UPCNETServiceCurso")
public class UPCNETServiceCurso {

@WebMethod(operationName = "getCursos")
    public List<Curso> getCursos() {
        CursoDAO objCursoDAO=new CursoDAO();
        List<Curso>ListaAlumnos=objCursoDAO.getCursos();
        
        return ListaAlumnos; 
    }

    @WebMethod(operationName = "setCurso")
    public void setCurso(Curso objCurso) {
        CursoDAO cursoDAO = new CursoDAO();
        cursoDAO.setCurso(objCurso);
        
    }

    @WebMethod(operationName = "editCurso")
    public void editAlumno(Curso objCurso) {
        CursoDAO cursoDAO = new CursoDAO();
        cursoDAO.editCurso(objCurso);
        
    }

    @WebMethod(operationName = "getCursoById")
    public Curso getAlumnoById(String _idCurso) {
        CursoDAO cursoDAO = new CursoDAO();
        List<Curso> cursos = cursoDAO.getCursosById(_idCurso);
        return cursos.get(0);
    }   
}