/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.ApoderadoDAO;
import com.upc.upcnet.dao.RecursoDAO;
import com.upc.upcnet.entidades.Recurso;
import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebService;

/**
 *
 * @author davidwesker
 */
@WebService(serviceName = "UPCNETServiceRecurso")
public class UPCNETServiceRecurso {
    
    @WebMethod(operationName = "getRecurso")
    public List<Recurso> getRecurso(){
        
        RecursoDAO objRecursoDAO=new RecursoDAO();
        List<Recurso>ListaRecurso=objRecursoDAO.getRecurso();
        
        return ListaRecurso;  
    }
    
    @WebMethod(operationName = "setRecurso")
    public void setRecurso(String _idRecurso, String _nombreRecurso, String _FechaPedido, String _CantidadHoras, String _Reservado,String _idAlumno,String _idProfesor){
        
        RecursoDAO objRecursoDAO=new RecursoDAO();
        objRecursoDAO.setRecurso(_idRecurso, _nombreRecurso, _FechaPedido, _CantidadHoras, _Reservado, _idAlumno, _idProfesor);
    }
    
    @WebMethod(operationName = "editRecurso")
    public void editRecurso(String _idRecurso, String _nombreRecurso, String _FechaPedido, String _CantidadHoras, String _Reservado,String _idAlumno,String _idProfesor){
        
        RecursoDAO objRecursoDAO=new RecursoDAO();
        objRecursoDAO.editRecurso(_idRecurso, _nombreRecurso, _FechaPedido, _CantidadHoras, _Reservado, _idAlumno, _idProfesor);
    }
    
}
