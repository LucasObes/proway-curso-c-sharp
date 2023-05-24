using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Forms
{
    public partial class FilmeCadastro : Form
    {
        public FilmeCadastro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelListaDeFilmes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0;

            // ComboBox é uma lista de itens, ou seja, para remover a seleção deve-se atribuir -1 para o índice do item selecionado

            comboBoxCategoria.SelectedIndex = -1;
            dateTimePickerDataLancamento.ResetText();
            checkBoxVitoriaEmmy.Checked = false;
            checkBoxVitoriaGrammy.Checked = false;
            checkBoxVitoriaOscar.Checked = false;
            radioButtonFlopouNao.Checked = false;
            radioButtonFlopouSim.Checked = false;
        }

        private void richTextBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
