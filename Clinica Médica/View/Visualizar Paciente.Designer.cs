
namespace Clinica_Médica.View
{
    partial class Visualizar_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizar_Paciente));
            this.lblPesquisarNome = new System.Windows.Forms.Label();
            this.lblPesquisarDataNascimento = new System.Windows.Forms.Label();
            this.lblPesquisarTelefone = new System.Windows.Forms.Label();
            this.lblPesquisarProfissao = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoPaciente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.editarPaciente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removerPaciente = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.dtPesquisaDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisaTelefone = new System.Windows.Forms.TextBox();
            this.txtPesquisaProfissao = new System.Windows.Forms.TextBox();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimentoHide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Nascimento_Back_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvPacientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimentoView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisarNome
            // 
            this.lblPesquisarNome.AutoSize = true;
            this.lblPesquisarNome.Location = new System.Drawing.Point(13, 39);
            this.lblPesquisarNome.Name = "lblPesquisarNome";
            this.lblPesquisarNome.Size = new System.Drawing.Size(40, 15);
            this.lblPesquisarNome.TabIndex = 1;
            this.lblPesquisarNome.Text = "Nome";
            // 
            // lblPesquisarDataNascimento
            // 
            this.lblPesquisarDataNascimento.AutoSize = true;
            this.lblPesquisarDataNascimento.Location = new System.Drawing.Point(509, 39);
            this.lblPesquisarDataNascimento.Name = "lblPesquisarDataNascimento";
            this.lblPesquisarDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblPesquisarDataNascimento.TabIndex = 2;
            this.lblPesquisarDataNascimento.Text = "Data de Nascimento";
            // 
            // lblPesquisarTelefone
            // 
            this.lblPesquisarTelefone.AutoSize = true;
            this.lblPesquisarTelefone.Location = new System.Drawing.Point(13, 100);
            this.lblPesquisarTelefone.Name = "lblPesquisarTelefone";
            this.lblPesquisarTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblPesquisarTelefone.TabIndex = 3;
            this.lblPesquisarTelefone.Text = "Telefone";
            // 
            // lblPesquisarProfissao
            // 
            this.lblPesquisarProfissao.AutoSize = true;
            this.lblPesquisarProfissao.Location = new System.Drawing.Point(369, 100);
            this.lblPesquisarProfissao.Name = "lblPesquisarProfissao";
            this.lblPesquisarProfissao.Size = new System.Drawing.Size(55, 15);
            this.lblPesquisarProfissao.TabIndex = 4;
            this.lblPesquisarProfissao.Text = "Profissão";
            this.lblPesquisarProfissao.Click += new System.EventHandler(this.lblPesquisarProfissao_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPaciente,
            this.toolStripSeparator,
            this.editarPaciente,
            this.toolStripSeparator1,
            this.removerPaciente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoPaciente
            // 
            this.novoPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoPaciente.Image = ((System.Drawing.Image)(resources.GetObject("novoPaciente.Image")));
            this.novoPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoPaciente.Name = "novoPaciente";
            this.novoPaciente.Size = new System.Drawing.Size(23, 22);
            this.novoPaciente.Text = "Novo Paciente";
            this.novoPaciente.Click += new System.EventHandler(this.novoPaciente_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // editarPaciente
            // 
            this.editarPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("editarPaciente.Image")));
            this.editarPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editarPaciente.Name = "editarPaciente";
            this.editarPaciente.Size = new System.Drawing.Size(23, 22);
            this.editarPaciente.Text = "Editar Paciente";
            this.editarPaciente.Click += new System.EventHandler(this.editarPaciente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // removerPaciente
            // 
            this.removerPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removerPaciente.Image = global::Clinica_Médica.Properties.Resources._623068_trashcan_delete_empty_garbage_recycle_icon;
            this.removerPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removerPaciente.Name = "removerPaciente";
            this.removerPaciente.Size = new System.Drawing.Size(23, 22);
            this.removerPaciente.Text = "Remover";
            this.removerPaciente.Click += new System.EventHandler(this.removerPaciente_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(12, 58);
            this.txtPesquisaNome.MaxLength = 250;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.PlaceholderText = "digite o nome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(476, 23);
            this.txtPesquisaNome.TabIndex = 6;
            // 
            // dtPesquisaDataNascimento
            // 
            this.dtPesquisaDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPesquisaDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPesquisaDataNascimento.Location = new System.Drawing.Point(509, 58);
            this.dtPesquisaDataNascimento.Name = "dtPesquisaDataNascimento";
            this.dtPesquisaDataNascimento.Size = new System.Drawing.Size(206, 23);
            this.dtPesquisaDataNascimento.TabIndex = 7;
            // 
            // txtPesquisaTelefone
            // 
            this.txtPesquisaTelefone.Location = new System.Drawing.Point(13, 118);
            this.txtPesquisaTelefone.MaxLength = 20;
            this.txtPesquisaTelefone.Name = "txtPesquisaTelefone";
            this.txtPesquisaTelefone.PlaceholderText = "digite o telefone";
            this.txtPesquisaTelefone.Size = new System.Drawing.Size(335, 23);
            this.txtPesquisaTelefone.TabIndex = 8;
            // 
            // txtPesquisaProfissao
            // 
            this.txtPesquisaProfissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaProfissao.Location = new System.Drawing.Point(369, 118);
            this.txtPesquisaProfissao.MaxLength = 250;
            this.txtPesquisaProfissao.Name = "txtPesquisaProfissao";
            this.txtPesquisaProfissao.PlaceholderText = "digite a profissão";
            this.txtPesquisaProfissao.Size = new System.Drawing.Size(348, 23);
            this.txtPesquisaProfissao.TabIndex = 9;
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(13, 164);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(128, 35);
            this.btnPesquisarPaciente.TabIndex = 10;
            this.btnPesquisarPaciente.Text = "Pesquisar";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
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
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 30F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // DataNascimentoHide
            // 
            this.DataNascimentoHide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataNascimentoHide.DataPropertyName = "DataNascimento";
            this.DataNascimentoHide.FillWeight = 20F;
            this.DataNascimentoHide.HeaderText = "Data de Nascimento";
            this.DataNascimentoHide.Name = "DataNascimentoHide";
            this.DataNascimentoHide.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Data_de_Nascimento_Back_End
            // 
            this.Data_de_Nascimento_Back_End.DataPropertyName = "DataNascimento";
            this.Data_de_Nascimento_Back_End.HeaderText = "Data_de_Nascimento_Back_End";
            this.Data_de_Nascimento_Back_End.Name = "Data_de_Nascimento_Back_End";
            this.Data_de_Nascimento_Back_End.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dtvPacientes
            // 
            this.dtvPacientes.AllowUserToAddRows = false;
            this.dtvPacientes.AllowUserToDeleteRows = false;
            this.dtvPacientes.AllowUserToResizeColumns = false;
            this.dtvPacientes.AllowUserToResizeRows = false;
            this.dtvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.DataNascimento,
            this.DataNascimentoView,
            this.Telefone,
            this.Profissão});
            this.dtvPacientes.Location = new System.Drawing.Point(13, 231);
            this.dtvPacientes.MultiSelect = false;
            this.dtvPacientes.Name = "dtvPacientes";
            this.dtvPacientes.ReadOnly = true;
            this.dtvPacientes.RowHeadersVisible = false;
            this.dtvPacientes.RowTemplate.Height = 25;
            this.dtvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvPacientes.Size = new System.Drawing.Size(702, 420);
            this.dtvPacientes.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn8.FillWeight = 30F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "DataNascimento";
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            this.DataNascimento.Visible = false;
            // 
            // DataNascimentoView
            // 
            this.DataNascimentoView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataNascimentoView.DataPropertyName = "DataView";
            this.DataNascimentoView.FillWeight = 20F;
            this.DataNascimentoView.HeaderText = "Data de Nascimento";
            this.DataNascimentoView.Name = "DataNascimentoView";
            this.DataNascimentoView.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.FillWeight = 25F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Profissão
            // 
            this.Profissão.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profissão.DataPropertyName = "Profissao";
            this.Profissão.FillWeight = 25F;
            this.Profissão.HeaderText = "Profissão";
            this.Profissão.Name = "Profissão";
            this.Profissão.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn6.FillWeight = 30F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Visualizar_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 663);
            this.Controls.Add(this.dtvPacientes);
            this.Controls.Add(this.btnPesquisarPaciente);
            this.Controls.Add(this.txtPesquisaProfissao);
            this.Controls.Add(this.txtPesquisaTelefone);
            this.Controls.Add(this.dtPesquisaDataNascimento);
            this.Controls.Add(this.txtPesquisaNome);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblPesquisarProfissao);
            this.Controls.Add(this.lblPesquisarTelefone);
            this.Controls.Add(this.lblPesquisarDataNascimento);
            this.Controls.Add(this.lblPesquisarNome);
            this.Name = "Visualizar_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Paciente";
            this.Load += new System.EventHandler(this.Visualizar_Paciente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPesquisarNome;
        private System.Windows.Forms.Label lblPesquisarDataNascimento;
        private System.Windows.Forms.Label lblPesquisarTelefone;
        private System.Windows.Forms.Label lblPesquisarProfissao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton editarPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removerPaciente;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.DateTimePicker dtPesquisaDataNascimento;
        private System.Windows.Forms.TextBox txtPesquisaTelefone;
        private System.Windows.Forms.TextBox txtPesquisaProfissao;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimentoHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Nascimento_Back_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dvPaciente;
        private System.Windows.Forms.DataGridView dtvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimentoView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissão;
    }
}