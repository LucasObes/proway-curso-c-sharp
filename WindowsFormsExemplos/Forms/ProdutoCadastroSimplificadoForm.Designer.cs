namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplificadoForm
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
            labelNome = new Label();
            labelTextoQuantidade = new Label();
            labelPrecoUnitario = new Label();
            labelListaProdutos = new Label();
            buttonSalvar = new Button();
            textBoxPrecoUnitario = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxNome = new TextBox();
            dataGridView1 = new DataGridView();
            CollumnNome = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            button1Apagar = new Button();
            buttonEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(413, 14);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            labelNome.Click += labelNome_Click;
            // 
            // labelTextoQuantidade
            // 
            labelTextoQuantidade.AutoSize = true;
            labelTextoQuantidade.Location = new Point(413, 58);
            labelTextoQuantidade.Name = "labelTextoQuantidade";
            labelTextoQuantidade.Size = new Size(69, 15);
            labelTextoQuantidade.TabIndex = 1;
            labelTextoQuantidade.Text = "Quantidade";
            labelTextoQuantidade.Click += labelTextoQuantidade_Click;
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(413, 102);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(82, 15);
            labelPrecoUnitario.TabIndex = 2;
            labelPrecoUnitario.Text = "Preço Unitário";
            labelPrecoUnitario.Click += labelPrecoUnitario_Click;
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(12, 9);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(98, 15);
            labelListaProdutos.TabIndex = 3;
            labelListaProdutos.Text = "Lista de Produtos";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(713, 149);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Location = new Point(413, 120);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(375, 23);
            textBoxPrecoUnitario.TabIndex = 3;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(413, 76);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(375, 23);
            textBoxQuantidade.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(413, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(375, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CollumnNome, ColumnQuantidade, ColumnPrecoUnitario, ColumnPreco });
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(395, 393);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CollumnNome
            // 
            CollumnNome.HeaderText = "Nome";
            CollumnNome.Name = "CollumnNome";
            CollumnNome.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preço";
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            // 
            // button1Apagar
            // 
            button1Apagar.Location = new Point(325, 32);
            button1Apagar.Name = "button1Apagar";
            button1Apagar.Size = new Size(75, 23);
            button1Apagar.TabIndex = 9;
            button1Apagar.Text = "Apagar";
            button1Apagar.UseVisualStyleBackColor = true;
            button1Apagar.Click += button1_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(244, 32);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 10;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // ProdutoCadastroSimplificadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEditar);
            Controls.Add(button1Apagar);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(buttonSalvar);
            Controls.Add(labelListaProdutos);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelTextoQuantidade);
            Controls.Add(labelNome);
            Name = "ProdutoCadastroSimplificadoForm";
            Text = "ProdutoCadastroSimplificadoForm";
            Load += ProdutoCadastroSimplificadoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelTextoQuantidade;
        private Label labelPrecoUnitario;
        private Label labelListaProdutos;
        private Button buttonSalvar;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxQuantidade;
        private TextBox textBoxNome;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CollumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreco;
        private Button button1Apagar;
        private Button buttonEditar;
    }
}