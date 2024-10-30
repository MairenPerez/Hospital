using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AreaPaciente : Form
    {
        public AreaPaciente()
        {
            InitializeComponent();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            // Limpiamos los campos
            txtHistoriaCli.Text = "";
            txtNomPaciente.Text = "";
            txtApellidosPaciente.Text = "";
            txtTelefono.Text = "";
            rdButonHombre.Checked = false;
            rdButtonMujer.Checked = false;
            txtDiagnostico.Text = "";
            txtTratamiento.Text = "";
        }

        private void btnVolverAreas_Click(object sender, EventArgs e)
        {
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Guardamos el paciente y lo añadimos a la lsita de pacientes
            Paciente newPaciente = new Paciente(
                txtNomPaciente.Text,
                txtApellidosPaciente.Text,
                rdButonHombre.Checked ? "Hombre" : "Mujer",
                txtTelefono.Text,
                txtHistoriaCli.Text,
                txtDiagnostico.Text,
                txtTratamiento.Text
                );

            // Enviamos un mensaje si  se ha agregado correctamente el paciente a la lista
            MessageBox.Show("Paciente agregado correctamente");

            this.Close();
            AreaPaciente areaPaciente = new AreaPaciente();
            areaPaciente.Show();

            // Añadimos el paciente a la lista de pacientes
            GestionHospital.Pacientes.Add(newPaciente);
        }
    }
}
