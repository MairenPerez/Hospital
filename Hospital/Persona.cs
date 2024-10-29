using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string apellidos, string sexo, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Persona: {Nombre} {Apellidos}, Sexo: {Sexo}, Telefono: {Telefono}";
        }
    }
}


