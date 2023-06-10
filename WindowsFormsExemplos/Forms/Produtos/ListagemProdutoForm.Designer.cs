﻿namespace WindowsFormsExemplos.Forms.Produtos
{
    partial class ListagemProdutoForm
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
            buttonEditar = new Button();
            button1Apagar = new Button();
            buttonCadastrar = new Button();
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
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1163, 603);
            dataGridView1.TabIndex = 20;
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
            CollumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CollumnNome.HeaderText = "Nome";
            CollumnNome.MinimumWidth = 6;
            CollumnNome.Name = "CollumnNome";
            CollumnNome.ReadOnly = true;
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
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(905, 23);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(86, 31);
            buttonEditar.TabIndex = 23;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // button1Apagar
            // 
            button1Apagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1Apagar.Location = new Point(997, 23);
            button1Apagar.Margin = new Padding(3, 4, 3, 4);
            button1Apagar.Name = "button1Apagar";
            button1Apagar.Size = new Size(86, 31);
            button1Apagar.TabIndex = 22;
            button1Apagar.Text = "Apagar";
            button1Apagar.UseVisualStyleBackColor = true;
            button1Apagar.Click += button1Apagar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCadastrar.Location = new Point(1089, 23);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(86, 31);
            buttonCadastrar.TabIndex = 24;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // ListagemProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 678);
            Controls.Add(buttonCadastrar);
            Controls.Add(buttonEditar);
            Controls.Add(button1Apagar);
            Controls.Add(dataGridView1);
            Name = "ListagemProdutoForm";
            Text = "Lista de Produtos";
            Load += ListagemProdutoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn CollumnNome;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPreco;
        private Button buttonEditar;
        private Button button1Apagar;
        private Button buttonCadastrar;
    }
}