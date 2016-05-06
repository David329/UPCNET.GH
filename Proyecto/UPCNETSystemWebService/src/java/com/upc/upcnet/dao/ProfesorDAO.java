/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.entidades.Profesor;
import java.util.ArrayList;
import java.util.List;
import com.upc.upcnet.BD.AccesoDB;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author Petith
 */
public class ProfesorDAO {
    
    public List<Profesor> getProfesores(){
        List<Profesor> profesores = new ArrayList<>();
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDProfesor, Nombre, Apellido, DNI, Edad, Correo, Direccion, Sueldo FROM Profesor");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Profesor p = new Profesor();
                p.setIdProfesor(rs.getString("IDProfesor"));
                p.setNombre(rs.getString("Nombre"));
                p.setApellido(rs.getString("Apellido"));
                p.setDni(rs.getInt("DNI"));
                p.setEdad(rs.getInt("Edad"));
                p.setCorreo(rs.getString("Correo"));
                p.setDireccion(rs.getString("Direccion"));
                p.setSueldo(rs.getDouble("Sueldo"));
                
                profesores.add(p);
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
        return profesores;
    }
    
    public void setProfesor(String _idProfesor, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _sueldo){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Profesor WHERE IDProfesor = ?");
             PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idProfesor);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El codigo del profesor ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Profesor(IDProfesor, Nombre, Apellido, DNI, Edad, Correo, Direccion, Sueldo) VALUES(?, ?, ?, ?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idProfesor);
            ps.setString(2, _nombre);
            ps.setString(3, _apellido);
            ps.setInt(4, Integer.parseInt(_dni));
            ps.setInt(5, Integer.parseInt(_edad));
            ps.setString(6, _correo);
            ps.setString(7, _direccion);
            ps.setDouble(8, Double.parseDouble(_sueldo));
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
    
    public void editProfesor(String _idProfesor, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _sueldo){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Profesor SET Nombre = ?, Apellido = ?, DNI = ?, Edad = ?, Correo = ?, Direccion = ?, Sueldo = ? WHERE IDProfesor = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _nombre);
            ps.setString(2, _apellido);
            ps.setInt(3, Integer.parseInt(_dni));
            ps.setInt(4, Integer.parseInt(_edad));
            ps.setString(5, _correo);
            ps.setString(6, _direccion);
            ps.setDouble(7, Double.parseDouble(_sueldo));
            ps.setString(8, _idProfesor);
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("Profesor no existe!"); 
            
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
