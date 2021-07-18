
namespace Clinica_Médica.View
{
    partial class Anotacoes_Medicas
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
            this.lblNomePacienteAnotacoes = new System.Windows.Forms.Label();
            this.lblDataNascimentoPaciente = new System.Windows.Forms.Label();
            this.txtNomeDoPacienteAnotacoes = new System.Windows.Forms.TextBox();
            this.txtDataNascimentoAnotacoes = new System.Windows.Forms.TextBox();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.txtAnotacoesMedico = new System.Windows.Forms.TextBox();
            this.btnAdicionarAnotacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomePacienteAnotacoes
            // 
            this.lblNomePacienteAnotacoes.AutoSize = true;
            this.lblNomePacienteAnotacoes.Location = new System.Drawing.Point(13, 13);
            this.lblNomePacienteAnotacoes.Name = "lblNomePacienteAnotacoes";
            this.lblNomePacienteAnotacoes.Size = new System.Drawing.Size(105, 15);
            this.lblNomePacienteAnotacoes.TabIndex = 0;
            this.lblNomePacienteAnotacoes.Text = "Nome do Paciênte";
            this.lblNomePacienteAnotacoes.UseWaitCursor = true;
            // 
            // lblDataNascimentoPaciente
            // 
            this.lblDataNascimentoPaciente.AutoSize = true;
            this.lblDataNascimentoPaciente.Location = new System.Drawing.Point(398, 13);
            this.lblDataNascimentoPaciente.Name = "lblDataNascimentoPaciente";
            this.lblDataNascimentoPaciente.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascimentoPaciente.TabIndex = 1;
            this.lblDataNascimentoPaciente.Text = "Data de Nascimento";
            this.lblDataNascimentoPaciente.UseWaitCursor = true;
            // 
            // txtNomeDoPacienteAnotacoes
            // 
            this.txtNomeDoPacienteAnotacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtNomeDoPacienteAnotacoes.Location = new System.Drawing.Point(13, 32);
            this.txtNomeDoPacienteAnotacoes.Name = "txtNomeDoPacienteAnotacoes";
            this.txtNomeDoPacienteAnotacoes.PlaceholderText = "Nome do paciente";
            this.txtNomeDoPacienteAnotacoes.ReadOnly = true;
            this.txtNomeDoPacienteAnotacoes.Size = new System.Drawing.Size(365, 23);
            this.txtNomeDoPacienteAnotacoes.TabIndex = 5;
            this.txtNomeDoPacienteAnotacoes.UseWaitCursor = true;
            // 
            // txtDataNascimentoAnotacoes
            // 
            this.txtDataNascimentoAnotacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDataNascimentoAnotacoes.Location = new System.Drawing.Point(398, 31);
            this.txtDataNascimentoAnotacoes.Name = "txtDataNascimentoAnotacoes";
            this.txtDataNascimentoAnotacoes.PlaceholderText = "data de nascimento do paciente";
            this.txtDataNascimentoAnotacoes.ReadOnly = true;
            this.txtDataNascimentoAnotacoes.Size = new System.Drawing.Size(315, 23);
            this.txtDataNascimentoAnotacoes.TabIndex = 6;
            this.txtDataNascimentoAnotacoes.UseWaitCursor = true;
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Location = new System.Drawing.Point(13, 74);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(63, 15);
            this.lblAnotacoes.TabIndex = 4;
            this.lblAnotacoes.Text = "Anotações";
            this.lblAnotacoes.UseWaitCursor = true;
            // 
            // txtAnotacoesMedico
            // 
            this.txtAnotacoesMedico.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtAnotacoesMedico.Location = new System.Drawing.Point(13, 92);
            this.txtAnotacoesMedico.Multiline = true;
            this.txtAnotacoesMedico.Name = "txtAnotacoesMedico";
            this.txtAnotacoesMedico.Size = new System.Drawing.Size(700, 297);
            this.txtAnotacoesMedico.TabIndex = 7;
            this.txtAnotacoesMedico.UseWaitCursor = true;
            // 
            // btnAdicionarAnotacoes
            // 
            this.btnAdicionarAnotacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAdicionarAnotacoes.Location = new System.Drawing.Point(12, 406);
            this.btnAdicionarAnotacoes.Name = "btnAdicionarAnotacoes";
            this.btnAdicionarAnotacoes.Size = new System.Drawing.Size(125, 39);
            this.btnAdicionarAnotacoes.TabIndex = 8;
            this.btnAdicionarAnotacoes.Text = "Salvar";
            this.btnAdicionarAnotacoes.UseVisualStyleBackColor = true;
            this.btnAdicionarAnotacoes.UseWaitCursor = true;
            this.btnAdicionarAnotacoes.Click += new System.EventHandler(this.btnAdicionarAnotacoes_Click);
            // 
            // Anotacoes_Medicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 473);
            this.Controls.Add(this.btnAdicionarAnotacoes);
            this.Controls.Add(this.txtAnotacoesMedico);
            this.Controls.Add(this.txtDataNascimentoAnotacoes);
            this.Controls.Add(this.txtNomeDoPacienteAnotacoes);
            this.Controls.Add(this.lblAnotacoes);
            this.Controls.Add(this.lblDataNascimentoPaciente);
            this.Controls.Add(this.lblNomePacienteAnotacoes);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Anotacoes_Medicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anotacoes Medicas";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Anotacoes_Medicas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePacienteAnotacoes;
        private System.Windows.Forms.Label lblDataNascimentoPaciente;
        private System.Windows.Forms.TextBox txtNomeDoPacienteAnotacoes;
        private System.Windows.Forms.TextBox txtDataNascimentoAnotacoes;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdicionarAnotacoes;
        private System.Windows.Forms.TextBox txtAnotacoesMedico;
    }
}