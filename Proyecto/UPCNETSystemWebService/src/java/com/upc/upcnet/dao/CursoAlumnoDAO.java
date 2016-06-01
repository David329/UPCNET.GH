/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.AlumnoCurso;
import com.upc.upcnet.entidades.CursoAlumnoReporte;
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
public class CursoAlumnoDAO {
    public List<CursoAlumnoReporte> getCursoAlumnos(){
        List<CursoAlumnoReporte> lista = new ArrayList<>();
        Connection cn = null;
         try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT al.IDAlumno, c.IDCurso, al.Nombre AS NombreAlumno, al.Apellido AS ApellidoAlumno, c.Nombre AS CursoNombre, p.Nombre AS ProfesorNombre, P.Apellido AS ProfesorApellido FROM Alumno al\n" +
                    "JOIN Curso_Alumno ca ON ca.IDAlumno = al.IDAlumno\n" +
                    "JOIN Curso c ON c.IDCurso = ca.IDCurso\n" +
                    "JOIN Profesor p ON p.IDProfesor = c.IDProfesor");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                CursoAlumnoReporte ca = new CursoAlumnoReporte();
                ca.setIdAlumno(rs.getString("IDAlumno"));
                ca.setIdCurso(rs.getString("IDCurso"));
                ca.setAlumnoNombre(rs.getString("NombreAlumno"));
                ca.setAlumnoApellido(rs.getString("ApellidoAlumno"));
                ca.setCursoNombre(rs.getString("CursoNombre"));
                ca.setProfesorNombre(rs.getString("ProfesorNombre"));
                ca.setProfesorApellido(rs.getString("ProfesorApellido"));
                
                lista.add(ca);
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
    
    public List<CursoAlumnoReporte> getCursoAlumnoById(String idCurso, String idAlumno){
        List<CursoAlumnoReporte> lista = new ArrayList<>();
        Connection cn = null;
         try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT al.IDAlumno, c.IDCurso, al.Nombre AS NombreAlumno, al.Apellido AS ApellidoAlumno, c.Nombre AS CursoNombre, p.Nombre AS ProfesorNombre, P.Apellido AS ProfesorApellido FROM Alumno al\n" +
                    "JOIN Curso_Alumno ca ON ca.IDAlumno = al.IDAlumno\n" +
                    "JOIN Curso c ON c.IDCurso = ca.IDCurso\n" +
                    "JOIN Profesor p ON p.IDProfesor = c.IDProfesor WHERE ca.IDAlumno = ? AND ca.IDCurso = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, idAlumno);
            ps.setString(2, idCurso);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                CursoAlumnoReporte ca = new CursoAlumnoReporte();
                ca.setIdAlumno(rs.getString("IDAlumno"));
                ca.setIdCurso(rs.getString("IDCurso"));
                ca.setAlumnoNombre(rs.getString("NombreAlumno"));
                ca.setAlumnoApellido(rs.getString("ApellidoAlumno"));
                ca.setCursoNombre(rs.getString("CursoNombre"));
                ca.setProfesorNombre(rs.getString("ProfesorNombre"));
                ca.setProfesorApellido(rs.getString("ProfesorApellido"));
                
                lista.add(ca);
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
    
    public void setCursoAlumno(AlumnoCurso objAlumnoCurso){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("INSERT INTO Curso_Alumno(IDCurso, IDAlumno, Retirado, Inasistencias, Delegado) VALUES(?, ?, ?, ?, ?)");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objAlumnoCurso.getIdCurso());
            ps.setString(2, objAlumnoCurso.getIdAlumno());
            ps.setInt(3, objAlumnoCurso.getRetirado());
            ps.setInt(4, objAlumnoCurso.getInasistencias());
            ps.setInt(5, objAlumnoCurso.getDelegado());
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
    
    public void editAlumno(AlumnoCurso objAlumnoCurso){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Curso_Alumno SET IDCurso ?, IDAlumno = ?, Retirado = ?, Inasistencias = ?, Delegado = ? WHERE IDCurso = ? AND IDAlumno = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objAlumnoCurso.getIdCurso());
            ps.setString(2, objAlumnoCurso.getIdAlumno());
            ps.setInt(3, objAlumnoCurso.getRetirado());
            ps.setInt(4, objAlumnoCurso.getInasistencias());
            ps.setInt(5, objAlumnoCurso.getDelegado());
            ps.setString(6, objAlumnoCurso.getIdCurso());
            ps.setString(7, objAlumnoCurso.getIdAlumno());
            
            int realizado = ps.executeUpdate();
            
            if(realizado == 0)
                throw  new SQLException("Alumno no existe!");     
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
