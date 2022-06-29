using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADORA;

namespace VISTA
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //TODO: validar inputs (podría ser en text change, depende de ustedes)



            string nombre = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string email = txtUsuario.Text;
            string DNI = txtDni.Text;
            List<Perfil> listaPerfiles = ControladoraPerfiles.obtener_instancia().Listar_Perfiles();
            Perfil cliente = listaPerfiles.Find(p => p.Nombre == "Cliente");

            //ver si se puede usar el consctructor de Usuario directamente.
            Usuario u = new Usuario();

            u.Nombre = nombre;
            u.Contraseña = contraseña;
            u.Email = email;
            u.Dni = DNI;
            u.Perfil = cliente;

            ControladoraUsuarios.obtener_instancia().Agregar_Usuario_Actual(u);
            ControladoraUsuarios.obtener_instancia().Agregar_Usuario(u);

            Form1 app = new Form1();
            app.Show();

        }
    }
}
