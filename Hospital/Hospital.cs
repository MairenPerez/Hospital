using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class HospitalCentral
    {
        public List<Paciente> Pacientes { get; set; }
        public List<Medico> Medicos { get; set; }
        public List<Cita> Citas { get; set; }
        public List<PersonalAdministrativo> PersonalAdministrativo { get; set; }

        public HospitalCentral()
        {
            Pacientes = new List<Paciente>();
            Medicos = new List<Medico>();
            Citas = new List<Cita>();
            PersonalAdministrativo = new List<PersonalAdministrativo>();
        }

        public void AgregarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        public void AgregarMedico(Medico medico)
        {
            Medicos.Add(medico);
        }

        public void AgregarCita(Cita cita)
        {
            Citas.Add(cita);
        }

        public void AgregarPersonalAdministrativo(PersonalAdministrativo personal)
        {
            PersonalAdministrativo.Add(personal);
        }

        public void CancelarCita(int idCita)
        {
            Cita cita = Citas.Find(c => c.IdCita == idCita);
            if (cita != null)
            {
                cita.CancelarCita();
            }
        }

        public void ModificarCita(int idCita, DateTime nuevaFechaHora, string motivoNuevo)
        {
            Cita cita = Citas.Find(c => c.IdCita == idCita);
            if (cita != null)
            {
                cita.ModificarCita(nuevaFechaHora, motivoNuevo);
            }
        }

        public void DarAltaPaciente(string numHistoriaClinica, DateTime fechaAlta)
        {
            Paciente paciente = Pacientes.Find(p => p.NumHistoriaClinica == numHistoriaClinica);
            if (paciente != null)
            {
                paciente.FechaAlta = fechaAlta;
            }
        }

        public void AsignarMedicoAPaciente(string numHistoriaClinica, Medico medico)
        {
            Paciente paciente = Pacientes.Find(p => p.NumHistoriaClinica == numHistoriaClinica);
            if (paciente != null)
            {
                paciente.MedicoAsignado = medico;
            }
        }

        public List<Paciente> ObtenerPacientesPorMedico(Medico medico)
        {
            return Pacientes.FindAll(AreaPaciente => AreaPaciente.MedicoAsignado == medico);
        }
    }
}

