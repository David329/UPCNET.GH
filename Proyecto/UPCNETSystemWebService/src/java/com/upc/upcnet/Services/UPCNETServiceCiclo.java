/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.dao.CicloDAO;
import com.upc.upcnet.entidades.Ciclo;
import java.util.List;
import javax.jws.WebMethod;

/**
 *
 * @author davidwesker
 */
public class UPCNETServiceCiclo {
    
    @WebMethod(operationName = "getCiclo")
    public List<Ciclo> getCiclo(){
        
        CicloDAO objCicloDAO=new CicloDAO();
        List<Ciclo>ListaCiclo=objCicloDAO.getCiclo();
        
        return ListaCiclo;  
    }
    
    @WebMethod(operationName = "setCiclo")
    public void setCiclo(String _idCiclo, String _idAlumno, String _boleta1, String _boleta2, String _boleta3){
        
        CicloDAO objCicloDAO=new CicloDAO();
        objCicloDAO.setCiclo(_idCiclo, _idAlumno, _boleta1, _boleta2, _boleta3);
    }
    
    @WebMethod(operationName = "editCiclo")
    public void editCiclo(String _idCiclo, String _idAlumno, String _boleta1, String _boleta2, String _boleta3){
        
        CicloDAO objCicloDAO=new CicloDAO();
        objCicloDAO.editCiclo(_idCiclo, _idAlumno, _boleta1, _boleta2, _boleta3);
    }
    
}