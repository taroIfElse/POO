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
    public partial class FormModificarUsuario : Form
    {
        public FormModificarUsuario(MODELO.Usuario usuario)
        {
            InitializeComponent();
            textBox1.Text = usuario.Perfil.Nombre;
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {

        }
        //agregar lógica para modificar al usuario. En el objeto usuario tenemos el id.
    }
}
