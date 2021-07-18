
namespace Clinica_Médica.View
{
    partial class Atualizar_Agenda
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
            this.components = new System.ComponentModel.Container();
            this.lblAtualizarPacienteAgenda = new System.Windows.Forms.Label();
            this.lblAtualizarMedicoAgenda = new System.Windows.Forms.Label();
            this.lblAtualizarDataHoraAgenda = new System.Windows.Forms.Label();
            this.cbAtualizarPacienteAgenda = new System.Windows.Forms.ComboBox();
            this.cbAtualizarMedicoAgenda = new System.Windows.Forms.ComboBox();
            this.dtAtualizarDataHora = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizarAgenda = new System.Windows.Forms.Button();
            this.errorAtualizarAgenda = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtualizarPacienteAgenda
            // 
            this.lblAtualizarPacienteAgenda.AutoSize = true;
            this.lblAtualizarPacienteAgenda.Location = new System.Drawing.Point(13, 13);
            this.lblAtualizarPacienteAgenda.Name = "lblAtualizarPacienteAgenda";
            this.lblAtualizarPacienteAgenda.Size = new System.Drawing.Size(58, 15);
            this.lblAtualizarPacienteAgenda.TabIndex = 0;
            this.lblAtualizarPacienteAgenda.Text = "Pacieênte";
            // 
            // lblAtualizarMedicoAgenda
            // 
            this.lblAtualizarMedicoAgenda.AutoSize = true;
            this.lblAtualizarMedicoAgenda.Location = new System.Drawing.Point(13, 74);
            this.lblAtualizarMedicoAgenda.Name = "lblAtualizarMedicoAgenda";
            this.lblAtualizarMedicoAgenda.Size = new System.Drawing.Size(47, 15);
            this.lblAtualizarMedicoAgenda.TabIndex = 1;
            this.lblAtualizarMedicoAgenda.Text = "Médico";
            // 
            // lblAtualizarDataHoraAgenda
            // 
            this.lblAtualizarDataHoraAgenda.AutoSize = true;
            this.lblAtualizarDataHoraAgenda.Location = new System.Drawing.Point(13, 136);
            this.lblAtualizarDataHoraAgenda.Name = "lblAtualizarDataHoraAgenda";
            this.lblAtualizarDataHoraAgenda.Size = new System.Drawing.Size(69, 15);
            this.lblAtualizarDataHoraAgenda.TabIndex = 2;
            this.lblAtualizarDataHoraAgenda.Text = "Data e Hora";
            // 
            // cbAtualizarPacienteAgenda
            // 
            this.cbAtualizarPacienteAgenda.DisplayMember = "Nome";
            this.cbAtualizarPacienteAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtualizarPacienteAgenda.FormattingEnabled = true;
            this.cbAtualizarPacienteAgenda.Location = new System.Drawing.Point(13, 32);
            this.cbAtualizarPacienteAgenda.Name = "cbAtualizarPacienteAgenda";
            this.cbAtualizarPacienteAgenda.Size = new System.Drawing.Size(301, 23);
            this.cbAtualizarPacienteAgenda.TabIndex = 3;
            this.cbAtualizarPacienteAgenda.ValueMember = "ID";
            // 
            // cbAtualizarMedicoAgenda
            // 
            this.cbAtualizarMedicoAgenda.DisplayMember = "Nome";
            this.cbAtualizarMedicoAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtualizarMedicoAgenda.FormattingEnabled = true;
            this.cbAtualizarMedicoAgenda.Location = new System.Drawing.Point(13, 92);
            this.cbAtualizarMedicoAgenda.Name = "cbAtualizarMedicoAgenda";
            this.cbAtualizarMedicoAgenda.Size = new System.Drawing.Size(301, 23);
            this.cbAtualizarMedicoAgenda.TabIndex = 4;
            this.cbAtualizarMedicoAgenda.ValueMember = "ID";
            // 
            // dtAtualizarDataHora
            // 
            this.dtAtualizarDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtAtualizarDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAtualizarDataHora.Location = new System.Drawing.Point(13, 155);
            this.dtAtualizarDataHora.Name = "dtAtualizarDataHora";
            this.dtAtualizarDataHora.Size = new System.Drawing.Size(301, 23);
            this.dtAtualizarDataHora.TabIndex = 5;
            // 
            // btnAtualizarAgenda
            // 
            this.btnAtualizarAgenda.Location = new System.Drawing.Point(13, 205);
            this.btnAtualizarAgenda.Name = "btnAtualizarAgenda";
            this.btnAtualizarAgenda.Size = new System.Drawing.Size(104, 35);
            this.btnAtualizarAgenda.TabIndex = 6;
            this.btnAtualizarAgenda.Text = "Atualizar";
            this.btnAtualizarAgenda.UseVisualStyleBackColor = true;
            this.btnAtualizarAgenda.Click += new System.EventHandler(this.btnAtualizarAgenda_Click);
            // 
            // errorAtualizarAgenda
            // 
            this.errorAtualizarAgenda.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAtualizarAgenda.ContainerControl = this;
            // 
            // Atualizar_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 258);
            this.Controls.Add(this.btnAtualizarAgenda);
            this.Controls.Add(this.dtAtualizarDataHora);
            this.Controls.Add(this.cbAtualizarMedicoAgenda);
            this.Controls.Add(this.cbAtualizarPacienteAgenda);
            this.Controls.Add(this.lblAtualizarDataHoraAgenda);
            this.Controls.Add(this.lblAtualizarMedicoAgenda);
            this.Controls.Add(this.lblAtualizarPacienteAgenda);
            this.MaximizeBox = false;
            this.Name = "Atualizar_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Agenda";
            this.Load += new System.EventHandler(this.Atualizar_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtualizarPacienteAgenda;
        private System.Windows.Forms.Label lblAtualizarMedicoAgenda;
        private System.Windows.Forms.Label lblAtualizarDataHoraAgenda;
        private System.Windows.Forms.ComboBox cbAtualizarPacienteAgenda;
        private System.Windows.Forms.ComboBox cbAtualizarMedicoAgenda;
        private System.Windows.Forms.DateTimePicker dtAtualizarDataHora;
        private System.Windows.Forms.Button btnAtualizarAgenda;
        private System.Windows.Forms.ErrorProvider errorAtualizarAgenda;
    }
}