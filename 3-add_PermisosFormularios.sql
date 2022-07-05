INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id)
values (
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios'),
	(SELECT Id FROM Permisos WHERE NombreSistema = 'btnAgregar')
);
INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id)
values (
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios'),
	(SELECT Id FROM Permisos WHERE NombreSistema = 'btnEliminar')
);
INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id)
values (
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios'),
	(SELECT Id FROM Permisos WHERE NombreSistema = 'btnModificar')
);
INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id)
values (
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios'),
	(SELECT Id FROM Permisos WHERE NombreSistema = 'btnCancelar')
);
INSERT INTO FormularioPermiso (Formulario_Id, Permiso_Id)
values (
	(SELECT Id FROM Formularios WHERE NombreSistema = 'formGestionarUsuarios'),
	(SELECT Id FROM Permisos WHERE NombreSistema = 'btnGuardar')
);


