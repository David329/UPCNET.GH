/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.BD.AccesoDB;
import com.upc.upcnet.entidades.Apoderado;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author davidwesker
 */
public class ApoderadoDAO {

    public List<Apoderado> getApoderados() {
        List<Apoderado> apoderados = new ArrayList<>();
        Connection con = null;
        try {
            con = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDApoderado, Nombre, Apellido, DNI, Edad, Correo,Direccion, Condicion FROM Apoderado");
            PreparedStatement ps = con.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                Apoderado a = new Apoderado();
                a.setIDApoderado(rs.getString("IDApoderado"));
                a.setNombre(rs.getString("Nombre"));
                a.setApellido(rs.getString("Apellido"));
                a.setDNI(rs.getInt("DNI"));
                a.setEdad(rs.getInt("Edad"));
                a.setCorreo(rs.getString("Correo"));
                a.setDireccion(rs.getString("Direccion"));
                a.setCondicion(rs.getString("Condicion"));

                apoderados.add(a);
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
        return apoderados;
    }
    public void setApoderado(String _idApoderado, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _condicion){
        Connection cn = null;        
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Apoderado WHERE IDApoderado = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idApoderado);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El codigo del Apoderado ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Apoderado(IDApoderado, Nombre, Apellido, DNI, Edad, Correo,Direccion, Condicion) VALUES(?, ?, ?, ?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idApoderado);
            ps.setString(2, _nombre);
            ps.setString(3, _apellido);
            ps.setInt(4, Integer.parseInt(_dni));
            ps.setInt(5, Integer.parseInt(_edad));
            ps.setString(6, _correo);
            ps.setString(7, _direccion);
            ps.setString(8, _condicion);
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
    public void editApoderado(String _idApoderado, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _condicion){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Apoderado SET Nombre = ?, Apellido = ?, DNI = ?, Edad = ?, Correo = ?, Direccion = ? WHERE IDApoderado= ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _nombre);
            ps.setString(2, _apellido);
            ps.setInt(3, Integer.parseInt(_dni));
            ps.setInt(4, Integer.parseInt(_edad));
            ps.setString(5, _correo);
            ps.setString(6, _direccion);
            ps.setString(7, _condicion);
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("Apoderado no existe!");            
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
