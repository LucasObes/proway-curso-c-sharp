namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class CadastroPedidosForm
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
            labelCliente = new Label();
            comboBoxCliente = new ComboBox();
            buttonCriarOrcamento = new Button();
            labelCodigo = new Label();
            labelCodigoValor = new Label();
            labelProduto = new Label();
            comboBoxProduto = new ComboBox();
            labelQuantidade = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            labelPrecoUnitario = new Label();
            labelPrecoUnitarioValor = new Label();
            labelTotal = new Label();
            labelTotalValor = new Label();
            dataGridViewCarrinho = new DataGridView();
            labelCarrinho = new Label();
            buttonAdicionar = new Button();
            labelTotalPedido = new Label();
            labelTotalPedidoValor = new Label();
            buttonFecharPedido = new Button();
            buttonCancelarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(14, 40);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(14, 58);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(362, 23);
            comboBoxCliente.TabIndex = 1;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // buttonCriarOrcamento
            // 
            buttonCriarOrcamento.Location = new Point(243, 87);
            buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            buttonCriarOrcamento.Size = new Size(133, 23);
            buttonCriarOrcamento.TabIndex = 2;
            buttonCriarOrcamento.Text = "Criar orçamento";
            buttonCriarOrcamento.UseVisualStyleBackColor = true;
            buttonCriarOrcamento.Click += buttonCriarOrcamento_Click;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(12, 18);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 3;
            labelCodigo.Text = "Código";
            // 
            // labelCodigoValor
            // 
            labelCodigoValor.AutoSize = true;
            labelCodigoValor.Location = new Point(64, 18);
            labelCodigoValor.Name = "labelCodigoValor";
            labelCodigoValor.Size = new Size(13, 15);
            labelCodigoValor.TabIndex = 4;
            labelCodigoValor.Text = "0";
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(442, 40);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 5;
            labelProduto.Text = "Produto";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(442, 58);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(401, 23);
            comboBoxProduto.TabIndex = 6;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(558, 99);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 7;
            labelQuantidade.Text = "Quantidade";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(558, 117);
            numericUpDownQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 8;
            numericUpDownQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(442, 99);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(82, 15);
            labelPrecoUnitario.TabIndex = 9;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelPrecoUnitarioValor
            // 
            labelPrecoUnitarioValor.AutoSize = true;
            labelPrecoUnitarioValor.Location = new Point(442, 119);
            labelPrecoUnitarioValor.Name = "labelPrecoUnitarioValor";
            labelPrecoUnitarioValor.Size = new Size(13, 15);
            labelPrecoUnitarioValor.TabIndex = 10;
            labelPrecoUnitarioValor.Text = "0";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(727, 99);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 11;
            labelTotal.Text = "Total";
            // 
            // labelTotalValor
            // 
            labelTotalValor.AutoSize = true;
            labelTotalValor.Location = new Point(727, 119);
            labelTotalValor.Name = "labelTotalValor";
            labelTotalValor.Size = new Size(13, 15);
            labelTotalValor.TabIndex = 12;
            labelTotalValor.Text = "0";
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new Point(442, 195);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.RowTemplate.Height = 25;
            dataGridViewCarrinho.Size = new Size(581, 304);
            dataGridViewCarrinho.TabIndex = 13;
            // 
            // labelCarrinho
            // 
            labelCarrinho.AutoSize = true;
            labelCarrinho.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCarrinho.Location = new Point(693, 171);
            labelCarrinho.Name = "labelCarrinho";
            labelCarrinho.Size = new Size(76, 21);
            labelCarrinho.TabIndex = 14;
            labelCarrinho.Text = "Carrinho";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(849, 28);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(174, 106);
            buttonAdicionar.TabIndex = 15;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // labelTotalPedido
            // 
            labelTotalPedido.AutoSize = true;
            labelTotalPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPedido.Location = new Point(892, 502);
            labelTotalPedido.Name = "labelTotalPedido";
            labelTotalPedido.Size = new Size(106, 21);
            labelTotalPedido.TabIndex = 16;
            labelTotalPedido.Text = "Total Pedido";
            // 
            // labelTotalPedidoValor
            // 
            labelTotalPedidoValor.AutoSize = true;
            labelTotalPedidoValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalPedidoValor.Location = new Point(1004, 502);
            labelTotalPedidoValor.Name = "labelTotalPedidoValor";
            labelTotalPedidoValor.Size = new Size(19, 21);
            labelTotalPedidoValor.TabIndex = 17;
            labelTotalPedidoValor.Text = "0";
            // 
            // buttonFecharPedido
            // 
            buttonFecharPedido.Location = new Point(442, 503);
            buttonFecharPedido.Name = "buttonFecharPedido";
            buttonFecharPedido.Size = new Size(185, 57);
            buttonFecharPedido.TabIndex = 18;
            buttonFecharPedido.Text = "Fechar Pedido";
            buttonFecharPedido.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarPedido
            // 
            buttonCancelarPedido.Location = new Point(648, 503);
            buttonCancelarPedido.Name = "buttonCancelarPedido";
            buttonCancelarPedido.Size = new Size(185, 57);
            buttonCancelarPedido.TabIndex = 19;
            buttonCancelarPedido.Text = "Cancelar Orçamento";
            buttonCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // CadastroPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 572);
            Controls.Add(buttonCancelarPedido);
            Controls.Add(buttonFecharPedido);
            Controls.Add(labelTotalPedidoValor);
            Controls.Add(labelTotalPedido);
            Controls.Add(buttonAdicionar);
            Controls.Add(labelCarrinho);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(labelTotalValor);
            Controls.Add(labelTotal);
            Controls.Add(labelPrecoUnitarioValor);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelQuantidade);
            Controls.Add(comboBoxProduto);
            Controls.Add(labelProduto);
            Controls.Add(labelCodigoValor);
            Controls.Add(labelCodigo);
            Controls.Add(buttonCriarOrcamento);
            Controls.Add(comboBoxCliente);
            Controls.Add(labelCliente);
            Name = "CadastroPedidosForm";
            Text = "CadastroPedidosForm";
            Load += CadastroPedidosForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCliente;
        private ComboBox comboBoxCliente;
        private Button buttonCriarOrcamento;
        private Label labelCodigo;
        private Label labelCodigoValor;
        private Label labelProduto;
        private ComboBox comboBoxProduto;
        private Label labelQuantidade;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelPrecoUnitario;
        private Label labelPrecoUnitarioValor;
        private Label labelTotal;
        private Label labelTotalValor;
        private DataGridView dataGridViewCarrinho;
        private Label labelCarrinho;
        private Button buttonAdicionar;
        private Label labelTotalPedido;
        private Label labelTotalPedidoValor;
        private Button buttonFecharPedido;
        private Button buttonCancelarPedido;
    }
}