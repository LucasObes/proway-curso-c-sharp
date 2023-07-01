using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Forms.Clientes;
using WindowsFormsExemplos.Forms.Produtos;

namespace WindowsFormsExemplos.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciar: NomeClasse nomeObjeto = new NomeClasse

            Form1 folhaPagamentoForm = new Form1();
            folhaPagamentoForm.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastroSimplificadoProduto_Click(object sender, EventArgs e)
        {
            ProdutoCadastroSimplificadoForm form = new ProdutoCadastroSimplificadoForm();
            form.ShowDialog();
        }

        private void buttonCadastroFilmes_Click(object sender, EventArgs e)
        {
            FilmeCadastro form = new FilmeCadastro();
            form.ShowDialog();
        }

        private void buttonCadastroSimplificadoProdutoBancoDados_Click(object sender, EventArgs e)
        {
            ProdutoCadastroSimplificadoBancoDadosForm form = new ProdutoCadastroSimplificadoBancoDadosForm();
            form.ShowDialog();
        }

        private void buttonListaProdutos_Click(object sender, EventArgs e)
        {
            ListagemProdutoForm form = new ListagemProdutoForm();
            form.ShowDialog();
        }

        private void buttonListaClientes_Click(object sender, EventArgs e)
        {
            var form = new ListagemClienteForm();
            form.ShowDialog();
        }
    }
}
