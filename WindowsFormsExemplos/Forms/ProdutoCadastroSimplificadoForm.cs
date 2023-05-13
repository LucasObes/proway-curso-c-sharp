using ProWayModelos;
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
    public partial class ProdutoCadastroSimplificadoForm : Form
    {

        private int indiceLinhaEdicao = -1; //Não é no modo de edição

        public ProdutoCadastroSimplificadoForm()
        {
            InitializeComponent();
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelTextoQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecoUnitario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.nome = textBoxNome.Text.Trim();
            produto.quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            produto.valorUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text);

            // Verificar que não é modo de edição, ou seja, deve criar uma nova linha na tabela
            if (indiceLinhaEdicao == -1)
            {
                dataGridView1.Rows.Add(new object[]
                {
                produto.nome,
                produto.quantidade,
                produto.valorUnitario,
                produto.quantidade * produto.valorUnitario
                });
            }
            else
            {
                dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value = produto.nome;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[1].Value = produto.quantidade;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[2].Value = produto.valorUnitario;
                dataGridView1.Rows[indiceLinhaEdicao].Cells[3].Value = produto.quantidade * produto.valorUnitario;
                indiceLinhaEdicao = -1;
            }

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxPrecoUnitario.Clear();
            textBoxQuantidade.Clear();
            textBoxNome.Focus();
        }

        /* CRUD
         * C --> Create
         * R --> Read
         * U --> Update
         * D --> Delete */

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtendo o índice da linha selecionada pelo usuário
            int indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            // Removendo a linha selecionada do DataGridView
            // Rows = linhas
            dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Obtém o índice da linha desejada para edição
            indiceLinhaEdicao = dataGridView1.SelectedRows[0].Index;

            // Obter os dados da linha selecionada
            string nome = dataGridView1.Rows[indiceLinhaEdicao].Cells[0].Value.ToString();
            int quantidade = Convert.ToInt32(dataGridView1.Rows[indiceLinhaEdicao].Cells[1].Value);
            double valorUnitario = Convert.ToDouble(dataGridView1.Rows[indiceLinhaEdicao].Cells[2].Value);

            // Preenchendo os campos com os dados do produto desejado para edição
            textBoxNome.Text = nome;
            textBoxQuantidade.Text = quantidade.ToString();
            textBoxPrecoUnitario.Text = valorUnitario.ToString();
        }

        private void ProdutoCadastroSimplificadoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
