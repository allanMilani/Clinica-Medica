
namespace Clinica_Médica.View
{
    partial class Cadastro_de_Especialidades
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
            this.lblNomeEspecialidade = new System.Windows.Forms.Label();
            this.txtNomeEspecialidade = new System.Windows.Forms.TextBox();
            this.btnCadastroEspecialidade = new System.Windows.Forms.Button();
            this.errorEspecialidade = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeEspecialidade
            // 
            this.lblNomeEspecialidade.AutoSize = true;
            this.lblNomeEspecialidade.Location = new System.Drawing.Point(13, 13);
            this.lblNomeEspecialidade.Name = "lblNomeEspecialidade";
            this.lblNomeEspecialidade.Size = new System.Drawing.Size(133, 15);
            this.lblNomeEspecialidade.TabIndex = 0;
            this.lblNomeEspecialidade.Text = "Nome da Especialidade:";
            // 
            // txtNomeEspecialidade
            // 
            this.txtNomeEspecialidade.Location = new System.Drawing.Point(13, 31);
            this.txtNomeEspecialidade.MaxLength = 100;
            this.txtNomeEspecialidade.Name = "txtNomeEspecialidade";
            this.txtNomeEspecialidade.PlaceholderText = "digite o nome da especialidade";
            this.txtNomeEspecialidade.Size = new System.Drawing.Size(274, 23);
            this.txtNomeEspecialidade.TabIndex = 1;
            this.txtNomeEspecialidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCadastroEspecialidade
            // 
            this.btnCadastroEspecialidade.Location = new System.Drawing.Point(13, 69);
            this.btnCadastroEspecialidade.Name = "btnCadastroEspecialidade";
            this.btnCadastroEspecialidade.Size = new System.Drawing.Size(133, 33);
            this.btnCadastroEspecialidade.TabIndex = 2;
            this.btnCadastroEspecialidade.Text = "Cadastrar";
            this.btnCadastroEspecialidade.UseVisualStyleBackColor = true;
            this.btnCadastroEspecialidade.Click += new System.EventHandler(this.btnCadastroEspecialidade_Click);
            // 
            // errorEspecialidade
            // 
            this.errorEspecialidade.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorEspecialidade.ContainerControl = this;
            // 
            // Cadastro_de_Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 129);
            this.Controls.Add(this.btnCadastroEspecialidade);
            this.Controls.Add(this.txtNomeEspecialidade);
            this.Controls.Add(this.lblNomeEspecialidade);
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Especialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Especialidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_de_Especialidades_FormClosing);
            this.Load += new System.EventHandler(this.Cadastro_de_Especialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorEspecialidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeEspecialidade;
        private System.Windows.Forms.TextBox txtNomeEspecialidade;
        private System.Windows.Forms.Button btnCadastroEspecialidade;
        private System.Windows.Forms.ErrorProvider errorEspecialidade;
    }
}