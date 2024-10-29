using Gestión_de_un_Hospital;
using Hospital;
using System.Collections.Generic;

 class HospitalCentral 
{
    public List<Medico> Medicos { get; set; }
    public List<Paciente> Pacientes { get; set; }
    public List<Cita> Citas { get; set; }

    public HospitalCentral()
    {
        Medicos = new List<Medico>();
        Pacientes = new List<Paciente>();
        Citas = new List<Cita>();
    }

    public void AgregarMedico(Medico medico)
    {
        Medicos.Add(medico);
    }

    public void AgregarPaciente(Paciente paciente)
    {
        Pacientes.Add(paciente);
    }

    public void AgregarCita(Cita cita)
    {
        Citas.Add(cita);
    }
}
