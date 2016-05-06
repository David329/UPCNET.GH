/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.Seccion;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ALEX
 */
public class SeccionDAO {
    
    public List<Seccion> getSecciones(){
        List<Seccion> secciones = new ArrayList<>();
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDSecclase, IDSeccion, IDAlumno, IDCurso, PC1, PC2, EP, EF, Retirado,Inasistencias, Delegado");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Seccion s = new Seccion();
                s.setIdSecclase(rs.getString("IDSecclase"));
                s.setIdSeccion(rs.getString("IDSeccion"));
                s.setIdAlumno(rs.getString("IDAlumno"));
                s.setIdCurso(rs.getString("IDCurso"));
                s.setPc1(rs.getFloat("PC1"));
                s.setPc2(rs.getFloat("PC2"));
                s.setEp(rs.getFloat("EP"));
                s.setEf(rs.getFloat("EP"));
                s.setRetirado(rs.getString("Retirado"));
                s.setInasistencias(rs.getString("Inasistancias"));
                s.setDelegado(rs.getString("Delegado"));
                
                secciones.add(s);
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
        return secciones;
    }

    
    public void setSecciones(String _idSecclase, String _idSeccion, String _idAlumno, String _idCurso, String _pc1, String _pc2, String _ep, String _ef, String _retirado, String _inasistencias, String _delegado){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Seccion WHERE IDSecclase = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idSecclase);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El codigo de la seccion ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Seccion(IDSecclase, IDSeccion, IDAlumno, IDCurso, PC1, PC2, EP, EF, Retirado,Inasistencias, Delegado) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idSecclase);
            ps.setString(2, _idSeccion);
            ps.setString(3, _idAlumno);
            ps.setString(4, _idCurso);
            ps.setDouble(5, Double.parseDouble(_pc1));
            ps.setDouble(6, Double.parseDouble(_pc2));
            ps.setDouble(7, Double.parseDouble(_ep));
            ps.setDouble(8, Double.parseDouble(_ef));
            ps.setString(9, _retirado);
            ps.setString(10, _inasistencias);
            ps.setString(11, _delegado);
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
    
    public void editSecciones(String _idSecclase, String _idSeccion, String _idAlumno, String _idCurso, String _pc1, String _pc2, String _ep, String _ef, String _retirado, String _inasistencias, String _delegado){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Profesor SET IDSeccion = ?, IDAlumno = ?, IDCurso = ?, PC1 = ?, PC2 = ?, EP = ?, EF = ?, Retirado = ?, Inasistencias = ?, Delegado = ? WHERE IDSecclase = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idSeccion);
            ps.setString(2, _idAlumno);
            ps.setString(3, _idCurso);
            ps.setDouble(4, Double.parseDouble(_pc1));
            ps.setDouble(5, Double.parseDouble(_pc2));
            ps.setDouble(6, Double.parseDouble(_ep));
            ps.setDouble(7, Double.parseDouble(_ef));
            ps.setString(8, _retirado);
            ps.setString(9, _inasistencias);
            ps.setString(10, _delegado);
            ps.setString(11, _idSecclase);
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("Seccion no existe!"); 
            
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
