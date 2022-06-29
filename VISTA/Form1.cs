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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //traemos usuario actual
            MODELO.Usuario usuario = CONTROLADORA.ControladoraUsuarios.obtener_instancia().usuarioActual;
            
            //traemos los formularios de este usuario (ver metodo en controladora)
            List<MODELO.Formulario> formularios_habilitados = CONTROLADORA.ControladoraFormularios.obtener_instancia().Listar_Formularios(usuario);
            //por cada formulario
            formularios_habilitados.ForEach((formulario) =>
            {  
                //buscamos en el menuStrip la lista de opciones o la tab donde se encuentra este formulario
                var options = menuStrip1.Items.Find(formulario.NombreSistema, true);

                //iteramos sobre esta lista de opciones, por ejemplo: gestionar, listarClientes, etc en la tab Usuarios
                options.ToList().ForEach(option =>
                {
                    if (option.Name == formulario.NombreSistema)
                    {
                        option.Enabled = true;
                    }
                });
            });
        } 

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarUsuarios form = new FormGestionarUsuarios();
            form.Show(); 
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaClientes f = new FormListaClientes();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
