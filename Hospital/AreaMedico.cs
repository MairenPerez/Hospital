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
    public partial class AreaMedico : Form
    {
        public AreaMedico()
        {
            InitializeComponent();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txtNombreMedico.Text = "";
            txtApellidosMedico.Text = "";
            txtTelefonoMedico.Text = "";
            rdButonHombreMed.Checked = false;
            rdButtonMujerMed.Checked = false;
            txtSalarioMedico.Text = "";
        }

        private void btnVolverAreas_Click(object sender, EventArgs e)
        {
            Areas gestionHospital = new Areas();
            gestionHospital.Show();
            this.Hide();
        }
    }
}
