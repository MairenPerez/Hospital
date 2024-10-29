using Gestión_de_un_Hospital;
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
    partial class AreaMedico : Form
    {
        public AreaMedico()
        {
            InitializeComponent();
        }

        public Medico Medico { get; set; }

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

        private void btAgregarMedico_Click(object sender, EventArgs e)
        {
            // Guarda el medico y se añade al listViewMedicos cuando el usuario clicka en la pestana de medicos
            //Medico medico = new Medico(txtNombreMedico.Text, txtApellidosMedico.Text, txtTelefonoMedico.Text, rdButonHombreMed.Checked ? Medico.Sexo.Hombre : Medico.Sexo.Mujer, Convert.ToDouble(txtSalarioMedico.Text));
        }
    }
}
