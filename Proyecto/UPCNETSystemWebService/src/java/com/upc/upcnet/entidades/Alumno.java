/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.entidades;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ALEX
 */
public class Alumno {
    
    private String Nombre;
    private String Apellido;
    private String Codigo;
    private String Carrera;
    private String DNI;
    private String Correo;
    private String Fecha;
    private String IDCategoria;
    
    public List<Object> getAlumno(){
        List<Object> lista=new ArrayList<>();
        lista.add(Nombre);
        lista.add(Apellido);
        lista.add(Codigo);
        lista.add(Carrera);
        lista.add(DNI);
        lista.add(Correo);
        lista.add(Carrera);
        lista.add(Fecha);
        lista.add(IDCategoria);
        return lista;
    } 
    public void setAlumno(List<Object> objAl){
        
        Nombre=(String) objAl.get(0);
        Apellido=(String) objAl.get(1);
        Codigo=(String) objAl.get(2);
    }
            

    public String getIDCategoria() {
        return IDCategoria;
    }

    public void setIDCategoria(String IDCategoria) {
        this.IDCategoria = IDCategoria;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String Apellido) {
        this.Apellido = Apellido;
    }

    public String getCodigo() {
        return Codigo;
    }

    public void setCodigo(String Codigo) {
        this.Codigo = Codigo;
    }

    public String getCarrera() {
        return Carrera;
    }

    public void setCarrera(String Carrera) {
        this.Carrera = Carrera;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public String getCorreo() {
        return Correo;
    }

    public void setCorreo(String Correo) {
        this.Correo = Correo;
    }

    public String getFecha() {
        return Fecha;
    }

    public void setFecha(String Fecha) {
        this.Fecha = Fecha;
    }
    
    
}
