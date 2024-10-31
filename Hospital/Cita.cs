using Gestión_de_un_Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Motivo { get; set; }
        public EstadoCita Estado { get; set; }
        public Paciente Paciente2 { get; }
        public Medico Medico2 { get; }

        public enum EstadoCita
        {
            Pendiente,
            Realizada,
            Cancelada
        }

        public Cita(int idCita, DateTime fechaHora, string paciente, string medico, string motivo)
        {
            IdCita = idCita;
            FechaHora = fechaHora;
            Paciente = paciente;
            Medico = medico;
            Motivo = motivo;
            Estado = EstadoCita.Pendiente;
        }

        public Cita(DateTime now, string v1, string v2, string v3, string v4)
        {
            FechaHora = now;
            Paciente = v1;
            Medico = v2;
            Motivo = v3;
            Estado = EstadoCita.Pendiente;
        }

        public Cita(DateTime now, Paciente paciente2, Medico medico2)
        {
            FechaHora = now;
            Paciente2 = paciente2;
            Medico2 = medico2;
            Estado = EstadoCita.Pendiente;
        }

        public void CancelarCita()
        {
            Estado = EstadoCita.Cancelada;
        }

        public void ModificarCita(DateTime nuevaFechaHora, string motivoNuevo)
        {
            FechaHora = nuevaFechaHora;
            Motivo = motivoNuevo;
        }

        public override string ToString()
        {
            return $"Cita: {IdCita}, Fecha: {FechaHora}, Paciente: {Paciente}, Medico: {Medico}, Motivo: {Motivo}, Estado: {Estado}";
        }
    }
}
