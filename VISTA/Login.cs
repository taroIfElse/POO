using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADORA;
using MODELO;

namespace VISTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validar inputs (podría ser en text change, depende de ustedes)

            List<Usuario> listaUsuarios = ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            Usuario usuario = listaUsuarios.Find(u => (u.Nombre == txtUsuario.Text || u.Email == txtUsuario.Text) && u.Contraseña == txtContraseña.Text);
            if (usuario != null)
            {
                ControladoraUsuarios.obtener_instancia().Agregar_Usuario_Actual(usuario);
                Form1 app = new Form1();
                app.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }

        }
    }
}
