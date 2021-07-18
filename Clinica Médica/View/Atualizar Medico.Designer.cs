
namespace Clinica_Médica.View
{
    partial class Atualizar_Medico
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
            this.lblEditarCRM = new System.Windows.Forms.Label();
            this.lblAtualizarNome = new System.Windows.Forms.Label();
            this.lblAtualizarTempoMedio = new System.Windows.Forms.Label();
            this.lblAtualizarEspecialidade = new System.Windows.Forms.Label();
            this.txtAtualizarCRM = new System.Windows.Forms.TextBox();
            this.txtAtualizarNome = new System.Windows.Forms.TextBox();
            this.dtAtualizarTempoMedio = new System.Windows.Forms.DateTimePicker();
            this.cbAtualizarEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnAtualizarMedico = new System.Windows.Forms.Button();
            this.errorAtualizarMedico = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarCRM
            // 
            this.lblEditarCRM.AutoSize = true;
            this.lblEditarCRM.Location = new System.Drawing.Point(13, 13);
            this.lblEditarCRM.Name = "lblEditarCRM";
            this.lblEditarCRM.Size = new System.Drawing.Size(33, 15);
            this.lblEditarCRM.TabIndex = 0;
            this.lblEditarCRM.Text = "CRM";
            // 
            // lblAtualizarNome
            // 
            this.lblAtualizarNome.AutoSize = true;
            this.lblAtualizarNome.Location = new System.Drawing.Point(13, 67);
            this.lblAtualizarNome.Name = "lblAtualizarNome";
            this.lblAtualizarNome.Size = new System.Drawing.Size(40, 15);
            this.lblAtualizarNome.TabIndex = 1;
            this.lblAtualizarNome.Text = "Nome";
            // 
            // lblAtualizarTempoMedio
            // 
            this.lblAtualizarTempoMedio.AutoSize = true;
            this.lblAtualizarTempoMedio.Location = new System.Drawing.Point(12, 122);
            this.lblAtualizarTempoMedio.Name = "lblAtualizarTempoMedio";
            this.lblAtualizarTempoMedio.Size = new System.Drawing.Size(146, 15);
            this.lblAtualizarTempoMedio.TabIndex = 2;
            this.lblAtualizarTempoMedio.Text = "Tëmpo Médio da Consulta";
            // 
            // lblAtualizarEspecialidade
            // 
            this.lblAtualizarEspecialidade.AutoSize = true;
            this.lblAtualizarEspecialidade.Location = new System.Drawing.Point(13, 181);
            this.lblAtualizarEspecialidade.Name = "lblAtualizarEspecialidade";
            this.lblAtualizarEspecialidade.Size = new System.Drawing.Size(78, 15);
            this.lblAtualizarEspecialidade.TabIndex = 3;
            this.lblAtualizarEspecialidade.Text = "Especialidade";
            // 
            // txtAtualizarCRM
            // 
            this.txtAtualizarCRM.Location = new System.Drawing.Point(13, 31);
            this.txtAtualizarCRM.MaxLength = 12;
            this.txtAtualizarCRM.Name = "txtAtualizarCRM";
            this.txtAtualizarCRM.PlaceholderText = "digite o crm";
            this.txtAtualizarCRM.Size = new System.Drawing.Size(341, 23);
            this.txtAtualizarCRM.TabIndex = 4;
            // 
            // txtAtualizarNome
            // 
            this.txtAtualizarNome.Location = new System.Drawing.Point(13, 85);
            this.txtAtualizarNome.MaxLength = 250;
            this.txtAtualizarNome.Name = "txtAtualizarNome";
            this.txtAtualizarNome.PlaceholderText = "digite o nome";
            this.txtAtualizarNome.Size = new System.Drawing.Size(341, 23);
            this.txtAtualizarNome.TabIndex = 5;
            // 
            // dtAtualizarTempoMedio
            // 
            this.dtAtualizarTempoMedio.CustomFormat = "HH:mm:ss";
            this.dtAtualizarTempoMedio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAtualizarTempoMedio.Location = new System.Drawing.Point(13, 140);
            this.dtAtualizarTempoMedio.Name = "dtAtualizarTempoMedio";
            this.dtAtualizarTempoMedio.Size = new System.Drawing.Size(341, 23);
            this.dtAtualizarTempoMedio.TabIndex = 6;
            this.dtAtualizarTempoMedio.Value = new System.DateTime(2021, 7, 13, 0, 0, 0, 0);
            // 
            // cbAtualizarEspecialidade
            // 
            this.cbAtualizarEspecialidade.DisplayMember = "NomeEspecialidade";
            this.cbAtualizarEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtualizarEspecialidade.FormattingEnabled = true;
            this.cbAtualizarEspecialidade.Location = new System.Drawing.Point(13, 200);
            this.cbAtualizarEspecialidade.Name = "cbAtualizarEspecialidade";
            this.cbAtualizarEspecialidade.Size = new System.Drawing.Size(341, 23);
            this.cbAtualizarEspecialidade.TabIndex = 7;
            this.cbAtualizarEspecialidade.ValueMember = "ID";
            // 
            // btnAtualizarMedico
            // 
            this.btnAtualizarMedico.Location = new System.Drawing.Point(13, 249);
            this.btnAtualizarMedico.Name = "btnAtualizarMedico";
            this.btnAtualizarMedico.Size = new System.Drawing.Size(108, 34);
            this.btnAtualizarMedico.TabIndex = 8;
            this.btnAtualizarMedico.Text = "Atualizar";
            this.btnAtualizarMedico.UseVisualStyleBackColor = true;
            this.btnAtualizarMedico.Click += new System.EventHandler(this.btnAtualizarMedico_Click);
            // 
            // errorAtualizarMedico
            // 
            this.errorAtualizarMedico.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAtualizarMedico.ContainerControl = this;
            // 
            // Atualizar_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 315);
            this.Controls.Add(this.btnAtualizarMedico);
            this.Controls.Add(this.cbAtualizarEspecialidade);
            this.Controls.Add(this.dtAtualizarTempoMedio);
            this.Controls.Add(this.txtAtualizarNome);
            this.Controls.Add(this.txtAtualizarCRM);
            this.Controls.Add(this.lblAtualizarEspecialidade);
            this.Controls.Add(this.lblAtualizarTempoMedio);
            this.Controls.Add(this.lblAtualizarNome);
            this.Controls.Add(this.lblEditarCRM);
            this.MinimizeBox = false;
            this.Name = "Atualizar_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Medico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atualizar_Medico_FormClosing);
            this.Load += new System.EventHandler(this.Atualizar_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarCRM;
        private System.Windows.Forms.Label lblAtualizarNome;
        private System.Windows.Forms.Label lblAtualizarTempoMedio;
        private System.Windows.Forms.Label lblAtualizarEspecialidade;
        private System.Windows.Forms.TextBox txtAtualizarCRM;
        private System.Windows.Forms.TextBox txtAtualizarNome;
        private System.Windows.Forms.DateTimePicker dtAtualizarTempoMedio;
        private System.Windows.Forms.ComboBox cbAtualizarEspecialidade;
        private System.Windows.Forms.Button btnAtualizarMedico;
        private System.Windows.Forms.ErrorProvider errorAtualizarMedico;
    }
}