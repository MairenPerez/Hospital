﻿namespace Hospital
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
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPersAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaciente.BackColor = System.Drawing.Color.Navy;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Location = new System.Drawing.Point(53, 230);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPaciente.Size = new System.Drawing.Size(258, 112);
            this.btnPaciente.TabIndex = 5;
            this.btnPaciente.Text = "Area Paciente";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedico.BackColor = System.Drawing.Color.Navy;
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMedico.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Location = new System.Drawing.Point(391, 230);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMedico.Size = new System.Drawing.Size(258, 112);
            this.btnMedico.TabIndex = 6;
            this.btnMedico.Text = "Area Medico";
            this.btnMedico.UseVisualStyleBackColor = false;
            // 
            // btnPersAdm
            // 
            this.btnPersAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersAdm.BackColor = System.Drawing.Color.Navy;
            this.btnPersAdm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPersAdm.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersAdm.Location = new System.Drawing.Point(739, 230);
            this.btnPersAdm.Name = "btnPersAdm";
            this.btnPersAdm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPersAdm.Size = new System.Drawing.Size(258, 112);
            this.btnPersAdm.TabIndex = 7;
            this.btnPersAdm.Text = "Area Personal Adm";
            this.btnPersAdm.UseVisualStyleBackColor = false;
            // 
            // GestionHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1103, 658);
            this.Controls.Add(this.btnPersAdm);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnPaciente);
            this.Name = "GestionHospital";
            this.Text = "GestionHospital";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPersAdm;
    }
}