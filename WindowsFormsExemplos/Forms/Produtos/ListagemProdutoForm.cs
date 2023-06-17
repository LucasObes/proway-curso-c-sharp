using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Produtos
{
    public partial class ListagemProdutoForm : Form
    {
        public ListagemProdutoForm()
        {
            InitializeComponent();
        }

        private void ListagemProdutoForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void ListarProdutos()
        {
            // Obter o texto digitado pelo usuário para filtrar os produtos
            var pesquisa = textBoxPesquisa.Text.Trim();


            // Obter a lista de produtos
            var produtoServico = new ProdutoServico();
            var produtos = produtoServico.ObterTodos(pesquisa);

            // Remover linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Percorrer a lista de produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto iterado
                var produto = produtos[i];
                dataGridView1.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Quantidade,
                    produto.PrecoUnitario
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var formulario = new CadastroProdutoForm();
            formulario.Text = "Cadastrar Produto";
            formulario.ShowDialog();
        }

        private void button1Apagar_Click(object sender, EventArgs e)
        {
            // Obter a linha selecionada do dataGridView1
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter o valor da primeira coluna (código == id) da linha selecionada
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Instanciando um objeto da class ProdutoServico
            var produtoServico = new ProdutoServico();

            // Chamar o método que irá realizar o DELETE
            produtoServico.Apagar(id);

            // Atualizar o dataGridView1 com os produtos da tabela de produtos
            ListarProdutos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var produtoServico = new ProdutoServico();
            var produtoEscolhido = produtoServico.ObterPorId(id);

            var form = new CadastroProdutoForm(produtoEscolhido);
            form.ShowDialog();

            ListarProdutos();
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            // Quando usuário apertar a tecla "enter" irá filtrar os produtos (buscar no banco de dados)
            if (e.KeyCode == Keys.Enter)
            {
                ListarProdutos();
            }
        }
    }
}
