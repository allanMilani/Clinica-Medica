
namespace Clinica_Médica.View
{
    partial class VisualizarEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarEspecialidades));
            this.dtvEspecialidades = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPesquisarEspecialidade = new System.Windows.Forms.Label();
            this.txtPesquisarEspecialidade = new System.Windows.Forms.TextBox();
            this.btnPesquisarEspecialidade = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nova_especialidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.atualizar_especialidade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirEspecialidade = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEspecialidades)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvEspecialidades
            // 
            this.dtvEspecialidades.AllowUserToAddRows = false;
            this.dtvEspecialidades.AllowUserToDeleteRows = false;
            this.dtvEspecialidades.AllowUserToResizeColumns = false;
            this.dtvEspecialidades.AllowUserToResizeRows = false;
            this.dtvEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome});
            this.dtvEspecialidades.Location = new System.Drawing.Point(12, 92);
            this.dtvEspecialidades.MultiSelect = false;
            this.dtvEspecialidades.Name = "dtvEspecialidades";
            this.dtvEspecialidades.ReadOnly = true;
            this.dtvEspecialidades.RowHeadersVisible = false;
            this.dtvEspecialidades.RowTemplate.Height = 25;
            this.dtvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEspecialidades.Size = new System.Drawing.Size(460, 424);
            this.dtvEspecialidades.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "NomeEspecialidade";
            this.Nome.HeaderText = "Especialidade";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // lblPesquisarEspecialidade
            // 
            this.lblPesquisarEspecialidade.AutoSize = true;
            this.lblPesquisarEspecialidade.Location = new System.Drawing.Point(12, 35);
            this.lblPesquisarEspecialidade.Name = "lblPesquisarEspecialidade";
            this.lblPesquisarEspecialidade.Size = new System.Drawing.Size(57, 15);
            this.lblPesquisarEspecialidade.TabIndex = 1;
            this.lblPesquisarEspecialidade.Text = "Pesquisar";
            // 
            // txtPesquisarEspecialidade
            // 
            this.txtPesquisarEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarEspecialidade.Location = new System.Drawing.Point(12, 54);
            this.txtPesquisarEspecialidade.Name = "txtPesquisarEspecialidade";
            this.txtPesquisarEspecialidade.Size = new System.Drawing.Size(365, 23);
            this.txtPesquisarEspecialidade.TabIndex = 2;
            // 
            // btnPesquisarEspecialidade
            // 
            this.btnPesquisarEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarEspecialidade.Location = new System.Drawing.Point(384, 54);
            this.btnPesquisarEspecialidade.Name = "btnPesquisarEspecialidade";
            this.btnPesquisarEspecialidade.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisarEspecialidade.TabIndex = 3;
            this.btnPesquisarEspecialidade.Text = "Pesquisar";
            this.btnPesquisarEspecialidade.UseVisualStyleBackColor = true;
            this.btnPesquisarEspecialidade.Click += new System.EventHandler(this.btnPesquisarEspecialidade_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nova_especialidade,
            this.toolStripSeparator1,
            this.atualizar_especialidade,
            this.toolStripSeparator2,
            this.excluirEspecialidade});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nova_especialidade
            // 
            this.nova_especialidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nova_especialidade.Image = ((System.Drawing.Image)(resources.GetObject("nova_especialidade.Image")));
            this.nova_especialidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nova_especialidade.Name = "nova_especialidade";
            this.nova_especialidade.Size = new System.Drawing.Size(23, 22);
            this.nova_especialidade.Text = "Nova Especialidade";
            this.nova_especialidade.Click += new System.EventHandler(this.nova_especialidade_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // atualizar_especialidade
            // 
            this.atualizar_especialidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atualizar_especialidade.Image = ((System.Drawing.Image)(resources.GetObject("atualizar_especialidade.Image")));
            this.atualizar_especialidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.atualizar_especialidade.Name = "atualizar_especialidade";
            this.atualizar_especialidade.Size = new System.Drawing.Size(23, 22);
            this.atualizar_especialidade.Text = "Atualizar Especialidade";
            this.atualizar_especialidade.Click += new System.EventHandler(this.atualizar_especialidade_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // excluirEspecialidade
            // 
            this.excluirEspecialidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.excluirEspecialidade.Image = ((System.Drawing.Image)(resources.GetObject("excluirEspecialidade.Image")));
            this.excluirEspecialidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirEspecialidade.Name = "excluirEspecialidade";
            this.excluirEspecialidade.Size = new System.Drawing.Size(23, 22);
            this.excluirEspecialidade.Text = "Excluir Especialidade";
            this.excluirEspecialidade.Click += new System.EventHandler(this.excluirEspecialidade_Click);
            // 
            // VisualizarEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 528);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnPesquisarEspecialidade);
            this.Controls.Add(this.txtPesquisarEspecialidade);
            this.Controls.Add(this.lblPesquisarEspecialidade);
            this.Controls.Add(this.dtvEspecialidades);
            this.Name = "VisualizarEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.VisualizarEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEspecialidades)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Label lblPesquisarEspecialidade;
        private System.Windows.Forms.TextBox txtPesquisarEspecialidade;
        private System.Windows.Forms.Button btnPesquisarEspecialidade;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nova_especialidade;
        private System.Windows.Forms.ToolStripButton atualizar_especialidade;
        private System.Windows.Forms.ToolStripButton excluirEspecialidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}