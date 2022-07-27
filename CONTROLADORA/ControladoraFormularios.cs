using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{ //CLASE
    public class ControladoraFormularios
    {
        private static ControladoraFormularios _instancia;

        private ControladoraFormularios() { } //CONSTRUCTOR

        public static ControladoraFormularios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraFormularios(); // INSTANCIA DE CONSTRUCTOR
            }
            return _instancia;
        }


        public List<MODELO.Formulario> Listar_Formularios(MODELO.Usuario usuarioActual)
        {
            return usuarioActual.Perfil.Formulario.ToList();
        }
    }
}
