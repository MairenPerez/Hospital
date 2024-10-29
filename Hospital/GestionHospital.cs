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
        private HospitalCentral hospitalCentral;

        public GestionHospital()
        {
            InitializeComponent();
            hospitalCentral = new HospitalCentral();
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

        private void Pestanas_Click(object sender, EventArgs e)
        {
            if (Pestanas.SelectedTab == ListaMedicos)
            {
                // Mostramos la lista de medicos
                listViewMedicos.Items.Clear();
                foreach (Medico medico in hospitalCentral.Medicos)
                {
                    ListViewItem item = new ListViewItem(medico.Nombre);
                    item.SubItems.Add(medico.Apellidos);
                    item.SubItems.Add(medico.Especialidad);
                    item.SubItems.Add(medico.Telefono);
                    listViewMedicos.Items.Add(item);
                }
            }
            else if (Pestanas.SelectedTab == ListaPacientes)
            {
                // Mostramos la lista de pacientes
                listViewPacientes.Items.Clear();
                foreach (Paciente paciente in hospitalCentral.Pacientes)
                {
                    ListViewItem item = new ListViewItem(paciente.Nombre);
                    item.SubItems.Add(paciente.Apellidos);
                    item.SubItems.Add(paciente.Sexo);
                    item.SubItems.Add(paciente.Telefono);
                    listViewPacientes.Items.Add(item);
                }
            }
            else if (Pestanas.SelectedTab == ListadoHospital)
            {
                // Mostramos la lista de citas
                listViewCitas.Items.Clear();
                foreach (Cita cita in hospitalCentral.Citas)
                {
                    ListViewItem item = new ListViewItem(cita.FechaHora.ToString());
                    item.SubItems.Add(cita.Paciente);
                    item.SubItems.Add(cita.Medico);
                    item.SubItems.Add(cita.Motivo);
                    item.SubItems.Add(cita.Estado.ToString());
                    listViewCitas.Items.Add(item);
                }
            }
        }
    }
}
