using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class ListaPersonas<T> where T : Persona
    {
        protected List<T> personas;
        public List<T> Elementos { get { return this.personas; } }
        public ListaPersonas()
        {
            this.personas = new List<T>();
        }
        public static ListaPersonas<T> operator +(ListaPersonas<T> objetos, T objeto)
        {
            if (objeto != null)
            {
                objetos.personas.Add((T)objeto);
            }
            return objetos;
        }
        public static ListaPersonas<T> operator -(ListaPersonas<T> objetos, T objeto)
        {
            if (objeto != null)
            {
                objetos.personas.Remove((T)objeto);
            }
            return objetos;
        }
    }
}
