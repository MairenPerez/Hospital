namespace Hospital
{
    partial class AreaPersonalAdm
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
            this.lblPersonalAdm = new System.Windows.Forms.Label();
            this.txtApellidosPersonalAdm = new System.Windows.Forms.TextBox();
            this.lblApellidosPersonalAdm = new System.Windows.Forms.Label();
            this.txtNomPersonalAdm = new System.Windows.Forms.TextBox();
            this.lblNomPersonalAdm = new System.Windows.Forms.Label();
            this.lblSalarioPersonalAdm = new System.Windows.Forms.Label();
            this.lblNomPaciente = new System.Windows.Forms.Label();
            this.txtSalarioPersonalAdm = new System.Windows.Forms.TextBox();
            this.listBoxDepartamento = new System.Windows.Forms.ListBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btGuardarPersonalAdm = new System.Windows.Forms.Button();
            this.btnVolverAreas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonalAdm
            // 
            this.lblPersonalAdm.AutoSize = true;
            this.lblPersonalAdm.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalAdm.Location = new System.Drawing.Point(221, 9);
            this.lblPersonalAdm.Name = "lblPersonalAdm";
            this.lblPersonalAdm.Size = new System.Drawing.Size(401, 28);
            this.lblPersonalAdm.TabIndex = 7;
            this.lblPersonalAdm.Text = "DATOS DEL PERSONAL ADMINISTRATIVO";
            // 
            // txtApellidosPersonalAdm
            // 
            this.txtApellidosPersonalAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidosPersonalAdm.Location = new System.Drawing.Point(98, 157);
            this.txtApellidosPersonalAdm.Name = "txtApellidosPersonalAdm";
            this.txtApellidosPersonalAdm.Size = new System.Drawing.Size(218, 15);
            this.txtApellidosPersonalAdm.TabIndex = 11;
            // 
            // lblApellidosPersonalAdm
            // 
            this.lblApellidosPersonalAdm.AutoSize = true;
            this.lblApellidosPersonalAdm.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosPersonalAdm.Location = new System.Drawing.Point(12, 152);
            this.lblApellidosPersonalAdm.Name = "lblApellidosPersonalAdm";
            this.lblApellidosPersonalAdm.Size = new System.Drawing.Size(80, 22);
            this.lblApellidosPersonalAdm.TabIndex = 10;
            this.lblApellidosPersonalAdm.Text = "Apellidos";
            // 
            // txtNomPersonalAdm
            // 
            this.txtNomPersonalAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomPersonalAdm.Location = new System.Drawing.Point(98, 125);
            this.txtNomPersonalAdm.Name = "txtNomPersonalAdm";
            this.txtNomPersonalAdm.Size = new System.Drawing.Size(218, 15);
            this.txtNomPersonalAdm.TabIndex = 9;
            // 
            // lblNomPersonalAdm
            // 
            this.lblNomPersonalAdm.AutoSize = true;
            this.lblNomPersonalAdm.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPersonalAdm.Location = new System.Drawing.Point(18, 120);
            this.lblNomPersonalAdm.Name = "lblNomPersonalAdm";
            this.lblNomPersonalAdm.Size = new System.Drawing.Size(74, 22);
            this.lblNomPersonalAdm.TabIndex = 8;
            this.lblNomPersonalAdm.Text = "Nombre";
            // 
            // lblSalarioPersonalAdm
            // 
            this.lblSalarioPersonalAdm.AutoSize = true;
            this.lblSalarioPersonalAdm.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioPersonalAdm.Location = new System.Drawing.Point(340, 120);
            this.lblSalarioPersonalAdm.Name = "lblSalarioPersonalAdm";
            this.lblSalarioPersonalAdm.Size = new System.Drawing.Size(63, 22);
            this.lblSalarioPersonalAdm.TabIndex = 14;
            this.lblSalarioPersonalAdm.Text = "Salario";
            // 
            // lblNomPaciente
            // 
            this.lblNomPaciente.AutoSize = true;
            this.lblNomPaciente.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPaciente.Location = new System.Drawing.Point(12, 215);
            this.lblNomPaciente.Name = "lblNomPaciente";
            this.lblNomPaciente.Size = new System.Drawing.Size(122, 22);
            this.lblNomPaciente.TabIndex = 12;
            this.lblNomPaciente.Text = "Departamento";
            // 
            // txtSalarioPersonalAdm
            // 
            this.txtSalarioPersonalAdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioPersonalAdm.Location = new System.Drawing.Point(409, 125);
            this.txtSalarioPersonalAdm.Name = "txtSalarioPersonalAdm";
            this.txtSalarioPersonalAdm.Size = new System.Drawing.Size(112, 15);
            this.txtSalarioPersonalAdm.TabIndex = 15;
            // 
            // listBoxDepartamento
            // 
            this.listBoxDepartamento.FormattingEnabled = true;
            this.listBoxDepartamento.ItemHeight = 16;
            this.listBoxDepartamento.Items.AddRange(new object[] {
            "Anestesiologia",
            "Cardiologia",
            "Cuidados Intensivos",
            "Digestivo",
            "Hematologia",
            "Nefrologia ",
            "Neumologia ",
            "Oncologia ",
            "Pediatria",
            "Rehabiltiacion",
            "Urgencias",
            "Cirugia Ortopedica y Traumatologia ",
            "Dermatologia ",
            "Ginecologia y Obstetrica",
            "Oftamologia",
            "Urologia ",
            "Radiodiagnostico",
            "Farmacia",
            "Laboratorios Clinicos",
            "Medicina Preventiva "});
            this.listBoxDepartamento.Location = new System.Drawing.Point(16, 252);
            this.listBoxDepartamento.Name = "listBoxDepartamento";
            this.listBoxDepartamento.Size = new System.Drawing.Size(174, 116);
            this.listBoxDepartamento.TabIndex = 16;
            // 
            // btBorrar
            // 
            this.btBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBorrar.BackColor = System.Drawing.Color.Navy;
            this.btBorrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBorrar.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(606, 487);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btBorrar.Size = new System.Drawing.Size(150, 54);
            this.btBorrar.TabIndex = 29;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btGuardarPersonalAdm
            // 
            this.btGuardarPersonalAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardarPersonalAdm.BackColor = System.Drawing.Color.Navy;
            this.btGuardarPersonalAdm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGuardarPersonalAdm.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarPersonalAdm.Location = new System.Drawing.Point(770, 487);
            this.btGuardarPersonalAdm.Name = "btGuardarPersonalAdm";
            this.btGuardarPersonalAdm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btGuardarPersonalAdm.Size = new System.Drawing.Size(150, 54);
            this.btGuardarPersonalAdm.TabIndex = 28;
            this.btGuardarPersonalAdm.Text = "Agregar Personal Administrativo";
            this.btGuardarPersonalAdm.UseVisualStyleBackColor = false;
            this.btGuardarPersonalAdm.Click += new System.EventHandler(this.btGuardarPersonalAdm_Click);
            // 
            // btnVolverAreas
            // 
            this.btnVolverAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverAreas.BackColor = System.Drawing.Color.Navy;
            this.btnVolverAreas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVolverAreas.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAreas.Location = new System.Drawing.Point(12, 487);
            this.btnVolverAreas.Name = "btnVolverAreas";
            this.btnVolverAreas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVolverAreas.Size = new System.Drawing.Size(154, 54);
            this.btnVolverAreas.TabIndex = 27;
            this.btnVolverAreas.Text = "Volver a Areas";
            this.btnVolverAreas.UseVisualStyleBackColor = false;
            this.btnVolverAreas.Click += new System.EventHandler(this.btnVolverAreas_Click);
            // 
            // AreaPersonalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btGuardarPersonalAdm);
            this.Controls.Add(this.btnVolverAreas);
            this.Controls.Add(this.listBoxDepartamento);
            this.Controls.Add(this.txtSalarioPersonalAdm);
            this.Controls.Add(this.lblSalarioPersonalAdm);
            this.Controls.Add(this.lblNomPaciente);
            this.Controls.Add(this.txtApellidosPersonalAdm);
            this.Controls.Add(this.lblApellidosPersonalAdm);
            this.Controls.Add(this.txtNomPersonalAdm);
            this.Controls.Add(this.lblNomPersonalAdm);
            this.Controls.Add(this.lblPersonalAdm);
            this.Name = "AreaPersonalAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaPersonalAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonalAdm;
        private System.Windows.Forms.TextBox txtApellidosPersonalAdm;
        private System.Windows.Forms.Label lblApellidosPersonalAdm;
        private System.Windows.Forms.TextBox txtNomPersonalAdm;
        private System.Windows.Forms.Label lblNomPersonalAdm;
        private System.Windows.Forms.Label lblSalarioPersonalAdm;
        private System.Windows.Forms.Label lblNomPaciente;
        private System.Windows.Forms.TextBox txtSalarioPersonalAdm;
        private System.Windows.Forms.ListBox listBoxDepartamento;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btGuardarPersonalAdm;
        private System.Windows.Forms.Button btnVolverAreas;
    }
}