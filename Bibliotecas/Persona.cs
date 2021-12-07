using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Ocupado { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ocupado = false;
        }
        public override string ToString()
        {
            return $"{this.Nombre}, {this.Apellido}, {(this.Ocupado == true ? "Ocupado" : "Libre")}";
        }
    }
}
