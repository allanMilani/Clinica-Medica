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
    public partial class Cadastro_de_Medico : Form
    {
        public Cadastro_de_Medico()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Médico_Load(object sender, EventArgs e)
        {
            List<Especialidade> especialidades = EspecialidadeController.Listar();
            cbEspecialidade.DataSource = especialidades;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            errorCadastroMedico.Clear();
            bool error = false;
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);
            TimeSpan tempoAtendimento = dtTempoMedio.Value.TimeOfDay;

            if (txtCRM.Text.Trim() == "") {
                errorCadastroMedico.SetError(txtCRM, "Campo obrigatório");
                error = true;
            }

            if (txtNome.Text.Trim() == "") {
                errorCadastroMedico.SetError(txtNome, "Campo obrigatório");
                error = true;
            }

            if(TimeSpan.Compare(horaInvalida, tempoAtendimento) == 0)
            {
                errorCadastroMedico.SetError(dtTempoMedio, "Tempo de consulta inválido");
                error = true;
            }

            if(cbEspecialidade.SelectedIndex == -1)
            {
                errorCadastroMedico.SetError(cbEspecialidade, "Especialidade inválida");
                error = true;
            }

            if (error == false) {
                Medico item = new Medico();
                item.Nome = txtNome.Text.Trim();
                item.CRM = txtCRM.Text.Trim();
                item.TempoMedio = tempoAtendimento;
                item.Especialidade = (Especialidade)cbEspecialidade.SelectedItem;

                try
                {
                    MedicoController.Salvar(item);
                    MessageBox.Show("Médico inserido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCRM.Text = "";
                    txtNome.Text = "";
                    //dtTempoMedio.Format = DateTimePickerFormat.Custom;
                    //dtTempoMedio.CustomFormat = "00:00:00";
                    dtTempoMedio.Value = DateTime.Today;
                    cbEspecialidade.SelectedIndex = -1;
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir o médico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void Cadastro_de_Medico_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);
            TimeSpan tempoAtendimento = dtTempoMedio.Value.TimeOfDay;
            if (
                txtCRM.Text.Trim() != "" ||
                txtNome.Text.Trim() != "" ||
                TimeSpan.Compare(horaInvalida, tempoAtendimento) != 0
                )
            {
                e.Cancel = (DialogResult.No == MessageBox.Show("Deseja realmente cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            }
        }
    }
}
