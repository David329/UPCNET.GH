/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.CursoClaseDAO;
import com.upc.upcnet.entidades.CursoClase;
import com.upc.upcnet.entidades.CursoClaseReporte;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.xml.ws.BindingType;

/**
 *
 * @author Petith
 */
@WebService(serviceName = "UPCNETServiceCursoClase")
public class UPCNETServiceCursoClase {

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
    @WebMethod(operationName = "getCursoClases")
    public List<CursoClaseReporte> getCursoClases() {
        CursoClaseDAO cursoClaseDAO = new CursoClaseDAO();
        List<CursoClaseReporte> lista = cursoClaseDAO.getCursoClases();
        return lista;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "getCursoClaseById")
    public CursoClaseReporte getCursoClaseById(@WebParam(name = "idClase") String idClase) {
        CursoClaseDAO cursoClaseDAO = new CursoClaseDAO();
        List<CursoClaseReporte> lista = cursoClaseDAO.getCursoClaseById(idClase);
        return lista.get(0);
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "setCursoClase")
    public void setCursoClase(CursoClase objCursoClase) {
        CursoClaseDAO cursoClaseDAO = new CursoClaseDAO();
        cursoClaseDAO.setCursoClase(objCursoClase);
    }
    
    
}
