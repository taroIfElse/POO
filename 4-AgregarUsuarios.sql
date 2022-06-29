
insert into Usuarios (Nombre, Email, Dni, Contraseña, Perfil_Id)
values (
	('admin'),
	('a@a.com'),
	('123456'),
	('admin'),
	(SELECT Id from Perfiles WHERE Perfiles.Nombre='Super Admin')
)