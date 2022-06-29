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
    public partial class FormGestionarUsuarios : Form
    {
        private int selectedIndex = 0;
        public FormGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormUsuario form = new FormUsuario();
            form.Show();
        }

        private void FormGestionarUsuarios_Load(object sender, EventArgs e)
        {
            MODELO.Usuario usuarioActual = CONTROLADORA.ControladoraUsuarios.obtener_instancia().usuarioActual;
            List<MODELO.Formulario> formularios = CONTROLADORA.ControladoraFormularios.obtener_instancia().Listar_Formularios(usuarioActual);
            MODELO.Formulario thisFormulario = formularios.Find(f => f.NombreSistema == "formGestionarUsuarios");
            List<MODELO.Permiso> permisos = CONTROLADORA.ControladoraPermisos.obtener_instancia().Listar_Permisos(thisFormulario);
            permisos.ForEach(p =>
            {
                if (p.NombreSistema == "btnAgregar") btnAgregar.Enabled = true;
            });

            try
            {

                List<MODELO.Usuario> listaUsuarios = CONTROLADORA.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
                dgvGestionarUsuarios.DataSource = listaUsuarios;
              
            } catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar los usuario" + Ex.Message);
                //Para cerrar el form cuando hay un error
                //this.Close();
            }
        }

        private void dgvGestionarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MODELO.Usuario selected = dgvGestionarUsuarios.SelectedRows[0].DataBoundItem as MODELO.Usuario;
            CONTROLADORA.ControladoraUsuarios.obtener_instancia().Eliminar_Usuario(selected);
            dgvGestionarUsuarios.DataSource = null;
            List<MODELO.Usuario> listaUsuarios = CONTROLADORA.ControladoraUsuarios.obtener_instancia().Listar_Usuarios();
            dgvGestionarUsuarios.DataSource = listaUsuarios;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODELO.Usuario selected = dgvGestionarUsuarios.SelectedRows[0].DataBoundItem as MODELO.Usuario;

            int id = (Convert.ToInt32(dgvGestionarUsuarios.CurrentRow.Cells[0].Value));
            MODELO.Usuario selected = CONTROLADORA.ControladoraUsuarios.obtener_instancia().Obtener_Usuario(id); 
            //MODELO.Usuario selected = dgvGestionarUsuarios.SelectedRows[0].DataBoundItem as MODELO.Usuario;


            FormModificarUsuario form = new FormModificarUsuario(selected);
            form.Show();
        }
    }
}
