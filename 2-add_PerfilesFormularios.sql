INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios')
);
