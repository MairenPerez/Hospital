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
        private HospitalCentral hospitalCentral;
        private GestionHospital ge;

        // Constructor que recibe la instancia de HospitalCentral
        public AreaPaciente(HospitalCentral hospitalCentral, GestionHospital ge)
        {
            InitializeComponent();
            this.hospitalCentral = hospitalCentral;
            this.ge = ge;
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el nuevo paciente con los datos del formulario
                Paciente newPaciente = new Paciente(
                    txtNomPaciente.Text,
                    txtApellidosPaciente.Text,
                    rdButonHombre.Checked ? "Hombre" : "Mujer",
                    txtTelefono.Text,
                    txtHistoriaCli.Text,
                    txtDiagnostico.Text,
                    txtTratamiento.Text
                );

                // Agregar el paciente a la lista en HospitalCentral
                hospitalCentral.AgregarPaciente(newPaciente);

                // Confirmar la acción al usuario
                MessageBox.Show("Paciente agregado correctamente");

                // Cerrar el formulario de creación de paciente
                this.Close();
                ge.CargarListaPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar paciente: " + ex.Message);
            }
        }
    }
}
