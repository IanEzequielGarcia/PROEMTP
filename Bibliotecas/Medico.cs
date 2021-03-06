using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public List<Paciente> listaEspera;
        public Medico(string nombre, string apellido,string especialidad):base(nombre,apellido)
        {
                this.listaEspera = new List<Paciente>();
                this.Especialidad = especialidad;
        }
        public override string ToString()
        {
            return base.ToString() + $", {this.Especialidad}";
        }
        public static explicit operator string(Medico med)
        {
            return med.ToString();
        }
    }
}
