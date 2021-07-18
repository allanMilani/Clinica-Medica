
namespace Clinica_Médica.View
{
    partial class Atualizar_Especialidade
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
            this.lbllAtualizarEspecialidade = new System.Windows.Forms.Label();
            this.txtAtualizarEspecialidade = new System.Windows.Forms.TextBox();
            this.errorAtualizarEspecialidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllAtualizarEspecialidade
            // 
            this.lbllAtualizarEspecialidade.AutoSize = true;
            this.lbllAtualizarEspecialidade.Location = new System.Drawing.Point(13, 13);
            this.lbllAtualizarEspecialidade.Name = "lbllAtualizarEspecialidade";
            this.lbllAtualizarEspecialidade.Size = new System.Drawing.Size(114, 15);
            this.lbllAtualizarEspecialidade.TabIndex = 0;
            this.lbllAtualizarEspecialidade.Text = "Nome Especialidade";
            // 
            // txtAtualizarEspecialidade
            // 
            this.txtAtualizarEspecialidade.Location = new System.Drawing.Point(13, 32);
            this.txtAtualizarEspecialidade.MaxLength = 100;
            this.txtAtualizarEspecialidade.Name = "txtAtualizarEspecialidade";
            this.txtAtualizarEspecialidade.PlaceholderText = "digite o nome da especialidade";
            this.txtAtualizarEspecialidade.Size = new System.Drawing.Size(276, 23);
            this.txtAtualizarEspecialidade.TabIndex = 1;
            // 
            // errorAtualizarEspecialidade
            // 
            this.errorAtualizarEspecialidade.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAtualizarEspecialidade.ContainerControl = this;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(13, 62);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(103, 31);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Atualizar_Especialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 108);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtAtualizarEspecialidade);
            this.Controls.Add(this.lbllAtualizarEspecialidade);
            this.MaximizeBox = false;
            this.Name = "Atualizar_Especialidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Especialidade";
            this.Load += new System.EventHandler(this.Atualizar_Especialidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAtualizarEspecialidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllAtualizarEspecialidade;
        private System.Windows.Forms.TextBox txtAtualizarEspecialidade;
        private System.Windows.Forms.ErrorProvider errorAtualizarEspecialidade;
        private System.Windows.Forms.Button btnAtualizar;
    }
}