using Clinica_Médica.Controller;
using Clinica_Médica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Médica.View
{
    public partial class Atualizar_Paciente : Form
    {
        public Paciente pacienteSelecionado = null;
        public Atualizar_Paciente(Paciente item)
        {
            pacienteSelecionado = item;
            InitializeComponent();
        }

        private void Atualizar_Paciente_Load(object sender, EventArgs e)
        {
            txtAtualizarNomePaciente.Text = pacienteSelecionado.Nome;
            dtAtualizarDataNascimentoPaciente.Value = pacienteSelecionado.DataNascimento;
            txtAtualizarTelefonePaciente.Text = pacienteSelecionado.Telefone;
            txtAtualizarProfissaoPaciente.Text = pacienteSelecionado.Profissao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorAtualizarPaciente.Clear();
            bool error = false;

            if (txtAtualizarNomePaciente.Text.Trim() == "")
            {
                errorAtualizarPaciente.SetError(txtAtualizarNomePaciente, "Campo Obrigatório!");
                error = true;
            }

            if (dtAtualizarDataNascimentoPaciente.Value > DateTime.Today)
            {
                errorAtualizarPaciente.SetError(dtAtualizarDataNascimentoPaciente, "A informe uma data válida");
            }

            if (txtAtualizarTelefonePaciente.Text.Trim() == "")
            {
                errorAtualizarPaciente.SetError(txtAtualizarTelefonePaciente, "Campo Obrigatório!");
                error = true;
            }

            if (txtAtualizarProfissaoPaciente.Text.Trim() == "")
            {
                errorAtualizarPaciente.SetError(txtAtualizarProfissaoPaciente, "Campo Obrigatório!");
                error = true;
            }

            if (error == false)
            {
                pacienteSelecionado.Nome = txtAtualizarNomePaciente.Text.Trim();
                pacienteSelecionado.DataNascimento = dtAtualizarDataNascimentoPaciente.Value;
                pacienteSelecionado.Telefone = txtAtualizarTelefonePaciente.Text.Trim();
                pacienteSelecionado.Profissao = txtAtualizarProfissaoPaciente.Text.Trim();

                try
                {
                    PacienteController.Atualizar(pacienteSelecionado);
                    MessageBox.Show("Paciênte atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Falha ao atualizar o paciênte", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
