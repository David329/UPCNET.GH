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
public class CursoClaseReporte {
    private String iDClase;
    private String iDCurso;
    private String alumnoNombre;
    private String alumnoApellido;
    private String cursoNombre;
    private String profesorNombre;
    private String profesorApellido;
    private String dia;
    private String horaIni;
    private String horaFin;

    public String getHoraIni() {
        return horaIni;
    }

    public void setHoraIni(String horaIni) {
        this.horaIni = horaIni;
    }

    public String getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(String horaFin) {
        this.horaFin = horaFin;
    }

    public String getiDClase() {
        return iDClase;
    }

    public void setiDClase(String iDClase) {
        this.iDClase = iDClase;
    }

    public String getiDCurso() {
        return iDCurso;
    }

    public void setiDCurso(String iDCurso) {
        this.iDCurso = iDCurso;
    }
    

    public String getAlumnoNombre() {
        return alumnoNombre;
    }

    public void setAlumnoNombre(String alumnoNombre) {
        this.alumnoNombre = alumnoNombre;
    }

    public String getAlumnoApellido() {
        return alumnoApellido;
    }

    public void setAlumnoApellido(String alumnoApellido) {
        this.alumnoApellido = alumnoApellido;
    }

    public String getCursoNombre() {
        return cursoNombre;
    }

    public void setCursoNombre(String cursoNombre) {
        this.cursoNombre = cursoNombre;
    }

    public String getProfesorNombre() {
        return profesorNombre;
    }

    public void setProfesorNombre(String profesorNombre) {
        this.profesorNombre = profesorNombre;
    }

    public String getProfesorApellido() {
        return profesorApellido;
    }

    public void setProfesorApellido(String profesorApellido) {
        this.profesorApellido = profesorApellido;
    }

    public String getDia() {
        return dia;
    }

    public void setDia(String dia) {
        this.dia = dia;
    }
}
