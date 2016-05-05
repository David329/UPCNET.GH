/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.Recurso;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 *
 * @author davidwesker
 */
public class RecursoDAO {

    public List<Recurso> getRecurso() {
        List<Recurso> recursos = new ArrayList<>();
        Connection con = null;
        try {
            con = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("select IDRecurso,NombreRecurso,FechaPedido,CantidadHoras,Reservado,IDAlumno,IDProfesor from Recurso");
            PreparedStatement ps = con.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                Recurso a = new Recurso();
                a.setIDRecurso(rs.getString("IDRecurso"));
                a.setNombreRecurso(rs.getString("NombreRecurso"));
                a.setFechaPedido(rs.getDate("FechaPedido"));
                a.setCantidadHoras(rs.getInt("CantidadHoras"));
                a.setReservado(rs.getBoolean("Reservado"));
                a.setIDAlumno(rs.getString("IDAlumno"));
                a.setIDProfesor(rs.getString("IDProfesor"));

                recursos.add(a);
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
        return recursos;
    }
    public void setRecurso(String _idRecurso, String _nombreRecurso, String _FechaPedido, String _CantidadHoras, String _Reservado,String _idAlumno,String _idProfesor){
        Connection cn = null;        
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Recurso WHERE IDRecurso = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idRecurso);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El codigo del Recurso ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Recurso(IDRecurso,NombreRecurso,FechaPedido,CantidadHoras,Reservado,IDAlumno,IDProfesor) VALUES(?, ?, ?, ?, ?, ?, ?)");
            DateFormat df = new SimpleDateFormat("MM/dd/yyyy");            
            
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idRecurso);
            ps.setString(2, _nombreRecurso);
            ps.setDate(3, (java.sql.Date) df.parse(_FechaPedido));
            ps.setInt(4, Integer.parseInt(_CantidadHoras));
            ps.setBoolean(5, Boolean.parseBoolean(_Reservado));
            ps.setString(6, _idAlumno);
            ps.setString(7, _idProfesor);
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
    public void editRecurso(String _idRecurso, String _nombreRecurso, String _FechaPedido, String _CantidadHoras, String _Reservado,String _idAlumno,String _idProfesor){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Recurso SET NombreRecurso = ?, FechaPedido = ?, CantidadHoras = ?, Reservado = ?, IDAlumno = ?, IDProfesor = ? WHERE IDRecurso= ?");
            DateFormat df = new SimpleDateFormat("MM/dd/yyyy");
            
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _nombreRecurso);
            ps.setDate(2, (java.sql.Date) df.parse(_FechaPedido));
            ps.setInt(3, Integer.parseInt(_CantidadHoras));
            ps.setBoolean(4, Boolean.parseBoolean(_Reservado));
            ps.setString(5, _idAlumno);
            ps.setString(6, _idProfesor);
            
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("Recurso no existe!");            
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
