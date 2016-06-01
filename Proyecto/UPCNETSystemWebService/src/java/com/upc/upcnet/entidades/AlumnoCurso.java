/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.entidades;

/**
 *
 * @author Petith
 */
public class AlumnoCurso {
    private String idAlumno;
    private String idCurso;
    private Double pc1;
    private Double pc2;
    private Double ep;
    private Double ef;
    private int retirado;
    private int inasistencias;
    private int delegado;

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

    public Double getPc1() {
        return pc1;
    }

    public void setPc1(Double pc1) {
        this.pc1 = pc1;
    }

    public Double getPc2() {
        return pc2;
    }

    public void setPc2(Double pc2) {
        this.pc2 = pc2;
    }

    public Double getEp() {
        return ep;
    }

    public void setEp(Double ep) {
        this.ep = ep;
    }

    public Double getEf() {
        return ef;
    }

    public void setEf(Double ef) {
        this.ef = ef;
    }

    public int getRetirado() {
        return retirado;
    }

    public void setRetirado(int retirado) {
        this.retirado = retirado;
    }

    public int getInasistencias() {
        return inasistencias;
    }

    public void setInasistencias(int inasistencias) {
        this.inasistencias = inasistencias;
    }

    public int getDelegado() {
        return delegado;
    }

    public void setDelegado(int delegado) {
        this.delegado = delegado;
    }
}
