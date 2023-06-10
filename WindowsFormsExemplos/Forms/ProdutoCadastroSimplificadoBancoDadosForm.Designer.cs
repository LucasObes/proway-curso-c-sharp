namespace WindowsFormsExemplos.Forms
{
    partial class ProdutoCadastroSimplificadoBancoDadosForm
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
            dataGridView1 = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            CollumnNome = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPreco = new DataGridViewTextBoxColumn();
            textBoxNome = new TextBox();
            textBoxQuantidade = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            buttonSalvar = new Button();
            labelListaProdutos = new Label();
            labelPrecoUnitario = new Label();
            labelTextoQuantidade = new Label();
            labelNome = new Label();
            buttonEditar = new Button();
            button1Apagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, CollumnNome, ColumnQuantidade, ColumnPrecoUnitario, ColumnPreco });
            dataGridView1.Location = new Point(14, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(622, 519);
            dataGridView1.TabIndex = 19;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // CollumnNome
            // 
            CollumnNome.HeaderText = "Nome";
            CollumnNome.MinimumWidth = 6;
            CollumnNome.Name = "CollumnNome";
            CollumnNome.ReadOnly = true;
            CollumnNome.Width = 125;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.MinimumWidth = 6;
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            ColumnQuantidade.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // ColumnPreco
            // 
            ColumnPreco.HeaderText = "Preço";
            ColumnPreco.MinimumWidth = 6;
            ColumnPreco.Name = "ColumnPreco";
            ColumnPreco.ReadOnly = true;
            ColumnPreco.Width = 125;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNome.Location = new Point(642, 45);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(428, 27);
            textBoxNome.TabIndex = 12;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxQuantidade.Location = new Point(642, 104);
            textBoxQuantidade.Margin = new Padding(3, 4, 3, 4);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(428, 27);
            textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPrecoUnitario.Location = new Point(642, 163);
            textBoxPrecoUnitario.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.Size = new Size(428, 27);
            textBoxPrecoUnitario.TabIndex = 16;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSalvar.BackgroundImageLayout = ImageLayout.None;
            buttonSalvar.Image = Properties.Resources.floppy_disk1;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(977, 201);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 59);
            buttonSalvar.TabIndex = 18;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // labelListaProdutos
            // 
            labelListaProdutos.AutoSize = true;
            labelListaProdutos.Location = new Point(14, 15);
            labelListaProdutos.Name = "labelListaProdutos";
            labelListaProdutos.Size = new Size(123, 20);
            labelListaProdutos.TabIndex = 17;
            labelListaProdutos.Text = "Lista de Produtos";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(642, 139);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 15;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelTextoQuantidade
            // 
            labelTextoQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTextoQuantidade.AutoSize = true;
            labelTextoQuantidade.Location = new Point(642, 80);
            labelTextoQuantidade.Name = "labelTextoQuantidade";
            labelTextoQuantidade.Size = new Size(87, 20);
            labelTextoQuantidade.TabIndex = 13;
            labelTextoQuantidade.Text = "Quantidade";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(642, 21);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 11;
            labelNome.Text = "Nome";
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(450, 45);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 21;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // button1Apagar
            // 
            button1Apagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1Apagar.Location = new Point(542, 45);
            button1Apagar.Margin = new Padding(3, 4, 3, 4);
            button1Apagar.Name = "button1Apagar";
            button1Apagar.Size = new Size(86, 31);
            button1Apagar.TabIndex = 20;
            button1Apagar.Text = "Apagar";
            button1Apagar.UseVisualStyleBackColor = true;
            button1Apagar.Click += button1Apagar_Click;
            // 
            // ProdutoCadastroSimplificadoBancoDadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 616);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(buttonSalvar);
            Controls.Add(labelListaProdutos);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelTextoQuantidade);
            Controls.Add(labelNome);
            Controls.Add(buttonEditar);
            Controls.Add(button1Apagar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProdutoCadastroSimplificadoBancoDadosForm";
            Text = "ProdutoCadastroSimplificadoBancoDadosForm";
            Load += ProdutoCadastroSimplificadoBancoDadosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxNome;
        private TextBox textBoxQuantidade;
        private TextBox textBoxPrecoUnitario;
        private Button buttonSalvar;
        private Label labelListaProdutos;
        private Label labelPrecoUnitario;
        private Label labelTextoQuantidade;
        private Label labelNome;
        private Button buttonEditar;
        private Button button1Apagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn CollumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreco;
    }
}