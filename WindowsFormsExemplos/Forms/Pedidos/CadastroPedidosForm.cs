using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    public partial class CadastroPedidosForm : Form
    {
        private ClienteServico clienteServico;
        private PedidoServico pedidoServico;
        private ProdutoServico produtoServico;
        public CadastroPedidosForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            pedidoServico = new PedidoServico();
            produtoServico = new ProdutoServico();
        }

        internal void ApresentarCamposModoOrcamento()
        {
            AlterarVisibilidade(false);
        }

        internal void ApresentarCamposModoCarrinho()
        {
            AlterarVisibilidade(true);
            PreencherComboBoxProdutos();
        }

        private void PreencherComboBoxProdutos()
        {
            var produtos = produtoServico.ObterTodos("");

            produtos = produtos.OrderBy(produto => produto.Nome).ToList();

            comboBoxProduto.Items.Clear();
            foreach (var produto in produtos)
            {
                comboBoxProduto.Items.Add(produto);
            }
        }

        private void AlterarVisibilidade(bool ehVisivel)
        {
            AlterarVisibilidadeComponentes(
                ehVisivel,
                labelProduto,
                labelPrecoUnitario,
                labelPrecoUnitarioValor,
                labelTotal,
                labelTotalValor,
                labelTotalPedido,
                labelTotalPedidoValor,
                labelQuantidade,
                labelCarrinho,
                buttonCancelarPedido,
                buttonFecharPedido,
                buttonAdicionar,
                dataGridViewCarrinho,
                numericUpDownQuantidade,
                comboBoxProduto,
                labelCodigo,
                labelCodigoValor
                );
        }

        private void AlterarVisibilidadeComponentes(bool visible, params Control[] componentes)
        {
            foreach (var componente in componentes)
                componente.Visible = visible;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroPedidosForm_Load(object sender, EventArgs e)
        {
            PreencherComboBoxClientes();
        }

        private void PreencherComboBoxClientes()
        {
            var clientes = clienteServico.ObterTodos();

            comboBoxCliente.Items.Clear();

            // Ordenar a lista de clientes do banco de dados para melhorar a experiencia do usuário
            clientes = clientes.OrderBy(cliente => cliente.Nome).ToList();

            foreach (var cliente in clientes)
                comboBoxCliente.Items.Add(cliente);
        }

        private void buttonCriarOrcamento_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha o cliente desejado para criar um orçamento");
                return;
            }

            // Obter o cliente selecionado no comboBox
            var clienteEscolhido = (Cliente)comboBoxCliente.SelectedItem;

            // Criar o registro na tabela de pedidos do orçamento
            var idPedido = pedidoServico.CriarOrçamento(clienteEscolhido);

            // Definir o código do pedido para o usuário ver o código
            labelCodigoValor.Text = idPedido.ToString();

            ApresentarCamposModoCarrinho();

            MessageBox.Show($"Orçamento criado para {clienteEscolhido.Nome}");
        }
    }
}
