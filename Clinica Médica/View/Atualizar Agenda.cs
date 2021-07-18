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
    public partial class Atualizar_Agenda : Form
    {
        public Agenda agendaSelecionada = null;
        public Atualizar_Agenda(Agenda item)
        {
            agendaSelecionada = item;
            InitializeComponent();
        }

        private void Atualizar_Agenda_Load(object sender, EventArgs e)
        {
            
            List<Medico> medicos = MedicoController.Listar();
            cbAtualizarMedicoAgenda.DataSource = medicos;
            cbAtualizarMedicoAgenda.SelectedValue = agendaSelecionada.MedicoId;

            List<Paciente> pacientes = PacienteController.Listar();
            cbAtualizarPacienteAgenda.DataSource = pacientes;
            cbAtualizarPacienteAgenda.SelectedValue = agendaSelecionada.PacienteId;

            dtAtualizarDataHora.Value = agendaSelecionada.DataHoraConsulta;
        }

        private void btnAtualizarAgenda_Click(object sender, EventArgs e)
        {
            errorAtualizarAgenda.Clear();
            bool error = false;
            TimeSpan horaConsulta = dtAtualizarDataHora.Value.TimeOfDay;
            DateTime dataConsulta = dtAtualizarDataHora.Value.Date;

            if (cbAtualizarMedicoAgenda.SelectedIndex <= -1)
            {
                errorAtualizarAgenda.SetError(cbAtualizarMedicoAgenda, "Campo obrigatória");
                error = true;
            }

            if (cbAtualizarPacienteAgenda.SelectedIndex <= -1)
            {
                errorAtualizarAgenda.SetError(cbAtualizarPacienteAgenda, "Campo obrigatório");
                error = true;
            }

            if (dataConsulta < DateTime.Today.Date)
            {
                errorAtualizarAgenda.SetError(dtAtualizarDataHora, "Data inválida");
                error = true;
            }

            if (AgendaController.ExisteConsulta(dtAtualizarDataHora.Value, (Medico)cbAtualizarMedicoAgenda.SelectedItem) == true)
            {
                errorAtualizarAgenda.SetError(dtAtualizarDataHora, "Horário já está agendado");
                error = true;
            }

            if(error == false)
            {
                agendaSelecionada.Medico = (Medico)cbAtualizarMedicoAgenda.SelectedItem;
                agendaSelecionada.Paciente = (Paciente)cbAtualizarPacienteAgenda.SelectedItem;
                agendaSelecionada.DataHoraConsulta = dtAtualizarDataHora.Value;

                try {
                    AgendaController.Atualizar(agendaSelecionada);
                    MessageBox.Show("Agenda atualizada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                } catch
                {
                    MessageBox.Show("Falha ao atualizar a agenda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
