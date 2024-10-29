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
            this.Citas = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGuardarListado = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btAñadirMedico = new System.Windows.Forms.Button();
            this.btEliminarMedico = new System.Windows.Forms.Button();
            this.lblListMedicos = new System.Windows.Forms.Label();
            this.lblListaMedicos = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAsignarMedico = new System.Windows.Forms.Button();
            this.listPacientes = new System.Windows.Forms.ListBox();
            this.btAgregarPacienteList = new System.Windows.Forms.Button();
            this.btEliminarPacienteList = new System.Windows.Forms.Button();
            this.lblListadoPacientes = new System.Windows.Forms.Label();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewMedicos = new System.Windows.Forms.ListView();
            this.Citas.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Citas
            // 
            this.Citas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Citas.Controls.Add(this.tabPage4);
            this.Citas.Controls.Add(this.tabPage1);
            this.Citas.Controls.Add(this.tabPage3);
            this.Citas.Controls.Add(this.tabPage2);
            this.Citas.Cursor = System.Windows.Forms.Cursors.Default;
            this.Citas.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citas.Location = new System.Drawing.Point(-5, 1);
            this.Citas.Name = "Citas";
            this.Citas.SelectedIndex = 0;
            this.Citas.Size = new System.Drawing.Size(1099, 647);
            this.Citas.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage4.Controls.Add(this.listViewMedicos);
            this.tabPage4.Controls.Add(this.btnGuardarListado);
            this.tabPage4.Controls.Add(this.btnVolverMenu);
            this.tabPage4.Controls.Add(this.btAñadirMedico);
            this.tabPage4.Controls.Add(this.btEliminarMedico);
            this.tabPage4.Controls.Add(this.lblListMedicos);
            this.tabPage4.Controls.Add(this.lblListaMedicos);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1091, 611);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Lista de Medicos";
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
            this.btAñadirMedico.Location = new System.Drawing.Point(740, 209);
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
            this.btEliminarMedico.Location = new System.Drawing.Point(740, 125);
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
            this.lblListMedicos.Location = new System.Drawing.Point(309, 89);
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.btAsignarMedico);
            this.tabPage1.Controls.Add(this.listPacientes);
            this.tabPage1.Controls.Add(this.btAgregarPacienteList);
            this.tabPage1.Controls.Add(this.btEliminarPacienteList);
            this.tabPage1.Controls.Add(this.lblListadoPacientes);
            this.tabPage1.Controls.Add(this.lblListaPacientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 611);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Listar pacientes";
            // 
            // btAsignarMedico
            // 
            this.btAsignarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAsignarMedico.BackColor = System.Drawing.Color.Navy;
            this.btAsignarMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAsignarMedico.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignarMedico.Location = new System.Drawing.Point(396, 314);
            this.btAsignarMedico.Name = "btAsignarMedico";
            this.btAsignarMedico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAsignarMedico.Size = new System.Drawing.Size(133, 64);
            this.btAsignarMedico.TabIndex = 39;
            this.btAsignarMedico.Text = "Asignarle un Medico";
            this.btAsignarMedico.UseVisualStyleBackColor = false;
            // 
            // listPacientes
            // 
            this.listPacientes.FormattingEnabled = true;
            this.listPacientes.ItemHeight = 20;
            this.listPacientes.Location = new System.Drawing.Point(26, 130);
            this.listPacientes.Name = "listPacientes";
            this.listPacientes.Size = new System.Drawing.Size(346, 344);
            this.listPacientes.TabIndex = 38;
            // 
            // btAgregarPacienteList
            // 
            this.btAgregarPacienteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregarPacienteList.BackColor = System.Drawing.Color.Navy;
            this.btAgregarPacienteList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAgregarPacienteList.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarPacienteList.Location = new System.Drawing.Point(396, 221);
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
            this.btEliminarPacienteList.Location = new System.Drawing.Point(396, 130);
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
            this.lblListadoPacientes.Location = new System.Drawing.Point(22, 96);
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1091, 611);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Listado Hospital";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1091, 611);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Citas";
            // 
            // listViewMedicos
            // 
            this.listViewMedicos.HideSelection = false;
            this.listViewMedicos.Location = new System.Drawing.Point(313, 125);
            this.listViewMedicos.Name = "listViewMedicos";
            this.listViewMedicos.Size = new System.Drawing.Size(404, 313);
            this.listViewMedicos.TabIndex = 39;
            this.listViewMedicos.UseCompatibleStateImageBehavior = false;
            this.listViewMedicos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // GestionHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1089, 645);
            this.Controls.Add(this.Citas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionHospital";
            this.Text = "GestionHospital";
            this.Citas.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Citas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.ListBox listPacientes;
        private System.Windows.Forms.Button btAsignarMedico;
        private System.Windows.Forms.ListView listViewMedicos;
    }
}