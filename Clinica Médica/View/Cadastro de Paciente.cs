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
    public partial class Cadastro_de_Paciente : Form
    {
        public Cadastro_de_Paciente()
        {
            InitializeComponent();
        }

        private void btnCadastroPaciente_Click(object sender, EventArgs e)
        {
            errorCadastroPaciente.Clear();
            bool error = false;

            if (txtNomePaciente.Text.Trim() == "")
            {
                errorCadastroPaciente.SetError(txtNomePaciente, "Campo Obrigatório!");
                error = true;
            }

            if(dtpDataNascimentoPaciente.Value > DateTime.Today)
            {
                errorCadastroPaciente.SetError(dtpDataNascimentoPaciente, "A informe uma data válida");
            }

            if (txtTelefonePaciente.Text.Trim() == "")
            {
                errorCadastroPaciente.SetError(txtTelefonePaciente, "Campo Obrigatório!");
                error = true;
            }

            if (txtProfissaoPaciente.Text.Trim() == "")
            {
                errorCadastroPaciente.SetError(txtProfissaoPaciente, "Campo Obrigatório!");
                error = true;
            }

            if(error == false)
            {
                Paciente item = new Paciente();
                item.Nome = txtNomePaciente.Text.Trim();
                item.DataNascimento = dtpDataNascimentoPaciente.Value;
                item.Telefone = txtTelefonePaciente.Text.Trim();
                item.Profissao = txtProfissaoPaciente.Text.Trim();

                try
                {
                    PacienteController.Salvar(item);
                    MessageBox.Show("Paciênte inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomePaciente.Text = "";
                    txtProfissaoPaciente.Text = "";
                    txtTelefonePaciente.Text = "";
                    dtpDataNascimentoPaciente.Value = DateTime.Today;
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir o paciênte", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Cadastro_de_Paciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                txtNomePaciente.Text.Trim() != "" ||
                txtProfissaoPaciente.Text.Trim() != "" ||
                txtTelefonePaciente.Text.Trim() != ""
                )
            {
                e.Cancel = (DialogResult.No == MessageBox.Show("Deseja realmente cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            }
        }
    }
}
