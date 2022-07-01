INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios')
);
INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formUsuario')
);
INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'listarClientesToolStripMenuItem')
);

INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Super Admin'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'agregarToolStripMenuItem')
);

/*USER NORMAL*/

INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Cliente'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'agregarToolStripMenuItem')
);
INSERT INTO PerfilFormulario (Perfil_Id, Formulario_Id)
values (
	(SELECT Id FROM Perfiles WHERE Nombre = 'Cliente'),
	(SELECT Id FROM Formularios WHERE NombreSistema = 'listarClientesToolStripMenuItem')
);