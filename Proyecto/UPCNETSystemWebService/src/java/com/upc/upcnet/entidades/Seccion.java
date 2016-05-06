/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.entidades;

/**
 *
 * @author ALEX
 */
public class Seccion {
    private String idSecclase;
    private String idSeccion;
    private String idAlumno;
    private String idCurso;
    private float pc1;
    private float pc2;
    private float ep;
    private float ef;
    private String retirado;
    private String inasistencias;
    private String delegado;

    public String getIdSecclase() {
        return idSecclase;
    }

    public void setIdSecclase(String idSecclase) {
        this.idSecclase = idSecclase;
    }

    public String getIdSeccion() {
        return idSeccion;
    }

    public void setIdSeccion(String idSeccion) {
        this.idSeccion = idSeccion;
    }

    public String getIdAlumno() {
        return idAlumno;
    }

    public void setIdAlumno(String idAlumno) {
        this.idAlumno = idAlumno;
    }

    public String getIdCurso() {
        return idCurso;
    }

    public void setIdCurso(String idCurso) {
        this.idCurso = idCurso;
    }

    public float getPc1() {
        return pc1;
    }

    public void setPc1(float pc1) {
        this.pc1 = pc1;
    }

    public float getPc2() {
        return pc2;
    }

    public void setPc2(float pc2) {
        this.pc2 = pc2;
    }

    public float getEp() {
        return ep;
    }

    public void setEp(float ep) {
        this.ep = ep;
    }

    public float getEf() {
        return ef;
    }

    public void setEf(float ef) {
        this.ef = ef;
    }

    public String getRetirado() {
        return retirado;
    }

    public void setRetirado(String retirado) {
        this.retirado = retirado;
    }

    public String getInasistencias() {
        return inasistencias;
    }

    public void setInasistencias(String inasistencias) {
        this.inasistencias = inasistencias;
    }

    public String getDelegado() {
        return delegado;
    }

    public void setDelegado(String delegado) {
        this.delegado = delegado;
    }
    
}
