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
    public partial class Cadastro_Agenda : Form
    {
        public Cadastro_Agenda()
        {
            InitializeComponent();
        }

        private void Cadastro_Agenda_Load(object sender, EventArgs e)
        {
            List<Medico> medicos = MedicoController.Listar();
            cbMedico.DataSource = medicos;
            cbMedico.SelectedIndex = -1;

            List<Paciente> pacientes = PacienteController.Listar();
            cbPaciente.DataSource = pacientes;
            cbPaciente.SelectedIndex = -1;
        }

        private void btnCadastroAgenda_Click(object sender, EventArgs e)
        {
            errorAgenda.Clear();
            bool error = false;
            TimeSpan horaConsulta = dtDataHora.Value.TimeOfDay;
            DateTime dataConsulta = dtDataHora.Value.Date;

            if(cbMedico.SelectedIndex <= -1)
            {
                errorAgenda.SetError(cbMedico, "Campo obrigatória");
                error = true;
            }

            if(cbPaciente.SelectedIndex <= -1)
            {
                errorAgenda.SetError(cbPaciente, "Campo obrigatório");
                error = true;
            }

            if(dataConsulta < DateTime.Today.Date)
            {
                errorAgenda.SetError(dtDataHora, "Data inválida");
                error = true;
            }


            if (AgendaController.ExisteConsulta(dtDataHora.Value, (Medico)cbMedico.SelectedItem) == true)
            {
                errorAgenda.SetError(dtDataHora, "Horário já está agendado");
                error = true;
            }

            if (error == false)
            {
                Agenda item = new Agenda();
                item.Medico = (Medico)cbMedico.SelectedItem;
                item.Paciente = (Paciente)cbPaciente.SelectedItem;
                item.DataHoraConsulta = dtDataHora.Value;

                try
                {
                    AgendaController.Salvar(item);
                    MessageBox.Show("Agenda inserida com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMedico.SelectedIndex = -1;
                    cbPaciente.SelectedIndex = -1;
                    dtDataHora.Value = DateTime.Now;
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir a agenda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cadastro_Agenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
               cbPaciente.SelectedIndex != -1 ||
               cbPaciente.SelectedIndex != -1
               )
            {
                e.Cancel = (DialogResult.No == MessageBox.Show("Deseja realmente cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            }
        }
    }
}
