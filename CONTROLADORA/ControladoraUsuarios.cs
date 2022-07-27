using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios _instancia;
        public MODELO.Usuario usuarioActual = null;//el usuario al principio es vacio

        private ControladoraUsuarios() { }

        public static ControladoraUsuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraUsuarios();
            }
            return _instancia;
        }

        public List<MODELO.Usuario> Listar_Usuarios()
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.ToList();
        }

        public void Agregar_Usuario(MODELO.Usuario usuario)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.Add(usuario);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Usuario(MODELO.Usuario usuario)
        {
            MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.Remove(usuario);
            MODELO.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
        public MODELO.Usuario Obtener_Usuario(int CODIGO)
        {
            return MODELO.SingletonContexto.obtener_instancia().Contexto.Usuarios.Find(CODIGO);
        }

        public void Agregar_Usuario_Actual(MODELO.Usuario usuario)
        {
            usuarioActual = usuario;
        }
    }
}
