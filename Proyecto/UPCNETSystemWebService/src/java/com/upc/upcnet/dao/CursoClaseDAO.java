/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.CursoClase;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author davidwesker
 */
public class CursoClaseDAO {
    public List<CursoClase> getCursoClase() {
        List<CursoClase> cursoclases = new ArrayList<>();
        Connection con = null;
        try {
            con = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDClase,IDCurso ,Dia, HoraIni, HoraFin FROM Curso_Clase");
            PreparedStatement ps = con.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                CursoClase a = new CursoClase();
                a.setIdClase(rs.getString("IDClase"));
                a.setIdCurso(rs.getString("IDCurso"));
                a.setDia(rs.getString("Dia"));
                a.setHoraIni(rs.getDate("HoraIni"));
                a.setHoraFin(rs.getDate("HoraFin"));
                
                cursoclases.add(a);
            }
        } catch (SQLException ex) {
            throw new RuntimeException(ex.getMessage());
        } catch (Exception e) {
            throw new RuntimeException("No se tiene acceso al servidor");
        } finally {
            try {
                if (con != null) {
                    con.close();
                }
            } catch (Exception ex) {
            }
        }
        return cursoclases;
    }
    
    public List<CursoClase> getCursoClasesByIdCurso(String _idCurso){
         List<CursoClase> cursoclases = new ArrayList<>();
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDClase,IDCurso ,Dia, HoraIni, HoraFin FROM Curso_Clase WHERE IDCurso = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idCurso);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                CursoClase a = new CursoClase();
                a.setIdClase(rs.getString("IDClase"));
                a.setIdCurso(rs.getString("IDCurso"));
                a.setDia(rs.getString("Dia"));
                a.setHoraIni(rs.getDate("HoraIni"));
                a.setHoraFin(rs.getDate("HoraFin"));
                
                cursoclases.add(a);
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
        return cursoclases;
    }
    
    public void setCursoClase(CursoClase objCursoClase){
        Connection cn = null;        
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Curso_Clase WHERE IDCurso= ? and IDClase=?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objCursoClase.getIdClase());
            ps.setString(2, objCursoClase.getIdCurso());
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El Curso y Clase ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Curso_Clase(IDCurso,IDClase,Dia,HoraIni,HoraFin) VALUES(?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, objCursoClase.getIdCurso());
            ps.setString(2, objCursoClase.getIdClase());
            ps.setString(3, objCursoClase.getDia());
            ps.setDate(4, (Date) objCursoClase.getHoraIni());
            ps.setDate(5, (Date) objCursoClase.getHoraFin());
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
    
    public void editCursoClase(CursoClase objCursoClase){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Curso_Clase SET Date=?, HoraIni= ?, HoraFin= ? WHERE IDCurso=? and IDClase= ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, objCursoClase.getDia());
            ps.setDate(2, (Date) objCursoClase.getHoraIni());
            ps.setDate(3, (Date) objCursoClase.getHoraFin());
            ps.setString(4, objCursoClase.getIdCurso());
            ps.setString(5, objCursoClase.getIdClase());
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("CursoClase no existe!");            
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
    
    public List<CursoClase> getCursoClaseByID(String _idCurso,String _idClase){
        List<CursoClase> cursoclases = new ArrayList<>();
        Connection con = null;
        try {
            con = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDClase,IDCurso ,Dia, HoraIni, HoraFin FROM Curso_Clase where IDClase=? and ICurso=?");
            PreparedStatement ps = con.prepareStatement(query.toString());
            ps.setString(1, _idClase);
            ps.setString(2, _idCurso);
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                CursoClase a = new CursoClase();
                a.setIdClase(rs.getString("IDClase"));
                a.setIdCurso(rs.getString("IDCurso"));
                a.setDia(rs.getString("Dia"));
                a.setHoraIni(rs.getDate("HoraIni"));
                a.setHoraFin(rs.getDate("HoraFin"));
                
                cursoclases.add(a);
            }
        } catch (SQLException ex) {
            throw new RuntimeException(ex.getMessage());
        } catch (Exception e) {
            throw new RuntimeException("No se tiene acceso al servidor");
        } finally {
            try {
                if (con != null) {
                    con.close();
                }
            } catch (Exception ex) {
            }
        }
        return cursoclases;
    }
}
