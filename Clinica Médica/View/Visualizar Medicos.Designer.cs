
namespace Clinica_Médica.View
{
    partial class Visualizar_Medicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Medicos));
            this.dtvVisualizarMedicos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.txtPesquisaCRM = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoMedico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editarMedico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.deletarMedico = new System.Windows.Forms.ToolStripButton();
            this.cbPesquisaEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVisualizarMedicos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvVisualizarMedicos
            // 
            this.dtvVisualizarMedicos.AllowUserToAddRows = false;
            this.dtvVisualizarMedicos.AllowUserToDeleteRows = false;
            this.dtvVisualizarMedicos.AllowUserToResizeColumns = false;
            this.dtvVisualizarMedicos.AllowUserToResizeRows = false;
            this.dtvVisualizarMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvVisualizarMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvVisualizarMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CRM,
            this.Nome,
            this.TempoMedio,
            this.Especialidade,
            this.EspecialidadeMedico,
            this.EspecialidadeId});
            this.dtvVisualizarMedicos.Location = new System.Drawing.Point(11, 215);
            this.dtvVisualizarMedicos.MultiSelect = false;
            this.dtvVisualizarMedicos.Name = "dtvVisualizarMedicos";
            this.dtvVisualizarMedicos.ReadOnly = true;
            this.dtvVisualizarMedicos.RowHeadersVisible = false;
            this.dtvVisualizarMedicos.RowTemplate.Height = 25;
            this.dtvVisualizarMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVisualizarMedicos.Size = new System.Drawing.Size(735, 439);
            this.dtvVisualizarMedicos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 15F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CRM
            // 
            this.CRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CRM.DataPropertyName = "CRM";
            this.CRM.FillWeight = 15F;
            this.CRM.HeaderText = "CRM";
            this.CRM.Name = "CRM";
            this.CRM.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 35F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // TempoMedio
            // 
            this.TempoMedio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TempoMedio.DataPropertyName = "TempoMedio";
            this.TempoMedio.FillWeight = 20F;
            this.TempoMedio.HeaderText = "Tempo Médio";
            this.TempoMedio.Name = "TempoMedio";
            this.TempoMedio.ReadOnly = true;
            // 
            // Especialidade
            // 
            this.Especialidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especialidade.DataPropertyName = "NomeEspecialidade";
            this.Especialidade.FillWeight = 30F;
            this.Especialidade.HeaderText = "Especialidade";
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.ReadOnly = true;
            // 
            // EspecialidadeMedico
            // 
            this.EspecialidadeMedico.DataPropertyName = "Especialidade";
            this.EspecialidadeMedico.HeaderText = "EspecialidadeMedico";
            this.EspecialidadeMedico.Name = "EspecialidadeMedico";
            this.EspecialidadeMedico.ReadOnly = true;
            this.EspecialidadeMedico.Visible = false;
            // 
            // EspecialidadeId
            // 
            this.EspecialidadeId.DataPropertyName = "EspecialidadeId";
            this.EspecialidadeId.HeaderText = "EspecialidadeId";
            this.EspecialidadeId.Name = "EspecialidadeId";
            this.EspecialidadeId.ReadOnly = true;
            this.EspecialidadeId.Visible = false;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(346, 97);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(33, 15);
            this.lblCRM.TabIndex = 1;
            this.lblCRM.Text = "CRM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(11, 96);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(78, 15);
            this.lblEspecialidade.TabIndex = 3;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(13, 55);
            this.txtPesquisaNome.MaxLength = 250;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.PlaceholderText = "digite o nome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(734, 23);
            this.txtPesquisaNome.TabIndex = 2;
            // 
            // txtPesquisaCRM
            // 
            this.txtPesquisaCRM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaCRM.Location = new System.Drawing.Point(346, 115);
            this.txtPesquisaCRM.MaxLength = 12;
            this.txtPesquisaCRM.Name = "txtPesquisaCRM";
            this.txtPesquisaCRM.PlaceholderText = "digite o crm";
            this.txtPesquisaCRM.Size = new System.Drawing.Size(401, 23);
            this.txtPesquisaCRM.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoMedico,
            this.toolStripSeparator1,
            this.editarMedico,
            this.toolStripSeparator,
            this.deletarMedico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoMedico
            // 
            this.novoMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoMedico.Image = ((System.Drawing.Image)(resources.GetObject("novoMedico.Image")));
            this.novoMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoMedico.Name = "novoMedico";
            this.novoMedico.Size = new System.Drawing.Size(23, 22);
            this.novoMedico.Text = "Novo Médico";
            this.novoMedico.Click += new System.EventHandler(this.novoMedico_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // editarMedico
            // 
            this.editarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editarMedico.Image = ((System.Drawing.Image)(resources.GetObject("editarMedico.Image")));
            this.editarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarMedico.Name = "editarMedico";
            this.editarMedico.Size = new System.Drawing.Size(23, 22);
            this.editarMedico.Text = "Editar Médico";
            this.editarMedico.Click += new System.EventHandler(this.editarMedico_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // deletarMedico
            // 
            this.deletarMedico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletarMedico.Image = global::Clinica_Médica.Properties.Resources._623068_trashcan_delete_empty_garbage_recycle_icon;
            this.deletarMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletarMedico.Name = "deletarMedico";
            this.deletarMedico.Size = new System.Drawing.Size(23, 22);
            this.deletarMedico.Text = "Remover Médico";
            this.deletarMedico.Click += new System.EventHandler(this.deletarMedico_Click);
            // 
            // cbPesquisaEspecialidade
            // 
            this.cbPesquisaEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPesquisaEspecialidade.DisplayMember = "NomeEspecialidade";
            this.cbPesquisaEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaEspecialidade.FormattingEnabled = true;
            this.cbPesquisaEspecialidade.Location = new System.Drawing.Point(14, 115);
            this.cbPesquisaEspecialidade.Name = "cbPesquisaEspecialidade";
            this.cbPesquisaEspecialidade.Size = new System.Drawing.Size(308, 23);
            this.cbPesquisaEspecialidade.TabIndex = 3;
            this.cbPesquisaEspecialidade.ValueMember = "ID";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(14, 157);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 33);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Visualizar_Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 666);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbPesquisaEspecialidade);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtPesquisaCRM);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.dtvVisualizarMedicos);
            this.Name = "Visualizar_Medicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Médicos";
            this.Load += new System.EventHandler(this.Visualizar_Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVisualizarMedicos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvVisualizarMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadeId;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.TextBox txtPesquisaCRM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton editarMedico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton deletarMedico;
        private System.Windows.Forms.ComboBox cbPesquisaEspecialidade;
        private System.Windows.Forms.Button btnPesquisar;
    }
}