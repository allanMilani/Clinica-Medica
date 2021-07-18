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
    public partial class Visualizar_Agenda : Form
    {
        public Visualizar_Agenda()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            if (cbPesquisarMedicoAgenda.SelectedIndex > -1) {
                Medico medicoCb = (Medico)cbPesquisarMedicoAgenda.SelectedItem;
                List<Agenda> lista = AgendaController.Pesquisa(medicoCb, dtDataAgendamento.Value);
                dtvAgendamentos.DataSource = lista;
            }
            else
            {
                List<Agenda> lista = AgendaController.ListarAgenda(dtDataAgendamento.Value);
                dtvAgendamentos.DataSource = lista;
            }

            lblAgendaDia.Text = $"Agenda do dia {dtDataAgendamento.Value.ToString("dd/MM/yyyy")}:";
        }
        private void novoAgendamento_Click(object sender, EventArgs e)
        {
            Cadastro_Agenda frmCadastroAgenda = new Cadastro_Agenda();
            frmCadastroAgenda.ShowDialog();
            AtualizarLista();
        }

        private void Visualizar_Agenda_Load(object sender, EventArgs e)
        {
            AtualizarLista();
            List<Medico> listaMedico = MedicoController.Listar();
            cbPesquisarMedicoAgenda.DataSource = listaMedico;
            cbPesquisarMedicoAgenda.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void removerAgendamento_Click(object sender, EventArgs e)
        {
            if(dtvAgendamentos.SelectedRows != null && dtvAgendamentos.SelectedRows.Count > 0)
            {
                Agenda item = (Agenda)dtvAgendamentos.SelectedRows[0].DataBoundItem;
                if(MessageBox.Show($"Deseja realmente remover o agendamento de {item.DataHoraConsulta} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try {
                        AgendaController.Remover(item);
                        AtualizarLista();
                        MessageBox.Show("Agendamento removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro ao remover o médico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editarAgendamento_Click(object sender, EventArgs e)
        {
            if(dtvAgendamentos.SelectedRows != null && dtvAgendamentos.SelectedRows.Count > 0)
            {
                Agenda item = (Agenda)dtvAgendamentos.SelectedRows[0].DataBoundItem;
                Atualizar_Agenda frmAtualizarAgenda = new Atualizar_Agenda(item);
                frmAtualizarAgenda.ShowDialog();
                AtualizarLista();
            }
        }

        private void inserirAnotacoes_Click(object sender, EventArgs e)
        {
            if (dtvAgendamentos.SelectedRows != null && dtvAgendamentos.SelectedRows.Count > 0)
            {
                Agenda item = (Agenda)dtvAgendamentos.SelectedRows[0].DataBoundItem;
                Anotacoes_Medicas frmAnotacoesMedicas = new Anotacoes_Medicas(item);
                frmAnotacoesMedicas.ShowDialog();
            }
        }
    }
}
