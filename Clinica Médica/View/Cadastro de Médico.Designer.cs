
namespace Clinica_Médica.View
{
    partial class Cadastro_de_Medico
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
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTempoMedio = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtTempoMedio = new System.Windows.Forms.DateTimePicker();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.errorCadastroMedico = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCadastroMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(13, 13);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(33, 15);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "CRM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblTempoMedio
            // 
            this.lblTempoMedio.AutoSize = true;
            this.lblTempoMedio.Location = new System.Drawing.Point(12, 120);
            this.lblTempoMedio.Name = "lblTempoMedio";
            this.lblTempoMedio.Size = new System.Drawing.Size(146, 15);
            this.lblTempoMedio.TabIndex = 2;
            this.lblTempoMedio.Text = "Tempo Médio da Consulta";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(13, 180);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(78, 15);
            this.lblEspecialidade.TabIndex = 3;
            this.lblEspecialidade.Text = "Especialidade";
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(13, 32);
            this.txtCRM.MaxLength = 12;
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.PlaceholderText = "digite o crm";
            this.txtCRM.Size = new System.Drawing.Size(331, 23);
            this.txtCRM.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 85);
            this.txtNome.MaxLength = 250;
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "digite o nome";
            this.txtNome.Size = new System.Drawing.Size(331, 23);
            this.txtNome.TabIndex = 5;
            // 
            // dtTempoMedio
            // 
            this.dtTempoMedio.CustomFormat = "HH:mm:ss";
            this.dtTempoMedio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTempoMedio.Location = new System.Drawing.Point(13, 139);
            this.dtTempoMedio.Name = "dtTempoMedio";
            this.dtTempoMedio.Size = new System.Drawing.Size(331, 23);
            this.dtTempoMedio.TabIndex = 6;
            this.dtTempoMedio.Value = new System.DateTime(2021, 7, 5, 0, 0, 0, 0);
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.DisplayMember = "NomeEspecialidade";
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(13, 198);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(331, 23);
            this.cbEspecialidade.TabIndex = 7;
            this.cbEspecialidade.ValueMember = "ID";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 38);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // errorCadastroMedico
            // 
            this.errorCadastroMedico.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCadastroMedico.ContainerControl = this;
            // 
            // Cadastro_de_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 322);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.dtTempoMedio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.lblTempoMedio);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCRM);
            this.MinimizeBox = false;
            this.Name = "Cadastro_de_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_de_Medico_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_de_Médico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorCadastroMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTempoMedio;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtTempoMedio;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ErrorProvider errorCadastroMedico;
    }
}