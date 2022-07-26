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
            usuario.Contraseña = CONTROLADORA.Crypto.GetSHA256(ContraseñaText.Text);
            usuario.Perfil = (MODELO.Perfil)cmbPerfiles.SelectedValue;
            CONTROLADORA.ControladoraUsuarios.obtener_instancia().Agregar_Usuario(usuario);
            this.Close();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

            List<MODELO.Perfil> perfiles = CONTROLADORA.ControladoraPerfiles.obtener_instancia().Listar_Perfiles();
            cmbPerfiles.DataSource = perfiles.Where(p => p.Id == 31).ToList();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
