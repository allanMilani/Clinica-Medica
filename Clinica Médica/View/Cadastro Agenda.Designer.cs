
namespace Clinica_Médica.View
{
    partial class Cadastro_Agenda
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.dtDataHora = new System.Windows.Forms.DateTimePicker();
            this.errorAgenda = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastroAgenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(13, 13);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Paciênte";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(13, 70);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 15);
            this.lblMedico.TabIndex = 1;
            this.lblMedico.Text = "Médico";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(12, 129);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(69, 15);
            this.lblDataHora.TabIndex = 2;
            this.lblDataHora.Text = "Data e Hora";
            // 
            // cbPaciente
            // 
            this.cbPaciente.DisplayMember = "Nome";
            this.cbPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(13, 32);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(284, 23);
            this.cbPaciente.TabIndex = 3;
            this.cbPaciente.ValueMember = "ID";
            // 
            // cbMedico
            // 
            this.cbMedico.DisplayMember = "Nome";
            this.cbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(12, 88);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(285, 23);
            this.cbMedico.TabIndex = 4;
            this.cbMedico.ValueMember = "ID";
            // 
            // dtDataHora
            // 
            this.dtDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataHora.Location = new System.Drawing.Point(13, 148);
            this.dtDataHora.Name = "dtDataHora";
            this.dtDataHora.Size = new System.Drawing.Size(284, 23);
            this.dtDataHora.TabIndex = 5;
            // 
            // errorAgenda
            // 
            this.errorAgenda.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAgenda.ContainerControl = this;
            // 
            // btnCadastroAgenda
            // 
            this.btnCadastroAgenda.Location = new System.Drawing.Point(13, 205);
            this.btnCadastroAgenda.Name = "btnCadastroAgenda";
            this.btnCadastroAgenda.Size = new System.Drawing.Size(93, 37);
            this.btnCadastroAgenda.TabIndex = 6;
            this.btnCadastroAgenda.Text = "Cadastrar";
            this.btnCadastroAgenda.UseVisualStyleBackColor = true;
            this.btnCadastroAgenda.Click += new System.EventHandler(this.btnCadastroAgenda_Click);
            // 
            // Cadastro_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 263);
            this.Controls.Add(this.btnCadastroAgenda);
            this.Controls.Add(this.dtDataHora);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblPaciente);
            this.MaximizeBox = false;
            this.Name = "Cadastro_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Agenda_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cdMedico;
        private System.Windows.Forms.DateTimePicker dtDataHora;
        private System.Windows.Forms.ErrorProvider errorAgenda;
        private System.Windows.Forms.Button btnCadastroAgenda;
        private System.Windows.Forms.ComboBox cbMedico;
    }
}