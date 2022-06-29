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
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            try
            {

                List<MODELO.Usuario> listaUsuarios = CONTROLADORA.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
                List<MODELO.Usuario> listaClientes = listaUsuarios.FindAll(u => u.Perfil.Nombre == "Cliente");
                dgvListaClientes.DataSource = listaClientes;
                dgvListaClientes.Columns["Contraseña"].Visible = false;
                 
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar los usuario" + Ex.Message);
                //Para cerrar el form cuando hay un error
                //this.Close();
            }
        }
    }
}
