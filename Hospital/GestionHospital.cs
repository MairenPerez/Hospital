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
    public partial class GestionHospital : Form
    {
        private HospitalCentral hospitalCentral;
        internal static List<Medico> Medicos = new List<Medico>();
        internal static List<Paciente> Pacientes = new List<Paciente>();

        public TabPage ListaCitas { get; private set; }

        public GestionHospital()
        {
            InitializeComponent();
            hospitalCentral = new HospitalCentral();
            Pestanas.SelectedIndexChanged += new EventHandler(Pestanas_SelectedIndexChanged);

            // Configurar columnas de cada ListView
            ConfigurarListViewMedicos();
            ConfigurarListViewPacientes();
            ConfigurarListViewCitas();
        } 

        // Configurar columnas para la lista de médicos
        private void ConfigurarListViewMedicos()
        {
            listViewMedicos.View = View.Details;
            listViewMedicos.Columns.Add("Nombre", 100);
            listViewMedicos.Columns.Add("Apellidos", 100);
            listViewMedicos.Columns.Add("Especialidad", 100);
            listViewMedicos.Columns.Add("Telefono", 100);
        }

        // Configurar columnas para la lista de pacientes
        private void ConfigurarListViewPacientes()
        {
            listViewPacientes.View = View.Details;
            listViewPacientes.Columns.Add("Nombre", 100);
            listViewPacientes.Columns.Add("Apellidos", 100);
            listViewPacientes.Columns.Add("Sexo", 100);
            listViewPacientes.Columns.Add("Telefono", 100);
        }

        // Configurar columnas para la lista de citas
        private void ConfigurarListViewCitas()
        {
            listViewCitas.View = View.Details;
            listViewCitas.Columns.Add("Fecha y Hora", 100);
            listViewCitas.Columns.Add("Paciente", 100);
            listViewCitas.Columns.Add("Médico", 100);
            listViewCitas.Columns.Add("Motivo", 100);
            listViewCitas.Columns.Add("Estado", 100);
        }

        private void btAñadirMedico_Click(object sender, EventArgs e)
        {
            AreaMedico areaMedico = new AreaMedico(hospitalCentral, this );
            areaMedico.Show();
        }


        private void btEliminarMedico_Click(object sender, EventArgs e)
        {
            // Eliminamos el médico seleccionado de la lista
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


        private void Pestanas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pestanas.SelectedTab == ListaMedicos)
            {
                CargarListaMedicos();
            }
            else if (Pestanas.SelectedTab == ListaPacientes)
            {
                CargarListaPacientes();
            }
            else if (Pestanas.SelectedTab == ListaCitas)
            {
                CargarListaCitas();
            }
        }
      
        public void CargarListaMedicos()
        {
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

        private void CargarListaPacientes()
        {
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

        private void CargarListaCitas()
        {
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
        private void AreaMedico_MedicoAgregado(object sender, Medico e)
        {

            ListViewItem item = new ListViewItem(e.Nombre);
            item.SubItems.Add(e.Apellidos);
            item.SubItems.Add(e.Especialidad);
            item.SubItems.Add(e.Telefono);
            listViewMedicos.Items.Add(item);
            hospitalCentral.AgregarMedico(e);
        }
    }
}
