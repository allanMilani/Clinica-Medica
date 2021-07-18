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
    public partial class Cadastro_de_Especialidades : Form
    {
        public Cadastro_de_Especialidades()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Especialidades_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastroEspecialidade_Click(object sender, EventArgs e)
        {
            errorEspecialidade.Clear();

            bool error = false;

            if(txtNomeEspecialidade.Text.Trim() == "")
            {
                errorEspecialidade.SetError(txtNomeEspecialidade, "Campo obrigatório");
                error = true;
            }

            if (error == false)
            {
                Especialidade item = new Especialidade();
                item.NomeEspecialidade = txtNomeEspecialidade.Text.Trim();
                try
                {
                    EspecialidadeController.Salvar(item);
                    MessageBox.Show("Especialidade inserida com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeEspecialidade.Text = "";
                }
                catch
                {
                    MessageBox.Show("Falha ao inserir a especialidade", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void Cadastro_de_Especialidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtNomeEspecialidade.Text.Trim() != "")
            {
                    e.Cancel = (DialogResult.No == MessageBox.Show("Deseja realmente cancelar o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            }
        }
    }
}
