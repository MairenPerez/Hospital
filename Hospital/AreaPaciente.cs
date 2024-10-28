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
            Areas gestionHospital = new Areas();
            gestionHospital.Show();
            this.Hide();
        }
    }
}
