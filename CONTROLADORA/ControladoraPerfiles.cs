using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraPerfiles
    {
        private static ControladoraPerfiles _instancia;

        private ControladoraPerfiles() { }

        public static ControladoraPerfiles obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraPerfiles();
            }
            return _instancia;
        }

        public List<MODELO.Perfil> Listar_Perfiles()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Perfiles.ToList();
        }

        public void Llenar_Lista_Perfiles(List<MODELO.Perfil> perfiles)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.Perfiles.AddRange(perfiles);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
