using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{ //Clase
    public class ControladoraFormularios //creo la clase
    {
        private static ControladoraFormularios _instancia; //declaro la variable nula "_instancia"

        private ControladoraFormularios() { } //CONSTRUCTOR

        public static ControladoraFormularios obtener_instancia() //15 a 22 singleton
        {
            if (_instancia == null)
            {
                _instancia = new ControladoraFormularios(); //INSTANCIA DE CONSTRUCTOR
            }
            return _instancia;
        }
        //SINGLETON:es un patron de diseño que resuelve un problema
        //Objetivo del singleton: siempre retornar una única instancia
        //_instancia: es el objeto a crear


        public List<MODELO.Formulario> Listar_Formularios(MODELO.Usuario usuarioActual)//funcion listar form le paso usuario
        {
            return usuarioActual.Perfil.Formulario.ToList();//devuelve los form que x user (que yo le paso como param) puede ver
        }
    }
}
