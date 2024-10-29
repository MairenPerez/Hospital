using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Cita 
    {
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Motivo { get; set; }
        public EstadoCita Estado { get; set; }

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
