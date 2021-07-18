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
    public partial class Clinica_Medica : Form
    {
        public Clinica_Medica()
        {
            InitializeComponent();
        }

        private void agenda_Click(object sender, EventArgs e)
        {
            Visualizar_Agenda frmVisualizarAgenda = new Visualizar_Agenda();
            frmVisualizarAgenda.ShowDialog();
        }

        private void especialidades_Click(object sender, EventArgs e)
        {
            VisualizarEspecialidades frmVisualizarEspacialidades = new VisualizarEspecialidades();
            frmVisualizarEspacialidades.ShowDialog();
        }

        private void medicos_Click(object sender, EventArgs e)
        {
            Visualizar_Medicos frmVisualizarMedicos = new Visualizar_Medicos();
            frmVisualizarMedicos.ShowDialog();
        }

        private void pacientes_Click(object sender, EventArgs e)
        {
            Visualizar_Paciente frmVisualizarPaciente = new Visualizar_Paciente();
            frmVisualizarPaciente.ShowDialog();
        }

        private void historico_Click(object sender, EventArgs e)
        {
            Historico_Pacientes frmHistoricoPacientes = new Historico_Pacientes();
            frmHistoricoPacientes.ShowDialog();
        }
    }
}
