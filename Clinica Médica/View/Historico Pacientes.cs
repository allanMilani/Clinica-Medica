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
    public partial class Historico_Pacientes : Form
    {
        public Historico_Pacientes()
        {
            InitializeComponent();
        }
        private void AtualizarLista() { 
            if(cbPesquisarPaciente.SelectedIndex > -1)
            {
                Paciente paciente = (Paciente)cbPesquisarPaciente.SelectedItem;
                List<Agenda> lista = AgendaController.PesquisarPaciente(paciente);
                dtvListaHistorico.DataSource = lista;
            }
        }
        private void Historico_Pacientes_Load(object sender, EventArgs e)
        {
            List<Paciente> listaPacientes = PacienteController.Listar();
            cbPesquisarPaciente.DataSource = listaPacientes;
            cbPesquisarPaciente.SelectedIndex = -1;
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void VerAnotacoes_Click(object sender, EventArgs e)
        {
            if(dtvListaHistorico.SelectedRows != null && dtvListaHistorico.SelectedRows.Count > 0)
            {
                Agenda item = (Agenda)dtvListaHistorico.SelectedRows[0].DataBoundItem;
                Ver_Dados_da_Consulta frmDetalhes = new Ver_Dados_da_Consulta(item);
                frmDetalhes.ShowDialog();
            }
        }
    }
}
