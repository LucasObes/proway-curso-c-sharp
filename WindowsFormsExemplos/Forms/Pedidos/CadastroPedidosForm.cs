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
        private CarrinhoServico carrinhoServico;
        public CadastroPedidosForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            pedidoServico = new PedidoServico();
            produtoServico = new ProdutoServico();
            carrinhoServico = new CarrinhoServico();
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

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedIndex == -1)
                return;

            var produto = (Produto)comboBoxProduto.SelectedItem;

            labelPrecoUnitarioValor.Text = produto.PrecoUnitario.ToString();

            numericUpDownQuantidade.Value = numericUpDownQuantidade.Minimum;

            CalcularValorProdutos();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorProdutos();
        }

        private void CalcularValorProdutos()
        {
            var quantidade = numericUpDownQuantidade.Value;
            var precoUnitario = Convert.ToDecimal(labelPrecoUnitarioValor.Text);

            var precoTotal = quantidade * precoUnitario;
            labelTotalValor.Text = precoTotal.ToString();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            var quantidade = Convert.ToInt32(numericUpDownQuantidade.Value);
            var produto = (Produto)comboBoxProduto.SelectedItem;
            var idPedido = Convert.ToInt32(labelCodigoValor.Text);

            var pedido = new Pedido();
            pedido.Id = idPedido;

            var carrinho = new Carrinho();
            carrinho.Produto = produto;
            carrinho.Venda = pedido;
            carrinho.Quantidade = quantidade;

            carrinhoServico.AdicionarItemCarrinho(carrinho);

            LimparCampos();

            PreencherDataGridViewCarrinho();
        }

        private void LimparCampos()
        {
            comboBoxProduto.SelectedIndex = -1;
            labelPrecoUnitarioValor.Text = "0";
            numericUpDownQuantidade.Value = numericUpDownQuantidade.Minimum;
        }

        private void PreencherDataGridViewCarrinho()
        {
            var idPedido = Convert.ToInt32(labelCodigoValor.Text);
            var itensCarrinho = carrinhoServico.ObterItemsPorIdPedido(idPedido);

            dataGridViewCarrinho.Rows.Clear();

            var totalPedido = 0.0m;

            foreach (var itemCarrinho in itensCarrinho)
            {
                var valorItemCarrinho = itemCarrinho.Quantidade * itemCarrinho.Produto.PrecoUnitario;
                totalPedido += valorItemCarrinho;

                dataGridViewCarrinho.Rows.Add(new object[]
                {
                    itemCarrinho.Id,
                    itemCarrinho.Produto.Nome,
                    itemCarrinho.Quantidade,
                    itemCarrinho.Produto.PrecoUnitario.ToString("C"),
                    valorItemCarrinho.ToString("C")
                }); ;
            }

            labelTotalPedidoValor.Text = totalPedido.ToString("C");
        }

        private void buttonCancelarPedido_Click(object sender, EventArgs e)
        {
            var idPedido = Convert.ToInt32(labelCodigoValor.Text);

            var desejaCancelar = MessageBox.Show("Deseja realmente cancelar o pedido?",
                                                 "CUIDADO",
                                                 MessageBoxButtons.YesNo);

            if (desejaCancelar == DialogResult.No)
            {
                return;
            }

            pedidoServico.CancelarPedido(idPedido);

            MessageBox.Show("Pedido cancelado com sucesso");
            Dispose(); // Fechar a tela de cadastro dos pedidos
        }

        private void buttonFecharPedido_Click(object sender, EventArgs e)
        {
            var idPedido = Convert.ToInt32(labelCodigoValor.Text);
            var totalPedido = Convert.ToDecimal(labelTotalPedidoValor.Text.Replace("R$", string.Empty));

            pedidoServico.FecharPedido(idPedido, totalPedido);
            MessageBox.Show("Pedido gerado com sucesso");
            Dispose();
        }
    }
}
