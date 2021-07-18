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
    public partial class Anotacoes_Medicas : Form
    {
        public Agenda agendaSelecionada = null;
        public Anotacoes_Medicas(Agenda item)
        {
            agendaSelecionada = item;
            InitializeComponent();
        }

        private void Anotacoes_Medicas_Load(object sender, EventArgs e)
        {
            txtNomeDoPacienteAnotacoes.Text = agendaSelecionada.NomePaciente;
            txtDataNascimentoAnotacoes.Text = agendaSelecionada.Paciente.DataNascimento.ToString("dd/MM/yyyy");
            if (agendaSelecionada.Anotacoes != null && agendaSelecionada.Anotacoes.Trim() != "") {
                txtAnotacoesMedico.Text = AgendaController.Descriptografar(agendaSelecionada.Anotacoes);
            }
            agendaSelecionada.HoraInicio = DateTime.Now.TimeOfDay;
            this.Cursor = Cursors.Default;
        }

        private void btnAdicionarAnotacoes_Click(object sender, EventArgs e)
        {
            if (txtAnotacoesMedico.Text.Trim() != "") {
                agendaSelecionada.Anotacoes = txtAnotacoesMedico.Text.Trim();
                agendaSelecionada.HoraFim = DateTime.Now.TimeOfDay;
                try {
                    AgendaController.AtualizarAnotacoes(agendaSelecionada);
                    MessageBox.Show("Anotações salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Falha ao salvar as anotações", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }
    }
}
