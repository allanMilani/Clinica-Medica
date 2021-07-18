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
    public partial class VisualizarEspecialidades : Form
    {
        public VisualizarEspecialidades()
        {
            InitializeComponent();
        }

        private void AtualizarLista() {
            if(txtPesquisarEspecialidade.Text.Trim() != "")
            {
                Especialidade item = new Especialidade();
                item.NomeEspecialidade = txtPesquisarEspecialidade.Text.Trim();
                List<Especialidade> lista = EspecialidadeController.Pesquisar(item);
                dtvEspecialidades.DataSource = lista;
            }
            else
            {
                List<Especialidade> lista = EspecialidadeController.Listar();
                dtvEspecialidades.DataSource = lista;
            }
            
        }
        private void VisualizarEspecialidades_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnPesquisarEspecialidade_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void nova_especialidade_Click(object sender, EventArgs e)
        {
            Cadastro_de_Especialidades frmCadastroEspecialidade = new Cadastro_de_Especialidades();
            frmCadastroEspecialidade.ShowDialog();

            AtualizarLista();
        }

        private void excluirEspecialidade_Click(object sender, EventArgs e)
        {
            if(dtvEspecialidades.SelectedRows != null && dtvEspecialidades.SelectedRows.Count > 0)
            {
                Especialidade item = (Especialidade)dtvEspecialidades.SelectedRows[0].DataBoundItem;
                if(MessageBox.Show($"Deseja realmente remover a especialidade {item.NomeEspecialidade} ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    try {
                        EspecialidadeController.Remover(item);
                        AtualizarLista();
                        MessageBox.Show("Especialidade removida com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro ao remover a especialidade", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void atualizar_especialidade_Click(object sender, EventArgs e)
        {
            if (dtvEspecialidades.SelectedRows != null && dtvEspecialidades.SelectedRows.Count > 0) { 
                Especialidade item = (Especialidade)dtvEspecialidades.SelectedRows[0].DataBoundItem;
                Atualizar_Especialidade frmAtualizarEspecialidade = new Atualizar_Especialidade(item);
                frmAtualizarEspecialidade.ShowDialog();
            }
        }
    }
}
