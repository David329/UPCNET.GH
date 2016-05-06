/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.entidades.Apoderado;
import java.util.List;
import javax.jws.WebMethod;
import com.upc.upcnet.dao.*;
import java.util.ArrayList;
/**
 *
 * @author davidwesker
 */
public class UPCNETServiceApoderado {
    
    @WebMethod(operationName = "getApoderado")
    public List<Apoderado> getApoderado(){
        
        ApoderadoDAO objApoderadoDAO=new ApoderadoDAO();
        List<Apoderado>ListaApoderado=objApoderadoDAO.getApoderados();
        
        return ListaApoderado;  
    }
    
    @WebMethod(operationName = "setApoderado")
    public void setApoderado(String _idApoderado,String _pass, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _condicion){
        
        ApoderadoDAO objApoderadoDAO=new ApoderadoDAO();
        objApoderadoDAO.setApoderado(_idApoderado, _pass, _nombre, _apellido, _dni, _edad, _correo, _direccion, _condicion);
    }
    
    @WebMethod(operationName = "editApoderado")
    public void editApoderado(String _idApoderado,String _pass, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _condicion){
        
        ApoderadoDAO objApoderadoDAO=new ApoderadoDAO();
        objApoderadoDAO.editApoderado(_idApoderado, _pass, _nombre, _apellido, _dni, _edad, _correo, _direccion, _condicion);
    }
    
}
