using Gestión_de_un_Hospital;
using System;

namespace Hospital
{
    public class Paciente : Persona
    {
        public string NumHistoriaClinica { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public Medico MedicoAsignado { get; set; }

        // Constructor completo con todos los parámetros, incluyendo MedicoAsignado
        public Paciente(string nombre, string apellidos, string sexo, string telefono, string direccion, DateTime fechaNacimiento, string numeroHistoriaClinica, string diagnostico, string tratamiento, DateTime fechaIngreso, Medico medicoAsignado = null)
            : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numeroHistoriaClinica;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaIngreso = fechaIngreso;
            FechaAlta = null;
            MedicoAsignado = medicoAsignado;
        }

        // Constructor alternativo sin médico asignado, con FechaAlta opcional
        public Paciente(string nombre, string apellidos, string sexo, string telefono, string numHistoriaClinica, DateTime fechaIngreso, string diagnostico, string tratamiento, DateTime? fechaAlta = null)
            : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numHistoriaClinica;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaIngreso = fechaIngreso;
            FechaAlta = fechaAlta;
            MedicoAsignado = null;  // MedicoAsignado puede ser nulo inicialmente
        }

        // Constructor para un paciente básico (sin datos de historia clínica)
        public Paciente(string nombre, string apellidos, string sexo, string telefono)
            : base(nombre, apellidos, sexo, telefono)
        {
            // Se inicializan los campos opcionales si se necesita una instancia básica
            NumHistoriaClinica = "";
            Diagnostico = "";
            Tratamiento = "";
            FechaIngreso = DateTime.MinValue;
            FechaAlta = null;
            MedicoAsignado = null;
        }

        // Método ToString para obtener una descripción del paciente
        public override string ToString()
        {
            return $"Paciente: {Nombre} {Apellidos}, NumHistoriaClinica: {NumHistoriaClinica}, Diagnostico: {Diagnostico}, Tratamiento: {Tratamiento}, FechaIngreso: {FechaIngreso}, FechaAlta: {(FechaAlta.HasValue ? FechaAlta.Value.ToString("d") : "No dada de alta")}, MedicoAsignado: {(MedicoAsignado != null ? MedicoAsignado.Nombre : "Sin médico asignado")}";
        }
    }
}
