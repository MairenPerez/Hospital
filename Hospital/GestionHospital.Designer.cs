namespace Hospital
{
    partial class GestionHospital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pestanas = new System.Windows.Forms.TabControl();
            this.ConsultarCitas = new System.Windows.Forms.TabPage();
            this.listViewMedicos = new System.Windows.Forms.ListView();
            this.btnGuardarListado = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btAñadirMedico = new System.Windows.Forms.Button();
            this.btEliminarMedico = new System.Windows.Forms.Button();
            this.lblListMedicos = new System.Windows.Forms.Label();
            this.lblListaMedicos = new System.Windows.Forms.Label();
            this.ListaMedicos = new System.Windows.Forms.TabPage();
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.btAsignarMedico = new System.Windows.Forms.Button();
            this.btAgregarPacienteList = new System.Windows.Forms.Button();
            this.btEliminarPacienteList = new System.Windows.Forms.Button();
            this.lblListadoPacientes = new System.Windows.Forms.Label();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.ListadoHospital = new System.Windows.Forms.TabPage();
            this.lblListaHosp = new System.Windows.Forms.Label();
            this.lblListadoHosp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaPacientes = new System.Windows.Forms.TabPage();
            this.listViewCitas = new System.Windows.Forms.ListView();
            this.lblListadoCitas = new System.Windows.Forms.Label();
            this.lblListaCitas = new System.Windows.Forms.Label();
            this.btnAñadirCita = new System.Windows.Forms.Button();
            this.btnModificarCita = new System.Windows.Forms.Button();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCitas = new System.Windows.Forms.Label();
            this.Pestanas.SuspendLayout();
            this.ConsultarCitas.SuspendLayout();
            this.ListaMedicos.SuspendLayout();
            this.ListadoHospital.SuspendLayout();
            this.ListaPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pestanas
            // 
            this.Pestanas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Pestanas.Controls.Add(this.ConsultarCitas);
            this.Pestanas.Controls.Add(this.ListaMedicos);
            this.Pestanas.Controls.Add(this.ListadoHospital);
            this.Pestanas.Controls.Add(this.ListaPacientes);
            this.Pestanas.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pestanas.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pestanas.Location = new System.Drawing.Point(-5, 1);
            this.Pestanas.Name = "Pestanas";
            this.Pestanas.SelectedIndex = 0;
            this.Pestanas.Size = new System.Drawing.Size(1099, 647);
            this.Pestanas.TabIndex = 1;
            // 
            // ConsultarCitas
            // 
            this.ConsultarCitas.AutoScroll = true;
            this.ConsultarCitas.BackColor = System.Drawing.Color.GhostWhite;
            this.ConsultarCitas.Controls.Add(this.listViewMedicos);
            this.ConsultarCitas.Controls.Add(this.btnGuardarListado);
            this.ConsultarCitas.Controls.Add(this.btnVolverMenu);
            this.ConsultarCitas.Controls.Add(this.btAñadirMedico);
            this.ConsultarCitas.Controls.Add(this.btEliminarMedico);
            this.ConsultarCitas.Controls.Add(this.lblListMedicos);
            this.ConsultarCitas.Controls.Add(this.lblListaMedicos);
            this.ConsultarCitas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsultarCitas.Location = new System.Drawing.Point(4, 32);
            this.ConsultarCitas.Name = "ConsultarCitas";
            this.ConsultarCitas.Size = new System.Drawing.Size(1091, 611);
            this.ConsultarCitas.TabIndex = 0;
            this.ConsultarCitas.Text = "Lista de Medicos";
            // 
            // listViewMedicos
            // 
            this.listViewMedicos.HideSelection = false;
            this.listViewMedicos.Location = new System.Drawing.Point(26, 127);
            this.listViewMedicos.Name = "listViewMedicos";
            this.listViewMedicos.Size = new System.Drawing.Size(638, 330);
            this.listViewMedicos.TabIndex = 39;
            this.listViewMedicos.UseCompatibleStateImageBehavior = false;
            // 
            // btnGuardarListado
            // 
            this.btnGuardarListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarListado.BackColor = System.Drawing.Color.Navy;
            this.btnGuardarListado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardarListado.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarListado.Location = new System.Drawing.Point(915, 539);
            this.btnGuardarListado.Name = "btnGuardarListado";
            this.btnGuardarListado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGuardarListado.Size = new System.Drawing.Size(154, 54);
            this.btnGuardarListado.TabIndex = 38;
            this.btnGuardarListado.Text = "Guardar";
            this.btnGuardarListado.UseVisualStyleBackColor = false;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverMenu.BackColor = System.Drawing.Color.Navy;
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolverMenu.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.Location = new System.Drawing.Point(26, 539);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVolverMenu.Size = new System.Drawing.Size(154, 61);
            this.btnVolverMenu.TabIndex = 37;
            this.btnVolverMenu.Text = "Volver al Menu";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btAñadirMedico
            // 
            this.btAñadirMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAñadirMedico.BackColor = System.Drawing.Color.Navy;
            this.btAñadirMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAñadirMedico.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAñadirMedico.Location = new System.Drawing.Point(700, 275);
            this.btAñadirMedico.Name = "btAñadirMedico";
            this.btAñadirMedico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAñadirMedico.Size = new System.Drawing.Size(133, 69);
            this.btAñadirMedico.TabIndex = 36;
            this.btAñadirMedico.Text = "Añadir Medico";
            this.btAñadirMedico.UseVisualStyleBackColor = false;
            this.btAñadirMedico.Click += new System.EventHandler(this.btAñadirMedico_Click);
            // 
            // btEliminarMedico
            // 
            this.btEliminarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarMedico.BackColor = System.Drawing.Color.Navy;
            this.btEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEliminarMedico.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarMedico.Location = new System.Drawing.Point(700, 191);
            this.btEliminarMedico.Name = "btEliminarMedico";
            this.btEliminarMedico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEliminarMedico.Size = new System.Drawing.Size(133, 64);
            this.btEliminarMedico.TabIndex = 35;
            this.btEliminarMedico.Text = "Eliminar Medico";
            this.btEliminarMedico.UseVisualStyleBackColor = false;
            this.btEliminarMedico.Click += new System.EventHandler(this.btEliminarMedico_Click);
            // 
            // lblListMedicos
            // 
            this.lblListMedicos.AutoSize = true;
            this.lblListMedicos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListMedicos.Location = new System.Drawing.Point(22, 91);
            this.lblListMedicos.Name = "lblListMedicos";
            this.lblListMedicos.Size = new System.Drawing.Size(158, 22);
            this.lblListMedicos.TabIndex = 5;
            this.lblListMedicos.Text = "Listado de Medicos";
            // 
            // lblListaMedicos
            // 
            this.lblListaMedicos.AutoSize = true;
            this.lblListaMedicos.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMedicos.Location = new System.Drawing.Point(413, 9);
            this.lblListaMedicos.Name = "lblListaMedicos";
            this.lblListaMedicos.Size = new System.Drawing.Size(270, 44);
            this.lblListaMedicos.TabIndex = 3;
            this.lblListaMedicos.Text = "Lista de Medicos";
            // 
            // ListaMedicos
            // 
            this.ListaMedicos.BackColor = System.Drawing.Color.GhostWhite;
            this.ListaMedicos.Controls.Add(this.listViewPacientes);
            this.ListaMedicos.Controls.Add(this.btAsignarMedico);
            this.ListaMedicos.Controls.Add(this.btAgregarPacienteList);
            this.ListaMedicos.Controls.Add(this.btEliminarPacienteList);
            this.ListaMedicos.Controls.Add(this.lblListadoPacientes);
            this.ListaMedicos.Controls.Add(this.lblListaPacientes);
            this.ListaMedicos.Location = new System.Drawing.Point(4, 32);
            this.ListaMedicos.Name = "ListaMedicos";
            this.ListaMedicos.Padding = new System.Windows.Forms.Padding(3);
            this.ListaMedicos.Size = new System.Drawing.Size(1091, 611);
            this.ListaMedicos.TabIndex = 1;
            this.ListaMedicos.Text = "Listar pacientes";
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.HideSelection = false;
            this.listViewPacientes.Location = new System.Drawing.Point(18, 138);
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size(632, 319);
            this.listViewPacientes.TabIndex = 40;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            // 
            // btAsignarMedico
            // 
            this.btAsignarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAsignarMedico.BackColor = System.Drawing.Color.Navy;
            this.btAsignarMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAsignarMedico.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignarMedico.Location = new System.Drawing.Point(687, 354);
            this.btAsignarMedico.Name = "btAsignarMedico";
            this.btAsignarMedico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAsignarMedico.Size = new System.Drawing.Size(133, 64);
            this.btAsignarMedico.TabIndex = 39;
            this.btAsignarMedico.Text = "Asignarle un Medico";
            this.btAsignarMedico.UseVisualStyleBackColor = false;
            // 
            // btAgregarPacienteList
            // 
            this.btAgregarPacienteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregarPacienteList.BackColor = System.Drawing.Color.Navy;
            this.btAgregarPacienteList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAgregarPacienteList.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPacienteList.Location = new System.Drawing.Point(687, 261);
            this.btAgregarPacienteList.Name = "btAgregarPacienteList";
            this.btAgregarPacienteList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAgregarPacienteList.Size = new System.Drawing.Size(133, 64);
            this.btAgregarPacienteList.TabIndex = 37;
            this.btAgregarPacienteList.Text = "Añadir Paciente";
            this.btAgregarPacienteList.UseVisualStyleBackColor = false;
            this.btAgregarPacienteList.Click += new System.EventHandler(this.btAgregarPacienteList_Click);
            // 
            // btEliminarPacienteList
            // 
            this.btEliminarPacienteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarPacienteList.BackColor = System.Drawing.Color.Navy;
            this.btEliminarPacienteList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btEliminarPacienteList.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarPacienteList.Location = new System.Drawing.Point(687, 170);
            this.btEliminarPacienteList.Name = "btEliminarPacienteList";
            this.btEliminarPacienteList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btEliminarPacienteList.Size = new System.Drawing.Size(133, 64);
            this.btEliminarPacienteList.TabIndex = 36;
            this.btEliminarPacienteList.Text = "Eliminar Paciente";
            this.btEliminarPacienteList.UseVisualStyleBackColor = false;
            // 
            // lblListadoPacientes
            // 
            this.lblListadoPacientes.AutoSize = true;
            this.lblListadoPacientes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoPacientes.Location = new System.Drawing.Point(14, 104);
            this.lblListadoPacientes.Name = "lblListadoPacientes";
            this.lblListadoPacientes.Size = new System.Drawing.Size(165, 22);
            this.lblListadoPacientes.TabIndex = 1;
            this.lblListadoPacientes.Text = "Listado de Pacientes";
            // 
            // lblListaPacientes
            // 
            this.lblListaPacientes.AutoSize = true;
            this.lblListaPacientes.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPacientes.Location = new System.Drawing.Point(388, 12);
            this.lblListaPacientes.Name = "lblListaPacientes";
            this.lblListaPacientes.Size = new System.Drawing.Size(285, 44);
            this.lblListaPacientes.TabIndex = 0;
            this.lblListaPacientes.Text = "Lista de Pacientes";
            // 
            // ListadoHospital
            // 
            this.ListadoHospital.BackColor = System.Drawing.Color.GhostWhite;
            this.ListadoHospital.Controls.Add(this.lblListaHosp);
            this.ListadoHospital.Controls.Add(this.lblListadoHosp);
            this.ListadoHospital.Controls.Add(this.button1);
            this.ListadoHospital.Controls.Add(this.listBox1);
            this.ListadoHospital.Controls.Add(this.button2);
            this.ListadoHospital.Controls.Add(this.button3);
            this.ListadoHospital.Controls.Add(this.label4);
            this.ListadoHospital.Controls.Add(this.label5);
            this.ListadoHospital.Location = new System.Drawing.Point(4, 32);
            this.ListadoHospital.Name = "ListadoHospital";
            this.ListadoHospital.Size = new System.Drawing.Size(1091, 611);
            this.ListadoHospital.TabIndex = 3;
            this.ListadoHospital.Text = "Listado Hospital";
            // 
            // lblListaHosp
            // 
            this.lblListaHosp.AutoSize = true;
            this.lblListaHosp.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaHosp.Location = new System.Drawing.Point(356, 107);
            this.lblListaHosp.Name = "lblListaHosp";
            this.lblListaHosp.Size = new System.Drawing.Size(250, 22);
            this.lblListaHosp.TabIndex = 55;
            this.lblListaHosp.Text = "Lista de personas en el Hospital";
            // 
            // lblListadoHosp
            // 
            this.lblListadoHosp.AutoSize = true;
            this.lblListadoHosp.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoHosp.Location = new System.Drawing.Point(430, 17);
            this.lblListadoHosp.Name = "lblListadoHosp";
            this.lblListadoHosp.Size = new System.Drawing.Size(261, 44);
            this.lblListadoHosp.TabIndex = 54;
            this.lblListadoHosp.Text = "Listado Hospital";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 361);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 53;
            this.button1.Text = "Añadir Cita";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(354, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 344);
            this.listBox1.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(728, 268);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(133, 64);
            this.button2.TabIndex = 51;
            this.button2.Text = "Modificar Cita";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(728, 177);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(133, 64);
            this.button3.TabIndex = 50;
            this.button3.Text = "Cancelar Cita";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 44);
            this.label5.TabIndex = 48;
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.BackColor = System.Drawing.Color.GhostWhite;
            this.ListaPacientes.Controls.Add(this.listViewCitas);
            this.ListaPacientes.Controls.Add(this.lblListadoCitas);
            this.ListaPacientes.Controls.Add(this.lblListaCitas);
            this.ListaPacientes.Controls.Add(this.btnAñadirCita);
            this.ListaPacientes.Controls.Add(this.btnModificarCita);
            this.ListaPacientes.Controls.Add(this.btnCancelarCita);
            this.ListaPacientes.Controls.Add(this.label1);
            this.ListaPacientes.Controls.Add(this.lblCitas);
            this.ListaPacientes.Location = new System.Drawing.Point(4, 32);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(1091, 611);
            this.ListaPacientes.TabIndex = 2;
            this.ListaPacientes.Text = "Citas";
            // 
            // listViewCitas
            // 
            this.listViewCitas.HideSelection = false;
            this.listViewCitas.Location = new System.Drawing.Point(28, 126);
            this.listViewCitas.Name = "listViewCitas";
            this.listViewCitas.Size = new System.Drawing.Size(694, 369);
            this.listViewCitas.TabIndex = 48;
            this.listViewCitas.UseCompatibleStateImageBehavior = false;
            // 
            // lblListadoCitas
            // 
            this.lblListadoCitas.AutoSize = true;
            this.lblListadoCitas.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoCitas.Location = new System.Drawing.Point(24, 90);
            this.lblListadoCitas.Name = "lblListadoCitas";
            this.lblListadoCitas.Size = new System.Drawing.Size(128, 22);
            this.lblListadoCitas.TabIndex = 47;
            this.lblListadoCitas.Text = "Listado de citas";
            // 
            // lblListaCitas
            // 
            this.lblListaCitas.AutoSize = true;
            this.lblListaCitas.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCitas.Location = new System.Drawing.Point(492, 13);
            this.lblListaCitas.Name = "lblListaCitas";
            this.lblListaCitas.Size = new System.Drawing.Size(95, 44);
            this.lblListaCitas.TabIndex = 46;
            this.lblListaCitas.Text = "Citas";
            // 
            // btnAñadirCita
            // 
            this.btnAñadirCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirCita.BackColor = System.Drawing.Color.Navy;
            this.btnAñadirCita.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAñadirCita.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCita.Location = new System.Drawing.Point(758, 360);
            this.btnAñadirCita.Name = "btnAñadirCita";
            this.btnAñadirCita.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAñadirCita.Size = new System.Drawing.Size(133, 64);
            this.btnAñadirCita.TabIndex = 45;
            this.btnAñadirCita.Text = "Asignarle un Medico";
            this.btnAñadirCita.UseVisualStyleBackColor = false;
            // 
            // btnModificarCita
            // 
            this.btnModificarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCita.BackColor = System.Drawing.Color.Navy;
            this.btnModificarCita.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificarCita.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCita.Location = new System.Drawing.Point(758, 267);
            this.btnModificarCita.Name = "btnModificarCita";
            this.btnModificarCita.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnModificarCita.Size = new System.Drawing.Size(133, 64);
            this.btnModificarCita.TabIndex = 43;
            this.btnModificarCita.Text = "Modificar Cita";
            this.btnModificarCita.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCita.BackColor = System.Drawing.Color.Navy;
            this.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarCita.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.Location = new System.Drawing.Point(758, 176);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelarCita.Size = new System.Drawing.Size(133, 64);
            this.btnCancelarCita.TabIndex = 42;
            this.btnCancelarCita.Text = "Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 41;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(486, 13);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(0, 44);
            this.lblCitas.TabIndex = 40;
            // 
            // GestionHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1089, 645);
            this.Controls.Add(this.Pestanas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionHospital";
            this.Pestanas.ResumeLayout(false);
            this.ConsultarCitas.ResumeLayout(false);
            this.ConsultarCitas.PerformLayout();
            this.ListaMedicos.ResumeLayout(false);
            this.ListaMedicos.PerformLayout();
            this.ListadoHospital.ResumeLayout(false);
            this.ListadoHospital.PerformLayout();
            this.ListaPacientes.ResumeLayout(false);
            this.ListaPacientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pestanas;
        private System.Windows.Forms.TabPage ConsultarCitas;
        private System.Windows.Forms.TabPage ListaMedicos;
        private System.Windows.Forms.TabPage ListadoHospital;
        private System.Windows.Forms.Label lblListaMedicos;
        private System.Windows.Forms.Label lblListMedicos;
        private System.Windows.Forms.Button btAñadirMedico;
        private System.Windows.Forms.Button btEliminarMedico;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnGuardarListado;
        private System.Windows.Forms.Label lblListadoPacientes;
        private System.Windows.Forms.Label lblListaPacientes;
        private System.Windows.Forms.Button btAgregarPacienteList;
        private System.Windows.Forms.Button btEliminarPacienteList;
        private System.Windows.Forms.Button btAsignarMedico;
        private System.Windows.Forms.ListView listViewMedicos;
        private System.Windows.Forms.TabPage ListaPacientes;
        private System.Windows.Forms.Button btnAñadirCita;
        private System.Windows.Forms.Button btnModificarCita;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Label lblListadoCitas;
        private System.Windows.Forms.Label lblListaCitas;
        private System.Windows.Forms.Label lblListaHosp;
        private System.Windows.Forms.Label lblListadoHosp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewPacientes;
        private System.Windows.Forms.ListView listViewCitas;
    }
}