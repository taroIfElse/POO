﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class SingletonContexto
    {
        private static SingletonContexto _instancia;
        private static ContextoContainer _contexto;

        private SingletonContexto() { }

        public static SingletonContexto obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonContexto();
                //esto hace referencia a el contexto de la bd(entity framework) usar siemrpe el mismo contexto de la bd
                _contexto = new ContextoContainer();
            }
            return _instancia;
        }

        public ContextoContainer Contexto
        {
            get { return _contexto; }
        }
    }
}
