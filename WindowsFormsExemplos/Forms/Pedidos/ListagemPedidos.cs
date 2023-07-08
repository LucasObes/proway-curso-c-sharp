using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Enums;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Pedidos
{
    public partial class ListagemPedidos : Form
    {
        private PedidoServico pedidoServico;
        private ClienteServico clienteServico;

        public ListagemPedidos()
        {
            InitializeComponent();

            pedidoServico = new PedidoServico();
            clienteServico = new ClienteServico();
        }

        private void buttonCriarOrcamento_Click(object sender, EventArgs e)
        {
            var form = new CadastroPedidosForm();
            form.Text = "Criar orçamento";
            form.ApresentarCamposModoOrcamento();
            form.ShowDialog();
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            var cliente = (Cliente)comboBoxCliente.SelectedItem;

            var pedidoStatus = PedidoStatus.Orcamento;

            // Caso o cliente existir (ou seja, não conter null) ele irá passar para o ObterTodos. Caso contrário, o nome do cliente será passado como null
            var pedidos = pedidoServico.ObterTodos(cliente?.Nome ?? null, pedidoStatus);
            // cliente?.Nome: vai pegar o nome do cliente se cliente for diferente de null (if)
            // ?? null: se não possuir nenhum nome, o nome vai ser considerado null

            dataGridView1.Rows.Clear();

            foreach (var pedido in pedidos)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    pedido.Id,
                    pedido.Cliente.Nome,
                    pedido.Status,
                    "0"
                });
            }
        }

        private void ListagemPedidos_Load(object sender, EventArgs e)
        {
            PreencherComboBoxClientes();

            ListarPedidos();
        }

        private void PreencherComboBoxClientes()
        {
            var clientes = clienteServico.ObterTodos();

            foreach (var cliente in clientes)
            {
                comboBoxCliente.Items.Add(cliente);
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarPedidos();
        }
    }
}
