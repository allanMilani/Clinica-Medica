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
    public partial class Atualizar_Medico : Form
    {
        public Medico medicoSelecionado = null;
        public Atualizar_Medico(Medico item)
        {
            medicoSelecionado = item;
            InitializeComponent();
        }

        private void Atualizar_Medico_Load(object sender, EventArgs e)
        {
            txtAtualizarCRM.Text = medicoSelecionado.CRM;
            txtAtualizarNome.Text = medicoSelecionado.Nome;
            dtAtualizarTempoMedio.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day, medicoSelecionado.TempoMedio.Hours, medicoSelecionado.TempoMedio.Minutes, medicoSelecionado.TempoMedio.Seconds);
            List<Especialidade> especialidades = EspecialidadeController.Listar();
            cbAtualizarEspecialidade.DataSource = especialidades;
            cbAtualizarEspecialidade.SelectedValue = medicoSelecionado.EspecialidadeId;
        }

        private void btnAtualizarMedico_Click(object sender, EventArgs e)
        {
            errorAtualizarMedico.Clear();
            bool error = false;
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);
            TimeSpan tempoAtendimento = dtAtualizarTempoMedio.Value.TimeOfDay;

            if (txtAtualizarCRM.Text.Trim() == "")
            {
                errorAtualizarMedico.SetError(txtAtualizarCRM, "Campo obrigatório");
                error = true;
            }

            if(txtAtualizarNome.Text.Trim() == "")
            {
                errorAtualizarMedico.SetError(txtAtualizarNome, "Campo obrigatório");
                error = true;
            }

            if (TimeSpan.Compare(horaInvalida, tempoAtendimento) == 0)
            {
                errorAtualizarMedico.SetError(dtAtualizarTempoMedio, "Tempo de consulta inválido");
                error = true;
            }

            if(cbAtualizarEspecialidade.SelectedIndex == -1)
            {
                errorAtualizarMedico.SetError(cbAtualizarEspecialidade, "Especialidade inválida");
                error = true;
            }

            if (error == false) {
                medicoSelecionado.CRM = txtAtualizarCRM.Text.Trim();
                medicoSelecionado.Nome = txtAtualizarNome.Text.Trim();
                medicoSelecionado.TempoMedio = tempoAtendimento;
                medicoSelecionado.Especialidade = (Especialidade)cbAtualizarEspecialidade.SelectedItem;

                try
                {
                    MedicoController.Atualizar(medicoSelecionado);
                    MessageBox.Show("Médico atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Falha ao atualizar o médico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Atualizar_Medico_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
