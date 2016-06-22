/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.entidades;

import java.sql.Date;

/**
 *
 * @author davidwesker
 */
public class HorarioProfesor {
    private String IDCurso;
    private String Nombre;
    private String Dia;
    private Date HoraIni;
    private Date HoraFin;

    public String getIDCurso() {
        return IDCurso;
    }

    public void setIDCurso(String IDCurso) {
        this.IDCurso = IDCurso;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getDia() {
        return Dia;
    }

    public void setDia(String Dia) {
        this.Dia = Dia;
    }

    public Date getHoraIni() {
        return HoraIni;
    }

    public void setHoraIni(Date HoraIni) {
        this.HoraIni = HoraIni;
    }

    public Date getHoraFin() {
        return HoraFin;
    }

    public void setHoraFin(Date HoraFin) {
        this.HoraFin = HoraFin;
    }
    
}
