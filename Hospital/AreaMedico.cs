using Gestión_de_un_Hospital;
using System;
using System.Windows.Forms;

namespace Hospital
{
    internal partial class AreaMedico : Form
    {
        private HospitalCentral hospitalCentral;
        private GestionHospital ge;

        // Constructor que recibe la instancia de HospitalCentral
        public AreaMedico(HospitalCentral hospitalCentral, GestionHospital ge)
        {
            InitializeComponent();
            this.hospitalCentral = hospitalCentral;
            this.ge = ge;
        }

        public EventHandler<Medico> MedicoAgregado { get; internal set; }

        private void btAgregarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el nuevo médico con los datos del formulario
                Medico newMedico = new Medico(
                    txtNombreMedico.Text,
                    txtApellidosMedico.Text,
                    rdButonHombreMed.Checked ? "Hombre" : "Mujer",
                    txtTelefonoMedico.Text,
                    "Especialidad", // Asegúrate de tener un campo para la especialidad
                    123456, // Número de colegiado (puedes cambiarlo o obtenerlo de un campo si es necesario)
                    Convert.ToDouble(txtSalarioMedico.Text)
                );

                // Agregar el médico a la lista en HospitalCentral
                hospitalCentral.AgregarMedico(newMedico);

                // Confirmar la acción al usuario
                MessageBox.Show("Médico agregado correctamente");

                // Cerrar el formulario de creación de médico
                this.Close();
                ge.CargarListaMedicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar médico: " + ex.Message);
            }
        }
    }
}
