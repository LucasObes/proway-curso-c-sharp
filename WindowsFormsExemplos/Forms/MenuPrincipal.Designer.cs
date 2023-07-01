namespace WindowsFormsExemplos.Forms
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonFolhaPagamento = new Button();
            buttonCadastroSimplificadoProduto = new Button();
            buttonCadastroFilmes = new Button();
            buttonCadastroSimplificadoProdutoBancoDados = new Button();
            buttonListaProdutos = new Button();
            buttonListaClientes = new Button();
            buttonListaPedidos = new Button();
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(12, 12);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(207, 186);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha de Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += button1_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(225, 12);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(207, 186);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(438, 12);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(207, 186);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro de Filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonCadastroSimplificadoProdutoBancoDados
            // 
            buttonCadastroSimplificadoProdutoBancoDados.Location = new Point(651, 12);
            buttonCadastroSimplificadoProdutoBancoDados.Name = "buttonCadastroSimplificadoProdutoBancoDados";
            buttonCadastroSimplificadoProdutoBancoDados.Size = new Size(207, 186);
            buttonCadastroSimplificadoProdutoBancoDados.TabIndex = 3;
            buttonCadastroSimplificadoProdutoBancoDados.Text = "Cadastro simplificado produto Banco Dados";
            buttonCadastroSimplificadoProdutoBancoDados.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProdutoBancoDados.Click += buttonCadastroSimplificadoProdutoBancoDados_Click;
            // 
            // buttonListaProdutos
            // 
            buttonListaProdutos.Location = new Point(12, 204);
            buttonListaProdutos.Name = "buttonListaProdutos";
            buttonListaProdutos.Size = new Size(207, 186);
            buttonListaProdutos.TabIndex = 4;
            buttonListaProdutos.Text = "Lista de Produtos";
            buttonListaProdutos.UseVisualStyleBackColor = true;
            buttonListaProdutos.Click += buttonListaProdutos_Click;
            // 
            // buttonListaClientes
            // 
            buttonListaClientes.Location = new Point(225, 204);
            buttonListaClientes.Name = "buttonListaClientes";
            buttonListaClientes.Size = new Size(207, 186);
            buttonListaClientes.TabIndex = 5;
            buttonListaClientes.Text = "Lista de Clientes";
            buttonListaClientes.UseVisualStyleBackColor = true;
            buttonListaClientes.Click += buttonListaClientes_Click;
            // 
            // buttonListaPedidos
            // 
            buttonListaPedidos.Location = new Point(438, 204);
            buttonListaPedidos.Name = "buttonListaPedidos";
            buttonListaPedidos.Size = new Size(207, 186);
            buttonListaPedidos.TabIndex = 6;
            buttonListaPedidos.Text = "Lista de Pedidos";
            buttonListaPedidos.UseVisualStyleBackColor = true;
            buttonListaPedidos.Click += buttonListaPedidos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(buttonListaPedidos);
            Controls.Add(buttonListaClientes);
            Controls.Add(buttonListaProdutos);
            Controls.Add(buttonCadastroSimplificadoProdutoBancoDados);
            Controls.Add(buttonCadastroFilmes);
            Controls.Add(buttonCadastroSimplificadoProduto);
            Controls.Add(buttonFolhaPagamento);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Windows Forms";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFolhaPagamento;
        private Button buttonCadastroSimplificadoProduto;
        private Button buttonCadastroFilmes;
        private Button buttonCadastroSimplificadoProdutoBancoDados;
        private Button buttonListaProdutos;
        private Button buttonListaClientes;
        private Button buttonListaPedidos;
    }
}