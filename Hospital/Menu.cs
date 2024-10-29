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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            Areas areas = new Areas();
            areas.Show();
            this.Hide();
        }

        private void btnGestionHospital_Click(object sender, EventArgs e)
        {
            GestionHospital gestionHospital = new GestionHospital();
            gestionHospital.Show();
            this.Hide();
        }
    }
}
