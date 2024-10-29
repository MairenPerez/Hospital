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

        private void btAñadirMedico_Click(object sender, EventArgs e)
        {
            AreaMedico areaMedico = new AreaMedico();
            areaMedico.Show();
        }

        private void btEliminarMedico_Click(object sender, EventArgs e)
        {
            // Eliminamos el medico seleccionado de la lista
            if (listViewMedicos.SelectedItems.Count > 0)
            {
                listViewMedicos.Items.Remove(listViewMedicos.SelectedItems[0]);
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btAgregarPacienteList_Click(object sender, EventArgs e)
        {
            AreaPaciente areaPaciente = new AreaPaciente();
            areaPaciente.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Añadimos columnas Nombre, Especialidad y pacientes
            listViewMedicos.Columns.Add("Nombre", 100);
            listViewMedicos.Columns.Add("Especialidad", 100);
            listViewMedicos.Columns.Add("Pacientes", 100);

            // Añadimos los medicos a la lista
            ListViewItem item1 = new ListViewItem("Dr. House", 0);
            item1.SubItems.Add("Oncologo");
            item1.SubItems.Add("10");
            ListViewItem item2 = new ListViewItem("Dr. Cuddy", 1);
            item2.SubItems.Add("Cardiologo");
            item2.SubItems.Add("5");
            ListViewItem item3 = new ListViewItem("Dr. Chase", 2);
            item3.SubItems.Add("Neurologo");
            item3.SubItems.Add("3");
            ListViewItem item4 = new ListViewItem(
                new string[] { "Dr. Foreman", "Traumatologo", "7" }, 3);
            listViewMedicos.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });
        }
    }
}
