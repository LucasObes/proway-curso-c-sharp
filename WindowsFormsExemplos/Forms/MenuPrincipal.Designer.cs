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
            SuspendLayout();
            // 
            // buttonFolhaPagamento
            // 
            buttonFolhaPagamento.Location = new Point(14, 16);
            buttonFolhaPagamento.Margin = new Padding(3, 4, 3, 4);
            buttonFolhaPagamento.Name = "buttonFolhaPagamento";
            buttonFolhaPagamento.Size = new Size(237, 248);
            buttonFolhaPagamento.TabIndex = 0;
            buttonFolhaPagamento.Text = "Folha de Pagamento";
            buttonFolhaPagamento.UseVisualStyleBackColor = true;
            buttonFolhaPagamento.Click += button1_Click;
            // 
            // buttonCadastroSimplificadoProduto
            // 
            buttonCadastroSimplificadoProduto.Location = new Point(257, 16);
            buttonCadastroSimplificadoProduto.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSimplificadoProduto.Name = "buttonCadastroSimplificadoProduto";
            buttonCadastroSimplificadoProduto.Size = new Size(237, 248);
            buttonCadastroSimplificadoProduto.TabIndex = 1;
            buttonCadastroSimplificadoProduto.Text = "Cadastro Simplificado Produto";
            buttonCadastroSimplificadoProduto.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProduto.Click += buttonCadastroSimplificadoProduto_Click;
            // 
            // buttonCadastroFilmes
            // 
            buttonCadastroFilmes.Location = new Point(501, 16);
            buttonCadastroFilmes.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroFilmes.Name = "buttonCadastroFilmes";
            buttonCadastroFilmes.Size = new Size(237, 248);
            buttonCadastroFilmes.TabIndex = 2;
            buttonCadastroFilmes.Text = "Cadastro de Filmes";
            buttonCadastroFilmes.UseVisualStyleBackColor = true;
            buttonCadastroFilmes.Click += buttonCadastroFilmes_Click;
            // 
            // buttonCadastroSimplificadoProdutoBancoDados
            // 
            buttonCadastroSimplificadoProdutoBancoDados.Location = new Point(744, 16);
            buttonCadastroSimplificadoProdutoBancoDados.Margin = new Padding(3, 4, 3, 4);
            buttonCadastroSimplificadoProdutoBancoDados.Name = "buttonCadastroSimplificadoProdutoBancoDados";
            buttonCadastroSimplificadoProdutoBancoDados.Size = new Size(237, 248);
            buttonCadastroSimplificadoProdutoBancoDados.TabIndex = 3;
            buttonCadastroSimplificadoProdutoBancoDados.Text = "Cadastro simplificado produto Banco Dados";
            buttonCadastroSimplificadoProdutoBancoDados.UseVisualStyleBackColor = true;
            buttonCadastroSimplificadoProdutoBancoDados.Click += buttonCadastroSimplificadoProdutoBancoDados_Click;
            // 
            // buttonListaProdutos
            // 
            buttonListaProdutos.Location = new Point(14, 272);
            buttonListaProdutos.Margin = new Padding(3, 4, 3, 4);
            buttonListaProdutos.Name = "buttonListaProdutos";
            buttonListaProdutos.Size = new Size(237, 248);
            buttonListaProdutos.TabIndex = 4;
            buttonListaProdutos.Text = "Lista de Produtos";
            buttonListaProdutos.UseVisualStyleBackColor = true;
            buttonListaProdutos.Click += buttonListaProdutos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 600);
            Controls.Add(buttonListaProdutos);
            Controls.Add(buttonCadastroSimplificadoProdutoBancoDados);
            Controls.Add(buttonCadastroFilmes);
            Controls.Add(buttonCadastroSimplificadoProduto);
            Controls.Add(buttonFolhaPagamento);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}