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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTextoQuantidade = new System.Windows.Forms.Label();
            this.labelPrecoUnitario = new System.Windows.Forms.Label();
            this.labelListaProdutos = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxPrecoUnitario = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CollumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(413, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelTextoQuantidade
            // 
            this.labelTextoQuantidade.AutoSize = true;
            this.labelTextoQuantidade.Location = new System.Drawing.Point(413, 58);
            this.labelTextoQuantidade.Name = "labelTextoQuantidade";
            this.labelTextoQuantidade.Size = new System.Drawing.Size(69, 15);
            this.labelTextoQuantidade.TabIndex = 1;
            this.labelTextoQuantidade.Text = "Quantidade";
            this.labelTextoQuantidade.Click += new System.EventHandler(this.labelTextoQuantidade_Click);
            // 
            // labelPrecoUnitario
            // 
            this.labelPrecoUnitario.AutoSize = true;
            this.labelPrecoUnitario.Location = new System.Drawing.Point(413, 102);
            this.labelPrecoUnitario.Name = "labelPrecoUnitario";
            this.labelPrecoUnitario.Size = new System.Drawing.Size(82, 15);
            this.labelPrecoUnitario.TabIndex = 2;
            this.labelPrecoUnitario.Text = "Preço Unitário";
            this.labelPrecoUnitario.Click += new System.EventHandler(this.labelPrecoUnitario_Click);
            // 
            // labelListaProdutos
            // 
            this.labelListaProdutos.AutoSize = true;
            this.labelListaProdutos.Location = new System.Drawing.Point(12, 9);
            this.labelListaProdutos.Name = "labelListaProdutos";
            this.labelListaProdutos.Size = new System.Drawing.Size(98, 15);
            this.labelListaProdutos.TabIndex = 3;
            this.labelListaProdutos.Text = "Lista de Produtos";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(713, 149);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxPrecoUnitario
            // 
            this.textBoxPrecoUnitario.Location = new System.Drawing.Point(413, 120);
            this.textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            this.textBoxPrecoUnitario.Size = new System.Drawing.Size(375, 23);
            this.textBoxPrecoUnitario.TabIndex = 3;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(413, 76);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(375, 23);
            this.textBoxQuantidade.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(413, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(375, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollumnNome,
            this.ColumnQuantidade,
            this.ColumnPrecoUnitario,
            this.ColumnPreco});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(395, 393);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CollumnNome
            // 
            this.CollumnNome.HeaderText = "Nome";
            this.CollumnNome.Name = "CollumnNome";
            this.CollumnNome.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            // 
            // ColumnPrecoUnitario
            // 
            this.ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            this.ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            this.ColumnPrecoUnitario.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(325, 32);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(244, 32);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // ProdutoCadastroSimplificadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxPrecoUnitario);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelListaProdutos);
            this.Controls.Add(this.labelPrecoUnitario);
            this.Controls.Add(this.labelTextoQuantidade);
            this.Controls.Add(this.labelNome);
            this.Name = "ProdutoCadastroSimplificadoForm";
            this.Text = "ProdutoCadastroSimplificadoForm";
            this.Load += new System.EventHandler(this.ProdutoCadastroSimplificadoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button buttonApagar;
        private Button buttonEditar;
    }
}