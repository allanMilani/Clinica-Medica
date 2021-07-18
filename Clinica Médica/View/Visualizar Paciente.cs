using Clinica_Médica.Model;
using Clinica_Médica.Controller;
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
    public partial class Visualizar_Paciente : Form
    {
        public Visualizar_Paciente()
        {
            InitializeComponent();
        }

        private void AtualizarLista() { 
            if(
                txtPesquisaNome.Text.Trim() != "" ||
                txtPesquisaProfissao.Text.Trim() != "" ||
                txtPesquisaTelefone.Text.Trim() != "" ||
                dtPesquisaDataNascimento.Value < DateTime.Today
                )
            {
                Paciente item = new Paciente();
                item.Nome = txtPesquisaNome.Text.Trim();
                item.DataNascimento = dtPesquisaDataNascimento.Value;
                item.Profissao = txtPesquisaProfissao.Text.Trim();
                item.Telefone = txtPesquisaTelefone.Text.Trim();
                List<Paciente> lista = PacienteController.Pesquisar(item);
                dtvPacientes.DataSource = lista;
            }
            else{
                List<Paciente> lista = PacienteController.Listar();
                dtvPacientes.DataSource = lista;
            }
        }

        private void lblPesquisarProfissao_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void Visualizar_Paciente_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void novoPaciente_Click(object sender, EventArgs e)
        {
            Cadastro_de_Paciente frmCadastroPaciente = new Cadastro_de_Paciente();
            frmCadastroPaciente.ShowDialog();
            AtualizarLista();
        }

        private void removerPaciente_Click(object sender, EventArgs e)
        {
            if(dtvPacientes.SelectedRows != null && dtvPacientes.SelectedRows.Count > 0)
            {
                Paciente item = (Paciente)dtvPacientes.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Deseja realmente remover o paciênte {item.Nome} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    try
                    {
                        PacienteController.Remover(item);
                        AtualizarLista();
                        MessageBox.Show("Paciênte removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro ao remover o paciênte", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }

        private void editarPaciente_Click(object sender, EventArgs e)
        {
            if(dtvPacientes.SelectedRows != null && dtvPacientes.SelectedRows.Count > 0)
            {
                Paciente item = (Paciente)dtvPacientes.SelectedRows[0].DataBoundItem;
                Atualizar_Paciente frmAtualizarPaciente = new Atualizar_Paciente(item);
                frmAtualizarPaciente.ShowDialog();
                AtualizarLista();
            }
        }
    }
}
