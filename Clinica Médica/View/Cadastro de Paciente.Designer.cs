
namespace Clinica_Médica.View
{
    partial class Cadastro_de_Paciente
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
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.dtpDataNascimentoPaciente = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonePaciente = new System.Windows.Forms.TextBox();
            this.txtProfissaoPaciente = new System.Windows.Forms.TextBox();
            this.btnCadastroPaciente = new System.Windows.Forms.Button();
            this.errorCadastroPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCadastroPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(13, 13);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(40, 15);
            this.lblNomePaciente.TabIndex = 0;
            this.lblNomePaciente.Text = "Nome";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(13, 73);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascimento.TabIndex = 1;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(12, 191);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(55, 15);
            this.lblProfissao.TabIndex = 3;
            this.lblProfissao.Text = "Profissão";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(13, 31);
            this.txtNomePaciente.MaxLength = 250;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.PlaceholderText = "digite o nome completo";
            this.txtNomePaciente.Size = new System.Drawing.Size(300, 23);
            this.txtNomePaciente.TabIndex = 4;
            // 
            // dtpDataNascimentoPaciente
            // 
            this.dtpDataNascimentoPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoPaciente.Location = new System.Drawing.Point(13, 92);
            this.dtpDataNascimentoPaciente.Name = "dtpDataNascimentoPaciente";
            this.dtpDataNascimentoPaciente.Size = new System.Drawing.Size(300, 23);
            this.dtpDataNascimentoPaciente.TabIndex = 5;
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.Location = new System.Drawing.Point(14, 148);
            this.txtTelefonePaciente.MaxLength = 20;
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.PlaceholderText = "digite seu telefone o contato";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(299, 23);
            this.txtTelefonePaciente.TabIndex = 6;
            // 
            // txtProfissaoPaciente
            // 
            this.txtProfissaoPaciente.Location = new System.Drawing.Point(14, 209);
            this.txtProfissaoPaciente.MaxLength = 250;
            this.txtProfissaoPaciente.Name = "txtProfissaoPaciente";
            this.txtProfissaoPaciente.PlaceholderText = "digite a profissão";
            this.txtProfissaoPaciente.Size = new System.Drawing.Size(300, 23);
            this.txtProfissaoPaciente.TabIndex = 7;
            // 
            // btnCadastroPaciente
            // 
            this.btnCadastroPaciente.Location = new System.Drawing.Point(14, 253);
            this.btnCadastroPaciente.Name = "btnCadastroPaciente";
            this.btnCadastroPaciente.Size = new System.Drawing.Size(114, 35);
            this.btnCadastroPaciente.TabIndex = 8;
            this.btnCadastroPaciente.Text = "Cadastrar";
            this.btnCadastroPaciente.UseVisualStyleBackColor = true;
            this.btnCadastroPaciente.Click += new System.EventHandler(this.btnCadastroPaciente_Click);
            // 
            // errorCadastroPaciente
            // 
            this.errorCadastroPaciente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCadastroPaciente.ContainerControl = this;
            // 
            // Cadastro_de_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 316);
            this.Controls.Add(this.btnCadastroPaciente);
            this.Controls.Add(this.txtProfissaoPaciente);
            this.Controls.Add(this.txtTelefonePaciente);
            this.Controls.Add(this.dtpDataNascimentoPaciente);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNomePaciente);
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paciente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_de_Paciente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorCadastroPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoPaciente;
        private System.Windows.Forms.TextBox txtTelefonePaciente;
        private System.Windows.Forms.TextBox txtProfissaoPaciente;
        private System.Windows.Forms.Button btnCadastroPaciente;
        private System.Windows.Forms.ErrorProvider errorCadastroPaciente;
    }
}