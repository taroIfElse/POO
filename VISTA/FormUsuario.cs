using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MODELO.Usuario usuario = new MODELO.Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Dni = txtDni.Text;
            usuario.Email = txtEmail.Text;
            usuario.Contraseña = "asd";
            usuario.Perfil = (MODELO.Perfil)cmbPerfiles.SelectedValue;
            CONTROLADORA.ControladoraUsuarios.obtener_instancia().Agregar_Usuario(usuario);
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //List<MODELO.Perfil> lista = new List<MODELO.Perfil>();
            //MODELO.Perfil admin = new MODELO.Perfil();
            //admin.Nombre = "Admin";

            //List<MODELO.Permiso> listaPermisosAdmin = new List<MODELO.Permiso>();
            //MODELO.Permiso permisoAdmin = new MODELO.Permiso();
            //permisoAdmin.Nombre = "Agregar";
            //permisoAdmin.NombreSistema = "btnAgregar";
            //listaPermisosAdmin.Add(permisoAdmin);

            //List<MODELO.Formulario> forms = new List<MODELO.Formulario>();
            //MODELO.Formulario formGestionarUsuario = new MODELO.Formulario();
            //formGestionarUsuario.Nombre = "Gestionar Usuarios";
            //formGestionarUsuario.NombreSistema = "formGestionarUsuario";
            //formGestionarUsuario.Permiso = listaPermisosAdmin;

            //List<MODELO.Formulario> listaFormuariosAdmin = new List<MODELO.Formulario>();
            //listaFormuariosAdmin.Add(formGestionarUsuario);
            //admin.Formulario = listaFormuariosAdmin;

            //lista.Add(admin);

            //CONTROLADORA.ControladoraPerfiles.obtener_instancia().Llenar_Lista_Perfiles(lista);
            cmbPerfiles.DataSource = CONTROLADORA.ControladoraPerfiles.obtener_instancia().Listar_Perfiles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
