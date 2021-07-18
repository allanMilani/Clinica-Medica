
namespace Clinica_Médica.View
{
    partial class Visualizar_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Agenda));
            this.dtvAgendamentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisarMedicoAgenda = new System.Windows.Forms.Label();
            this.lblPesquisarDataAgendada = new System.Windows.Forms.Label();
            this.cbPesquisarMedicoAgenda = new System.Windows.Forms.ComboBox();
            this.dtDataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoAgendamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.editarAgendamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inserirAnotacoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removerAgendamento = new System.Windows.Forms.ToolStripButton();
            this.lblAgendaDia = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAgendamentos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvAgendamentos
            // 
            this.dtvAgendamentos.AllowUserToAddRows = false;
            this.dtvAgendamentos.AllowUserToDeleteRows = false;
            this.dtvAgendamentos.AllowUserToResizeColumns = false;
            this.dtvAgendamentos.AllowUserToResizeRows = false;
            this.dtvAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NomeMedico,
            this.Medico,
            this.idMedico,
            this.NomePaciente,
            this.objPaciente,
            this.IdPaciente,
            this.Agendamento,
            this.HoraInicio,
            this.HoraFim,
            this.Anotacoes});
            this.dtvAgendamentos.Location = new System.Drawing.Point(13, 176);
            this.dtvAgendamentos.MultiSelect = false;
            this.dtvAgendamentos.Name = "dtvAgendamentos";
            this.dtvAgendamentos.ReadOnly = true;
            this.dtvAgendamentos.RowHeadersVisible = false;
            this.dtvAgendamentos.RowTemplate.Height = 25;
            this.dtvAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvAgendamentos.Size = new System.Drawing.Size(568, 388);
            this.dtvAgendamentos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMedico.DataPropertyName = "NomeMedico";
            this.NomeMedico.FillWeight = 40F;
            this.NomeMedico.HeaderText = "Nome do Médico";
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.DataPropertyName = "Medico";
            this.Medico.HeaderText = "Medico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Visible = false;
            // 
            // idMedico
            // 
            this.idMedico.DataPropertyName = "MedicoId";
            this.idMedico.HeaderText = "MedicoId";
            this.idMedico.Name = "idMedico";
            this.idMedico.ReadOnly = true;
            this.idMedico.Visible = false;
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.FillWeight = 40F;
            this.NomePaciente.HeaderText = "Nome do Paciênte";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            // 
            // objPaciente
            // 
            this.objPaciente.DataPropertyName = "Paciente";
            this.objPaciente.HeaderText = "Paciente";
            this.objPaciente.Name = "objPaciente";
            this.objPaciente.ReadOnly = true;
            this.objPaciente.Visible = false;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "PacienteId";
            this.IdPaciente.HeaderText = "PacienteId";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Visible = false;
            // 
            // Agendamento
            // 
            this.Agendamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Agendamento.DataPropertyName = "DataHoraConsulta";
            this.Agendamento.FillWeight = 20F;
            this.Agendamento.HeaderText = "Agendamento";
            this.Agendamento.Name = "Agendamento";
            this.Agendamento.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Visible = false;
            // 
            // HoraFim
            // 
            this.HoraFim.DataPropertyName = "HoraFim";
            this.HoraFim.HeaderText = "Hora Fim";
            this.HoraFim.Name = "HoraFim";
            this.HoraFim.ReadOnly = true;
            this.HoraFim.Visible = false;
            // 
            // Anotacoes
            // 
            this.Anotacoes.DataPropertyName = "Anotacoes";
            this.Anotacoes.HeaderText = "Anotacoes";
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.ReadOnly = true;
            this.Anotacoes.Visible = false;
            // 
            // lblPesquisarMedicoAgenda
            // 
            this.lblPesquisarMedicoAgenda.AutoSize = true;
            this.lblPesquisarMedicoAgenda.Location = new System.Drawing.Point(13, 45);
            this.lblPesquisarMedicoAgenda.Name = "lblPesquisarMedicoAgenda";
            this.lblPesquisarMedicoAgenda.Size = new System.Drawing.Size(47, 15);
            this.lblPesquisarMedicoAgenda.TabIndex = 1;
            this.lblPesquisarMedicoAgenda.Text = "Médico";
            // 
            // lblPesquisarDataAgendada
            // 
            this.lblPesquisarDataAgendada.AutoSize = true;
            this.lblPesquisarDataAgendada.Location = new System.Drawing.Point(402, 45);
            this.lblPesquisarDataAgendada.Name = "lblPesquisarDataAgendada";
            this.lblPesquisarDataAgendada.Size = new System.Drawing.Size(110, 15);
            this.lblPesquisarDataAgendada.TabIndex = 2;
            this.lblPesquisarDataAgendada.Text = "Data Agendamento";
            // 
            // cbPesquisarMedicoAgenda
            // 
            this.cbPesquisarMedicoAgenda.DisplayMember = "Nome";
            this.cbPesquisarMedicoAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisarMedicoAgenda.FormattingEnabled = true;
            this.cbPesquisarMedicoAgenda.Location = new System.Drawing.Point(13, 64);
            this.cbPesquisarMedicoAgenda.Name = "cbPesquisarMedicoAgenda";
            this.cbPesquisarMedicoAgenda.Size = new System.Drawing.Size(373, 23);
            this.cbPesquisarMedicoAgenda.TabIndex = 3;
            this.cbPesquisarMedicoAgenda.ValueMember = "ID";
            // 
            // dtDataAgendamento
            // 
            this.dtDataAgendamento.CustomFormat = "";
            this.dtDataAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAgendamento.Location = new System.Drawing.Point(402, 64);
            this.dtDataAgendamento.Name = "dtDataAgendamento";
            this.dtDataAgendamento.Size = new System.Drawing.Size(179, 23);
            this.dtDataAgendamento.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAgendamento,
            this.toolStripSeparator,
            this.editarAgendamento,
            this.toolStripSeparator1,
            this.inserirAnotacoes,
            this.toolStripSeparator2,
            this.removerAgendamento});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoAgendamento
            // 
            this.novoAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("novoAgendamento.Image")));
            this.novoAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoAgendamento.Name = "novoAgendamento";
            this.novoAgendamento.Size = new System.Drawing.Size(23, 22);
            this.novoAgendamento.Text = "Novo Agendamento";
            this.novoAgendamento.Click += new System.EventHandler(this.novoAgendamento_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // editarAgendamento
            // 
            this.editarAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editarAgendamento.Image = ((System.Drawing.Image)(resources.GetObject("editarAgendamento.Image")));
            this.editarAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarAgendamento.Name = "editarAgendamento";
            this.editarAgendamento.Size = new System.Drawing.Size(23, 22);
            this.editarAgendamento.Text = "Editar Agendamento";
            this.editarAgendamento.Click += new System.EventHandler(this.editarAgendamento_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // inserirAnotacoes
            // 
            this.inserirAnotacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inserirAnotacoes.Image = global::Clinica_Médica.Properties.Resources._216687_pencil_icon;
            this.inserirAnotacoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inserirAnotacoes.Name = "inserirAnotacoes";
            this.inserirAnotacoes.Size = new System.Drawing.Size(23, 22);
            this.inserirAnotacoes.Text = "Inserir Anotacoes";
            this.inserirAnotacoes.Click += new System.EventHandler(this.inserirAnotacoes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // removerAgendamento
            // 
            this.removerAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removerAgendamento.Image = global::Clinica_Médica.Properties.Resources._623068_trashcan_delete_empty_garbage_recycle_icon;
            this.removerAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removerAgendamento.Name = "removerAgendamento";
            this.removerAgendamento.Size = new System.Drawing.Size(23, 22);
            this.removerAgendamento.Text = "Remover Agendamento";
            this.removerAgendamento.Click += new System.EventHandler(this.removerAgendamento_Click);
            // 
            // lblAgendaDia
            // 
            this.lblAgendaDia.AutoSize = true;
            this.lblAgendaDia.Location = new System.Drawing.Point(12, 158);
            this.lblAgendaDia.Name = "lblAgendaDia";
            this.lblAgendaDia.Size = new System.Drawing.Size(0, 15);
            this.lblAgendaDia.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(12, 105);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 36);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "NomeMedico";
            this.Nome.FillWeight = 40F;
            this.Nome.HeaderText = "Médico";
            this.Nome.Name = "Nome";
            // 
            // MedicoId
            // 
            this.MedicoId.DataPropertyName = "MedicoId";
            this.MedicoId.HeaderText = "MedicoId";
            this.MedicoId.Name = "MedicoId";
            this.MedicoId.Visible = false;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.DataPropertyName = "NomePaciente";
            this.Paciente.FillWeight = 40F;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            // 
            // PacienteId
            // 
            this.PacienteId.DataPropertyName = "PacienteId";
            this.PacienteId.HeaderText = "PacienteId";
            this.PacienteId.Name = "PacienteId";
            this.PacienteId.Visible = false;
            // 
            // Visualizar_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 576);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblAgendaDia);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtDataAgendamento);
            this.Controls.Add(this.cbPesquisarMedicoAgenda);
            this.Controls.Add(this.lblPesquisarDataAgendada);
            this.Controls.Add(this.lblPesquisarMedicoAgenda);
            this.Controls.Add(this.dtvAgendamentos);
            this.Name = "Visualizar_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Agenda";
            this.Load += new System.EventHandler(this.Visualizar_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvAgendamentos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvAgendamentos;
        private System.Windows.Forms.Label lblPesquisarMedicoAgenda;
        private System.Windows.Forms.Label lblPesquisarDataAgendada;
        private System.Windows.Forms.ComboBox cbPesquisarMedicoAgenda;
        private System.Windows.Forms.DateTimePicker dtDataAgendamento;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton editarAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removerAgendamento;
        private System.Windows.Forms.Label lblAgendaDia;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn objPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes;
        private System.Windows.Forms.ToolStripButton inserirAnotacoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}