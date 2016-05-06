use master
go
CREATE DATABASE IntranetUPC
go
use IntranetUPC
go

create table Administrador(IDAdministrador varchar(30)not null,Pass varchar(30),Nombre varchar(30),Apellido varchar(30),Correo varchar(30))
create table Apoderado(IDApoderado varchar(30)not null,Pass varchar(30),Nombre varchar(30),Apellido varchar(30),DNI int,Edad int,Correo varchar(30),Direccion varchar(30),Condicion varchar(30));
create table Categoria(IDCategoria varchar(30)not null ,Monto decimal(18,2));--definido x el sistema
create table Alumno(IDAlumno varchar(30) not null,Pass varchar(30),Nombre varchar(30),Apellido varchar(30),DNI int,Edad int,Correo varchar(30),Direccion varchar(30),IDCategoria varchar(30),IDApoderado varchar(30))
create table Ciclo(IDCiclo varchar(30) not null,IDAlumno varchar(30) not null,Boleta1 bit,Boleta2 bit,Boleta3 bit)
create table Incidencia(IDIncidencia varchar(30) not null,Asunto varchar(100),IDAlumno varchar(30),IDProfesor varchar(30))--allow nulls
create table Recurso(IDRecurso varchar(30)not null,NombreRecurso varchar(30),FechaPedido date,CantidadHoras int,Reservado bit,IDAlumno varchar(30),IDProfesor varchar(30))--allow nulls
create table Profesor(IDProfesor varchar(30)not null,Pass varchar(30),Nombre varchar(30),Apellido varchar(30),DNI int,Edad int,Correo varchar(30),Direccion varchar(30),Sueldo decimal(18,2))
create table Curso(IDCurso varchar(30) not null,CicloDeCurso int,MaxInasistencia int,IDProfesor varchar(30))
create table Seccion(IDSecclase varchar(30) not null,IDSeccion varchar(30),IDAlumno varchar(30),IDCurso varchar(30),PC1 decimal(10,2),PC2 decimal(10,2),EP decimal(10,2),EF decimal(10,2),Retirado bit,Inasistencias int,Delegado bit)
create table Sec_Clase(IDClase varchar(30)not null,IDSecclase varchar(30)not null,Dia varchar(30),HoraIni time(0),HoraFin time(0))
create table Documento(IDDocumento varchar(30) not null,IDCurso varchar(30)not null,NomDocumento varchar(30),Documento varbinary(MAX))

alter table Administrador add constraint PK_Administrador primary key(IDAdministrador)
alter table Apoderado add constraint PK_Apoderado primary key(IDApoderado)
alter table Categoria add constraint PK_Categoria primary key(IDCategoria)
alter table Alumno add constraint PK_Alumno primary key(IDAlumno)
alter table Ciclo add constraint PK_Ciclo primary key(IDCiclo,IDAlumno)
alter table Incidencia add constraint PK_Incidencia primary key(IDIncidencia)
alter table Recurso add constraint PK_Recurso primary key(IDRecurso)
alter table Profesor add constraint PK_Profesor primary key(IDProfesor)
alter table Curso add constraint PK_Curso primary key(IDCurso)
alter table Seccion add constraint PK_Seccion primary key(IDSecclase)
alter table Sec_Clase add constraint PK_SecClase primary key(IDClase,IDSecclase)
alter table Documento add constraint PK_Documento primary key(IDDocumento,IDCurso)

---FKs
alter table Alumno add constraint FK_Alumno_Categoria  foreign key(IDCategoria) references Categoria(IDCategoria)
alter table Alumno add constraint FK_Alumno_Apoderado foreign key(IDApoderado)references Apoderado(IDApoderado)

alter table Ciclo add constraint FK_Ciclo_Alumno foreign key(IDAlumno) references Alumno(IDAlumno)

alter table Incidencia add constraint FK_Incidencia_Alumno foreign key(IDAlumno) references Alumno(IDAlumno)
alter table Incidencia add constraint FK_Incidencia_Profesor foreign key(IDProfesor) references Profesor(IDProfesor)

alter table Curso add constraint FK_Curso_Profesor foreign key(IDProfesor)references Profesor(IDPRofesor)

alter table Recurso add constraint FK_Recurso_Alumno foreign key(IDAlumno) references Alumno(IDAlumno)
alter table Recurso add constraint FK_Recurso_Profesor foreign key(IDProfesor) references Profesor(IDProfesor)

alter table Seccion add constraint FK_Seccion_Alumno foreign key(IDAlumno) references Alumno(IDAlumno)
alter table Seccion add constraint FK_Seccion_Curso foreign key(IDCurso) references Curso(IDCurso)

alter table Sec_Clase add constraint FK_SecClase_Sec foreign key(IDSecclase)references Seccion(IDSecclase)

alter table Documento add constraint FK_Documento_Curso foreign key(IDCurso) references Curso(IDCurso)

USE [master]
CREATE LOGIN [AdminEvolucion] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[IntranetUPC], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
EXEC master..sp_addsrvrolemember @loginame = N'AdminEvolucion', @rolename = N'sysadmin'
GO 