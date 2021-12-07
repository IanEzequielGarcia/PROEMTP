using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public enum ObraSocial { NoTiene, CoberturaBasica, CobreturaCompleta};
    public class Paciente : Persona
    {
        public int Dni { get; set; }
        public int Edad { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public Paciente(int dni, string nombre, string apellido, int edad, ObraSocial obraSocial) : base(nombre, apellido)
        {
            this.Dni = dni;
            this.Edad = edad;
            this.ObraSocial = obraSocial;
        }
        public override string ToString()
        {
            return base.ToString() + $", DNI:{this.Dni}, Edad:{this.Edad}, {this.ObraSocial.ToString()}";
        }

        public static explicit operator string(Paciente paciente)
        {
            return paciente.ToString();
        }
    }
}
