use EJEMPLOBD

select * from Usuarios
go
select * from Perfiles
go
select * from Formularios
go
select * from Permisos
go

select 
	FormularioPermiso.Formulario_Id,
	Formularios.NombreSistema,
	FormularioPermiso.Permiso_Id,
	Permisos.Nombre 
	from FormularioPermiso 
	INNER JOIN Formularios ON Formularios.Id=Formulario_Id 
	INNER JOIN Permisos ON Permisos.Id=Permiso_Id;

go
select 
	PerfilFormulario.Perfil_Id,
	Perfiles.Nombre,
	PerfilFormulario.Formulario_Id,
	Formularios.NombreSistema
	from PerfilFormulario 
	INNER JOIN Perfiles ON Perfiles.Id=Perfil_Id 
	INNER JOIN Formularios ON Formularios.Id=Formulario_Id; 