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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Lo llevamos a un nuevo formulario a GestionHospital
            GestionHospital gestionHospital = new GestionHospital();
            gestionHospital.Show();
            this.Hide();

        }
    }
}
