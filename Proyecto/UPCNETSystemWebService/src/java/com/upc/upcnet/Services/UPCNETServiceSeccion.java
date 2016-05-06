/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.SeccionDAO;
import com.upc.upcnet.entidades.Seccion;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author ALEX
 */
@WebService(serviceName = "UPCNETServiceSeccion")
public class UPCNETServiceSeccion {


    @WebMethod(operationName = "getSeccion")
    public List<Seccion> getSeccion() {
        SeccionDAO seccionDAO =new SeccionDAO();
        return seccionDAO.getSecciones();
    }
    @WebMethod(operationName = "setSeccion")
    public void setSeccion(String _idSecclase, String _idSeccion, String _idAlumno, String _idCurso, String _pc1, String _pc2, String _ep, String _ef, String _retirado, String _inasistencias, String _delegado) {
        SeccionDAO seccionDAO =new SeccionDAO();
        seccionDAO.setSecciones(_idSecclase, _idSeccion, _idAlumno, _idCurso, _pc1, _pc2, _ep, _ef, _retirado, _inasistencias, _delegado);
    }
    @WebMethod(operationName = "editSeccion")
    public void editSecciones(String _idSecclase, String _idSeccion, String _idAlumno, String _idCurso, String _pc1, String _pc2, String _ep, String _ef, String _retirado, String _inasistencias, String _delegado) {
        SeccionDAO seccionDAO =new SeccionDAO();
        seccionDAO.editSecciones(_idSecclase, _idSeccion, _idAlumno, _idCurso, _pc1, _pc2, _ep, _ef, _retirado, _inasistencias, _delegado);
    }
}
