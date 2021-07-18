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
    public partial class Visualizar_Medicos : Form
    {
        public Visualizar_Medicos()
        {
            InitializeComponent();
        }
        private void AtualizarLista()
        {
            if (
                txtPesquisaCRM.Text.Trim() != "" || 
                txtPesquisaNome.Text.Trim() != "" || 
                cbPesquisaEspecialidade.SelectedIndex > -1
                )
            {
                Medico item = new Medico();
                item.CRM = txtPesquisaCRM.Text.Trim();
                item.Nome = txtPesquisaNome.Text.Trim();
                item.Especialidade = (Especialidade)cbPesquisaEspecialidade.SelectedItem;
                List<Medico> lista = MedicoController.Pesquisar(item);
                dtvVisualizarMedicos.DataSource = lista;
            }
            else
            {
                List<Medico> lista = MedicoController.ListarMedicosEspecialidades();
                dtvVisualizarMedicos.DataSource = lista;
            }

        }
        private void Visualizar_Medicos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            List<Especialidade> listaEspecialidade = EspecialidadeController.Listar();
            cbPesquisaEspecialidade.DataSource = listaEspecialidade;
            cbPesquisaEspecialidade.SelectedIndex = -1;
        }

        private void novoMedico_Click(object sender, EventArgs e)
        {
            Cadastro_de_Medico frmCadastrarMedico = new Cadastro_de_Medico();
            frmCadastrarMedico.ShowDialog();
            AtualizarLista();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void deletarMedico_Click(object sender, EventArgs e)
        {
            if(dtvVisualizarMedicos.SelectedRows != null && dtvVisualizarMedicos.SelectedRows.Count > 0)
            {
                Medico item = (Medico)dtvVisualizarMedicos.SelectedRows[0].DataBoundItem;
                if(MessageBox.Show($"Deseja realmente remover o médico {item.Nome} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try {
                        MedicoController.Remover(item);
                        AtualizarLista();
                        MessageBox.Show("Médico removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro ao remover o médico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editarMedico_Click(object sender, EventArgs e)
        {
            if(dtvVisualizarMedicos.SelectedRows != null && dtvVisualizarMedicos.SelectedRows.Count > 0)
            {
                Medico item = (Medico)dtvVisualizarMedicos.SelectedRows[0].DataBoundItem;
                Atualizar_Medico frmAtualizarMedico = new Atualizar_Medico(item);
                frmAtualizarMedico.ShowDialog();
                AtualizarLista();
            }
        }
    }
}
