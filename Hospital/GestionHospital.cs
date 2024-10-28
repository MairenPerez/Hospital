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
    public partial class GestionHospital : Form
    {
        public GestionHospital()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            // Llevamos al formulario de Paciente
            AreaPaciente areaPaciente = new AreaPaciente();
            areaPaciente.Show();
            this.Hide();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            AreaMedico areaMedico = new AreaMedico();
            areaMedico.Show();
            this.Hide();
        }

        private void btnPersAdm_Click(object sender, EventArgs e)
        {
            AreaPersonalAdm areaPersonalAdm = new AreaPersonalAdm();
            areaPersonalAdm.Show();
            this.Hide();
        }
    }
}
