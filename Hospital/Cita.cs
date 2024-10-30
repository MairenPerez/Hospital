using Gestión_de_un_Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Cita 
    {
        private DateTime now;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        internal object FechaCita;

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
            this.now = now;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public Cita(DateTime now, Paciente paciente2, Medico medico2)
        {
            this.now = now;
            Paciente2 = paciente2;
            Medico2 = medico2;
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
