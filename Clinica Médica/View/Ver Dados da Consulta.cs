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
    public partial class Ver_Dados_da_Consulta : Form
    {
        public Agenda historicoSelecionado = null;
        public Ver_Dados_da_Consulta(Model.Agenda item)
        {
            historicoSelecionado = item;
            InitializeComponent();
        }

        private void Ver_Dados_da_Consulta_Load(object sender, EventArgs e)
        {
            TimeSpan horaInvalida = new TimeSpan(00, 00, 00);

            txtNomePacienteDetalhes.Text = historicoSelecionado.NomePaciente;
            txtDataNascimentoPacienteDetalhes.Text = historicoSelecionado.Paciente.DataNascimento.ToString("dd/MM/yyyy");
            txtTelefonePacienteDetalhes.Text = historicoSelecionado.Paciente.Telefone;
            txtProfissaoPacienteDetalhes.Text = historicoSelecionado.Paciente.Profissao;

            txtNomeMedicoDetalhes.Text = historicoSelecionado.NomeMedico;
            txtCRMMedicoDetalhes.Text = historicoSelecionado.Medico.CRM;
            txtEspecialidadeMedicoDetalhes.Text = historicoSelecionado.Medico.NomeEspecialidade;

            txtAgendamentoConsultaDetalhes.Text = Convert.ToString(historicoSelecionado.DataHoraConsulta);
            if(TimeSpan.Compare(horaInvalida, historicoSelecionado.HoraInicio) != 0)
                txtInicioDetalhes.Text = Convert.ToString(historicoSelecionado.HoraInicio);

            if (TimeSpan.Compare(horaInvalida, historicoSelecionado.HoraFim) != 0)
                txtFimDetalhes.Text = Convert.ToString(historicoSelecionado.HoraFim);

            if (historicoSelecionado.Anotacoes != null && historicoSelecionado.Anotacoes.Trim() != "")
                txtAnotacoesDetalhes.Text = AgendaController.Descriptografar(historicoSelecionado.Anotacoes);
        }
    }
}
