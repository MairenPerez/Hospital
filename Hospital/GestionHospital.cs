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

        public GestionHospital()
        {
            InitializeComponent();
            hospitalCentral = new HospitalCentral();
            Pestanas.SelectedIndexChanged += new EventHandler(Pestanas_SelectedIndexChanged);

            // Configurar columnas de cada ListView
            ConfigurarListViewMedicos();
            ConfigurarListViewPacientes();
            ConfigurarListViewCitas();

            // Cargar datos de prueba en el HospitalCentral
            CargarDatosPrueba();
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

        // Cargar algunos datos de prueba en el hospital
        private void CargarDatosPrueba()
        {
            hospitalCentral.AgregarMedico(new Medico("Juan", "Perez", "Masculino", "123456789", "Cardiología", 12345, 50000));
            hospitalCentral.AgregarMedico(new Medico("Maria", "Lopez", "Femenino", "987654321", "Neurología", 67890, 60000));

            hospitalCentral.AgregarPaciente(new Paciente("Ana", "Gomez", "Femenino", "111222333"));
            hospitalCentral.AgregarPaciente(new Paciente("Luis", "Martinez", "Masculino", "444555666"));

            hospitalCentral.AgregarCita(new Cita(DateTime.Now, "Ana Gomez", "Juan Perez", "Consulta general", "Programada"));
            hospitalCentral.AgregarCita(new Cita(DateTime.Now.AddHours(2), "Luis Martinez", "Maria Lopez", "Revisión", "Completada"));
        }

        private void btAñadirMedico_Click(object sender, EventArgs e)
        {
            AreaMedico areaMedico = new AreaMedico();
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
            else if (Pestanas.SelectedTab == ListadoHospital)
            {
                CargarListaCitas();
            }
        }

        // Método para cargar la lista de médicos
        private void CargarListaMedicos()
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

        // Método para cargar la lista de pacientes
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

        // Método para cargar la lista de citas
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
    }
}
