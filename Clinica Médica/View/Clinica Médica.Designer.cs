
namespace Clinica_Médica.View
{
    partial class Clinica_Medica
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
            this.menuClinicaMedica = new System.Windows.Forms.MenuStrip();
            this.agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.medicos = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.historico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClinicaMedica.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuClinicaMedica
            // 
            this.menuClinicaMedica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenda,
            this.especialidades,
            this.medicos,
            this.pacientes,
            this.historico});
            this.menuClinicaMedica.Location = new System.Drawing.Point(0, 0);
            this.menuClinicaMedica.Name = "menuClinicaMedica";
            this.menuClinicaMedica.Size = new System.Drawing.Size(819, 24);
            this.menuClinicaMedica.TabIndex = 0;
            this.menuClinicaMedica.Text = "Clinica Médica Menu";
            // 
            // agenda
            // 
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(60, 20);
            this.agenda.Text = "Agenda";
            this.agenda.Click += new System.EventHandler(this.agenda_Click);
            // 
            // especialidades
            // 
            this.especialidades.Name = "especialidades";
            this.especialidades.Size = new System.Drawing.Size(95, 20);
            this.especialidades.Text = "Especialidades";
            this.especialidades.Click += new System.EventHandler(this.especialidades_Click);
            // 
            // medicos
            // 
            this.medicos.Name = "medicos";
            this.medicos.Size = new System.Drawing.Size(64, 20);
            this.medicos.Text = "Médicos";
            this.medicos.Click += new System.EventHandler(this.medicos_Click);
            // 
            // pacientes
            // 
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(69, 20);
            this.pacientes.Text = "Paciêntes";
            this.pacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // historico
            // 
            this.historico.Name = "historico";
            this.historico.Size = new System.Drawing.Size(67, 20);
            this.historico.Text = "Histórico";
            this.historico.Click += new System.EventHandler(this.historico_Click);
            // 
            // Clinica_Medica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clinica_Médica.Properties.Resources._6859156_health_health_symbol_healthcare_medical_medicine_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(819, 540);
            this.Controls.Add(this.menuClinicaMedica);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuClinicaMedica;
            this.Name = "Clinica_Medica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica Médica";
            this.menuClinicaMedica.ResumeLayout(false);
            this.menuClinicaMedica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuClinicaMedica;
        private System.Windows.Forms.ToolStripMenuItem agenda;
        private System.Windows.Forms.ToolStripMenuItem especialidades;
        private System.Windows.Forms.ToolStripMenuItem medicos;
        private System.Windows.Forms.ToolStripMenuItem pacientes;
        private System.Windows.Forms.ToolStripMenuItem historico;
    }
}