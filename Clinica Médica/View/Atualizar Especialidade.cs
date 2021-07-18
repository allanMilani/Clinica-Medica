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
    public partial class Atualizar_Especialidade : Form
    {
        public Especialidade especialidadeSelecionada = null;
        public Atualizar_Especialidade(Especialidade item = null)
        {
            especialidadeSelecionada = item;
            InitializeComponent();
        }

        private void Atualizar_Especialidade_Load(object sender, EventArgs e)
        {
            txtAtualizarEspecialidade.Text = especialidadeSelecionada.NomeEspecialidade;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            errorAtualizarEspecialidade.Clear();
            bool error = false;

            if(txtAtualizarEspecialidade.Text.Trim() == "")
            {
                errorAtualizarEspecialidade.SetError(txtAtualizarEspecialidade, "Campo obrigatório");
                error = true;
            }


            if(error == false)
            {
                especialidadeSelecionada.NomeEspecialidade = txtAtualizarEspecialidade.Text.Trim();
                try
                {
                    EspecialidadeController.Atualizar(especialidadeSelecionada);
                    MessageBox.Show("Especialidade atualizada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Falha ao atualizar a especialidade", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
