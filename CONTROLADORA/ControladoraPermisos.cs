using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraPermisos
    {
        private static ControladoraPermisos _instancia;

        private ControladoraPermisos() { }

        public static ControladoraPermisos obtener_instancia()//singleton
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPermisos();
            }
            return _instancia;
        }

        public List<MODELO.Permiso> Listar_Permisos(MODELO.Formulario formulario)//funcion listar permisos en funcion a cada form
        {
            return formulario.Permiso.ToList();//lista los form en funcion a los permisos
        }
    }
}
