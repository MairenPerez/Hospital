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
    public partial class AreaPersonalAdm : Form
    {
        public AreaPersonalAdm()
        {
            InitializeComponent();
        }

        private void btGuardarPersonalAdm_Click(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txtNomPersonalAdm.Text = "";
            txtApellidosPersonalAdm.Text = "";
            txtSalarioPersonalAdm.Text = "";
            listBoxDepartamento.Items.Clear();
        }

        private void btnVolverAreas_Click(object sender, EventArgs e)
        {
            Areas gestionHospital = new Areas();
            gestionHospital.Show();
            this.Hide();
        }
    }
}
