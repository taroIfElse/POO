using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraFormularios
    {
        private static ControladoraFormularios _instancia;

        private ControladoraFormularios() { }

        public static ControladoraFormularios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraFormularios();
            }
            return _instancia;
        }


        public List<MODELO.Formulario> Listar_Formularios(MODELO.Usuario usuarioActual)
        {
            return usuarioActual.Perfil.Formulario.ToList();
        }
    }
}
