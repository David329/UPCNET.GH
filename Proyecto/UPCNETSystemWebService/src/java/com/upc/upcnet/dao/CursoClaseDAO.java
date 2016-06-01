/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.CursoClase;
import com.upc.upcnet.entidades.CursoClaseReporte;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Petith
 */
public class CursoClaseDAO {
    public List<CursoClaseReporte> getCursoClases(){
        List<CursoClaseReporte> lista = new ArrayList<>();        
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT cc.IDClase, c.IDCurso, al.Nombre AS NombreAlumno, al.Apellido AS ApellidoAlumno, c.Nombre AS CursoNombre, p.Nombre AS ProfesorNombre, p.Apellido AS ProfesorApellido, cc.Dia, cc.HoraIni, cc.HoraFin FROM Alumno al JOIN Curso_Alumno ca ON ca.IDAlumno = al.IDAlumno JOIN Curso c ON c.IDCurso = ca.IDCurso JOIN Curso_Clase cc ON cc.IDCurso = C.IDCurso JOIN Profesor p ON p.IDProfesor = c.IDProfesor");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                CursoClaseReporte cc = new CursoClaseReporte();
                cc.setiDClase(rs.getString("IDClase"));
                cc.setiDCurso(rs.getString("IDClase"));
                cc.setAlumnoNombre(rs.getString("NombreAlumno"));
                cc.setAlumnoApellido(rs.getString("ApellidoAlumno"));
                cc.setCursoNombre(rs.getString("CursoNombre"));
                cc.setProfesorNombre(rs.getString("ProfesorNombre"));
                cc.setProfesorApellido(rs.getString("ProfesorApellido"));
                cc.setDia(rs.getString("Dia"));
                cc.setHoraIni(rs.getString("HoraIni"));
                cc.setHoraFin(rs.getString("HoraFin"));
                
                lista.add(cc);
            }
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
        return lista;
    }
    
    public List<CursoClaseReporte> getCursoClaseById(String idClase){
        List<CursoClaseReporte> lista = new ArrayList<>();        
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT cc.IDClase, c.IDCurso, al.Nombre AS NombreAlumno, al.Apellido AS ApellidoAlumno, c.Nombre AS CursoNombre, p.Nombre AS ProfesorNombre, p.Apellido AS ProfesorApellido, cc.Dia, cc.HoraIni, cc.HoraFin FROM Alumno al JOIN Curso_Alumno ca ON ca.IDAlumno = al.IDAlumno JOIN Curso c ON c.IDCurso = ca.IDCurso JOIN Curso_Clase cc ON cc.IDCurso = C.IDCurso JOIN Profesor p ON p.IDProfesor = c.IDProfesor WHERE cc.IDClase = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, idClase);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                CursoClaseReporte cc = new CursoClaseReporte();
                cc.setiDClase(rs.getString("IDClase"));
                cc.setiDCurso(rs.getString("IDClase"));
                cc.setAlumnoNombre(rs.getString("NombreAlumno"));
                cc.setAlumnoApellido(rs.getString("ApellidoAlumno"));
                cc.setCursoNombre(rs.getString("CursoNombre"));
                cc.setProfesorNombre(rs.getString("ProfesorNombre"));
                cc.setProfesorApellido(rs.getString("ProfesorApellido"));
                cc.setDia(rs.getString("Dia"));
                cc.setHoraIni(rs.getString("HoraIni"));
                cc.setHoraFin(rs.getString("HoraFin"));
                
                lista.add(cc);
            }
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
        return lista;
    } 
    
    public void setCursoClase(CursoClase objCursoClase){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Curso_Clase WHERE IDClase = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objCursoClase.getIdClase());
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("Objeto ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Curso_Clase(IDClase, IDCurso, Dia, HoraIni, HoraFin) VALUES(?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, objCursoClase.getIdClase());
            ps.setString(2, objCursoClase.getIdCurso());
            ps.setString(3, objCursoClase.getDia());
            ps.setString(4, objCursoClase.getHoraIni());
            ps.setString(5, objCursoClase.getHoraFin());
            ps.executeUpdate();
            cn.commit();
            
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
    }
}
