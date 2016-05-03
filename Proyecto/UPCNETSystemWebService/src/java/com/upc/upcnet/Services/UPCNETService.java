/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.Services;

import com.upc.upcnet.entidades.Alumno;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author ALEX
 */
@WebService(serviceName = "UPCNETService")
public class UPCNETService {

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
    @WebMethod(operationName = "Enviar_Alumnos")
    public List<Alumno> Enviar_Alumnos() {
        //TODO write your implementation code here:
        String cadena;
        Alumno al1=new Alumno();
        al1.setApellido("Apellido 1"); al1.setCodigo("Codigo 1");al1.setCarrera("Carrera 1");
        Alumno al2=new Alumno();
        al2.setApellido("Apellido 2"); al2.setCodigo("Codigo 2");al2.setCarrera("Carrera 2");
        Alumno al3=new Alumno();
        al3.setApellido("Apellido 3"); al3.setCodigo("Codigo 3");al3.setCarrera("Carrera 3");
        List<Alumno> alumnos=new ArrayList<>();
        alumnos.add(al1);
        alumnos.add(al2);
        alumnos.add(al3);
        
        //cadena=al1.getApellido()+" "+al1.getCodigo()+" "+ al1.getCarrera();
        return alumnos;  
    }
    
}
