
namespace Clinica_Médica.View
{
    partial class Historico_Pacientes
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
            this.lblNomePacienteFiltro = new System.Windows.Forms.Label();
            this.cbPesquisarPaciente = new System.Windows.Forms.ComboBox();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.dtvListaHistorico = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.VerAnotacoes = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaHistorico)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomePacienteFiltro
            // 
            this.lblNomePacienteFiltro.AutoSize = true;
            this.lblNomePacienteFiltro.Location = new System.Drawing.Point(12, 33);
            this.lblNomePacienteFiltro.Name = "lblNomePacienteFiltro";
            this.lblNomePacienteFiltro.Size = new System.Drawing.Size(52, 15);
            this.lblNomePacienteFiltro.TabIndex = 0;
            this.lblNomePacienteFiltro.Text = "Paciente";
            // 
            // cbPesquisarPaciente
            // 
            this.cbPesquisarPaciente.DisplayMember = "Nome";
            this.cbPesquisarPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisarPaciente.FormattingEnabled = true;
            this.cbPesquisarPaciente.Location = new System.Drawing.Point(12, 52);
            this.cbPesquisarPaciente.Name = "cbPesquisarPaciente";
            this.cbPesquisarPaciente.Size = new System.Drawing.Size(450, 23);
            this.cbPesquisarPaciente.TabIndex = 1;
            this.cbPesquisarPaciente.ValueMember = "ID";
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(468, 52);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(102, 23);
            this.btnPesquisarPaciente.TabIndex = 2;
            this.btnPesquisarPaciente.Text = "Pesquisar";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // dtvListaHistorico
            // 
            this.dtvListaHistorico.AllowUserToAddRows = false;
            this.dtvListaHistorico.AllowUserToDeleteRows = false;
            this.dtvListaHistorico.AllowUserToResizeColumns = false;
            this.dtvListaHistorico.AllowUserToResizeRows = false;
            this.dtvListaHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvListaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListaHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomePaciente,
            this.PacienteBack,
            this.PacienteID,
            this.NomeMedico,
            this.MedicoBack,
            this.MedicoID,
            this.DataConsulta,
            this.HoraInicio,
            this.HoraFIm,
            this.Anotacoes});
            this.dtvListaHistorico.Location = new System.Drawing.Point(13, 97);
            this.dtvListaHistorico.MultiSelect = false;
            this.dtvListaHistorico.Name = "dtvListaHistorico";
            this.dtvListaHistorico.ReadOnly = true;
            this.dtvListaHistorico.RowHeadersVisible = false;
            this.dtvListaHistorico.RowTemplate.Height = 25;
            this.dtvListaHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvListaHistorico.Size = new System.Drawing.Size(557, 341);
            this.dtvListaHistorico.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.FillWeight = 35F;
            this.NomePaciente.HeaderText = "Nome do Paciênte";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            // 
            // PacienteBack
            // 
            this.PacienteBack.DataPropertyName = "Paciente";
            this.PacienteBack.HeaderText = "PacienteBack";
            this.PacienteBack.Name = "PacienteBack";
            this.PacienteBack.ReadOnly = true;
            this.PacienteBack.Visible = false;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteId";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            this.PacienteID.Visible = false;
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMedico.DataPropertyName = "NomeMedico";
            this.NomeMedico.FillWeight = 35F;
            this.NomeMedico.HeaderText = "Nome do Médico";
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.ReadOnly = true;
            // 
            // MedicoBack
            // 
            this.MedicoBack.DataPropertyName = "Medico";
            this.MedicoBack.HeaderText = "MedicoBack";
            this.MedicoBack.Name = "MedicoBack";
            this.MedicoBack.ReadOnly = true;
            this.MedicoBack.Visible = false;
            // 
            // MedicoID
            // 
            this.MedicoID.DataPropertyName = "MedicoId";
            this.MedicoID.HeaderText = "MedicoID";
            this.MedicoID.Name = "MedicoID";
            this.MedicoID.ReadOnly = true;
            this.MedicoID.Visible = false;
            // 
            // DataConsulta
            // 
            this.DataConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataConsulta.DataPropertyName = "DataHoraConsulta";
            this.DataConsulta.FillWeight = 30F;
            this.DataConsulta.HeaderText = "Data da Consulta";
            this.DataConsulta.Name = "DataConsulta";
            this.DataConsulta.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "HoraInicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Visible = false;
            // 
            // HoraFIm
            // 
            this.HoraFIm.DataPropertyName = "HoraFim";
            this.HoraFIm.HeaderText = "HoraFim";
            this.HoraFIm.Name = "HoraFIm";
            this.HoraFIm.ReadOnly = true;
            this.HoraFIm.Visible = false;
            // 
            // Anotacoes
            // 
            this.Anotacoes.DataPropertyName = "Anotacoes";
            this.Anotacoes.HeaderText = "Anotacoes";
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.ReadOnly = true;
            this.Anotacoes.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerAnotacoes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // VerAnotacoes
            // 
            this.VerAnotacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VerAnotacoes.Image = global::Clinica_Médica.Properties.Resources._211661_eye_icon;
            this.VerAnotacoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VerAnotacoes.Name = "VerAnotacoes";
            this.VerAnotacoes.Size = new System.Drawing.Size(23, 22);
            this.VerAnotacoes.Text = "Ver Anotações";
            this.VerAnotacoes.Click += new System.EventHandler(this.VerAnotacoes_Click);
            // 
            // Historico_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtvListaHistorico);
            this.Controls.Add(this.btnPesquisarPaciente);
            this.Controls.Add(this.cbPesquisarPaciente);
            this.Controls.Add(this.lblNomePacienteFiltro);
            this.Name = "Historico_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico Paciênte";
            this.Load += new System.EventHandler(this.Historico_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListaHistorico)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePacienteFiltro;
        private System.Windows.Forms.ComboBox cbPesquisarPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.DataGridView dtvListaHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton VerAnotacoes;
    }
}