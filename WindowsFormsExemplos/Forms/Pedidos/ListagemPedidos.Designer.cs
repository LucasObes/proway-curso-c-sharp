namespace WindowsFormsExemplos.Forms.Pedidos
{
    partial class ListagemPedidos
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
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnValorTotal = new DataGridViewTextBoxColumn();
            labelCliente = new Label();
            comboBoxCliente = new ComboBox();
            radioButtonStatusTodos = new RadioButton();
            radioButtonStatusOrcamentos = new RadioButton();
            radioButtonStatusEfetivados = new RadioButton();
            radioButtonStatusCancelados = new RadioButton();
            labelStatus = new Label();
            buttonCriarOrcamento = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCliente, ColumnStatus, ColumnValorTotal });
            dataGridView1.Location = new Point(12, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            ColumnCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            ColumnCliente.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // ColumnValorTotal
            // 
            ColumnValorTotal.HeaderText = "Valor Total";
            ColumnValorTotal.Name = "ColumnValorTotal";
            ColumnValorTotal.ReadOnly = true;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(12, 9);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 1;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(12, 27);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(240, 23);
            comboBoxCliente.TabIndex = 2;
            comboBoxCliente.ValueMember = "Nome";
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // radioButtonStatusTodos
            // 
            radioButtonStatusTodos.AutoSize = true;
            radioButtonStatusTodos.Checked = true;
            radioButtonStatusTodos.Location = new Point(271, 28);
            radioButtonStatusTodos.Name = "radioButtonStatusTodos";
            radioButtonStatusTodos.Size = new Size(56, 19);
            radioButtonStatusTodos.TabIndex = 3;
            radioButtonStatusTodos.TabStop = true;
            radioButtonStatusTodos.Text = "Todos";
            radioButtonStatusTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusOrcamentos
            // 
            radioButtonStatusOrcamentos.AutoSize = true;
            radioButtonStatusOrcamentos.Location = new Point(271, 53);
            radioButtonStatusOrcamentos.Name = "radioButtonStatusOrcamentos";
            radioButtonStatusOrcamentos.Size = new Size(90, 19);
            radioButtonStatusOrcamentos.TabIndex = 4;
            radioButtonStatusOrcamentos.Text = "Orçamentos";
            radioButtonStatusOrcamentos.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusEfetivados
            // 
            radioButtonStatusEfetivados.AutoSize = true;
            radioButtonStatusEfetivados.Location = new Point(382, 27);
            radioButtonStatusEfetivados.Name = "radioButtonStatusEfetivados";
            radioButtonStatusEfetivados.Size = new Size(79, 19);
            radioButtonStatusEfetivados.TabIndex = 5;
            radioButtonStatusEfetivados.Text = "Efetivados";
            radioButtonStatusEfetivados.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusCancelados
            // 
            radioButtonStatusCancelados.AutoSize = true;
            radioButtonStatusCancelados.Location = new Point(382, 53);
            radioButtonStatusCancelados.Name = "radioButtonStatusCancelados";
            radioButtonStatusCancelados.Size = new Size(86, 19);
            radioButtonStatusCancelados.TabIndex = 6;
            radioButtonStatusCancelados.Text = "Cancelados";
            radioButtonStatusCancelados.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(271, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status";
            // 
            // buttonCriarOrcamento
            // 
            buttonCriarOrcamento.Location = new Point(668, 12);
            buttonCriarOrcamento.Name = "buttonCriarOrcamento";
            buttonCriarOrcamento.Size = new Size(120, 106);
            buttonCriarOrcamento.TabIndex = 8;
            buttonCriarOrcamento.Text = "Criar orçamento";
            buttonCriarOrcamento.UseVisualStyleBackColor = true;
            buttonCriarOrcamento.Click += buttonCriarOrcamento_Click;
            // 
            // ListagemPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCriarOrcamento);
            Controls.Add(labelStatus);
            Controls.Add(radioButtonStatusCancelados);
            Controls.Add(radioButtonStatusEfetivados);
            Controls.Add(radioButtonStatusOrcamentos);
            Controls.Add(radioButtonStatusTodos);
            Controls.Add(comboBoxCliente);
            Controls.Add(labelCliente);
            Controls.Add(dataGridView1);
            Name = "ListagemPedidos";
            Text = "ListagemPedidos";
            Load += ListagemPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelCliente;
        private ComboBox comboBoxCliente;
        private RadioButton radioButtonStatusTodos;
        private RadioButton radioButtonStatusOrcamentos;
        private RadioButton radioButtonStatusEfetivados;
        private RadioButton radioButtonStatusCancelados;
        private Label labelStatus;
        private Button buttonCriarOrcamento;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnValorTotal;
    }
}