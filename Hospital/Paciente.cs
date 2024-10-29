using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente : Persona
    {
        public string NumHistoriaClinica { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public Medico MedicoAsignado { get; set; }

        public Paciente(string nombre, string apellidos, string sexo, string telefono, string direccion, DateTime fechaNacimiento, string numeroHistoriaClinica, string diagnostico, string tratamiento, DateTime fechaIngreso, Medico medicoAsignado)
            : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numeroHistoriaClinica;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaIngreso = fechaIngreso;
            FechaAlta = null;
            MedicoAsignado = medicoAsignado;
        }

        public Paciente(string nombre, string apellidos, string sexo, string telefono, string numHistoriaClinica, DateTime fechaIngreso, string diagnostico, string tratamiento, DateTime? fechaAlta = null)
            : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numHistoriaClinica;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaIngreso = fechaIngreso;
            FechaAlta = fechaAlta;
        }

        public override string ToString()
        {
            return $"Paciente: {Nombre} {Apellidos}, NumHistoriaClinica: {NumHistoriaClinica}, Diagnostico: {Diagnostico}, Tratamiento: {Tratamiento}, FechaIngreso: {FechaIngreso}, FechaAlta: {FechaAlta}";
        }
    }
}
