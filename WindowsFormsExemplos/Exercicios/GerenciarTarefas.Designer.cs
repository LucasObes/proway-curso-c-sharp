namespace WindowsFormsExemplos.Exercicios
{
    partial class GerenciarTarefas
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
            dataGridViewLista = new DataGridView();
            ColumnCodigo = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnTarefa = new DataGridViewTextBoxColumn();
            ColumnClassificacao = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            labelTarefas = new Label();
            labelTarefa = new Label();
            labelData = new Label();
            labelNivell = new Label();
            textBoxTarefa = new TextBox();
            comboBoxNivel = new ComboBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            buttonApagar = new Button();
            buttonEditar = new Button();
            labelFiltro = new Label();
            textBoxFiltro = new TextBox();
            richTextBoxDescricao = new RichTextBox();
            labelDescricao = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            dateTimePickerData = new DateTimePicker();
            labelQuantidade = new Label();
            labelQuantidadeValor = new Label();
            labelCodigoEditar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Columns.AddRange(new DataGridViewColumn[] { ColumnCodigo, ColumnNome, ColumnTarefa, ColumnClassificacao, ColumnData });
            dataGridViewLista.Location = new Point(12, 65);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.ReadOnly = true;
            dataGridViewLista.RowTemplate.Height = 25;
            dataGridViewLista.Size = new Size(544, 441);
            dataGridViewLista.TabIndex = 0;
            // 
            // ColumnCodigo
            // 
            ColumnCodigo.HeaderText = "Código";
            ColumnCodigo.Name = "ColumnCodigo";
            ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome responsável";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnTarefa
            // 
            ColumnTarefa.HeaderText = "Tarefa";
            ColumnTarefa.Name = "ColumnTarefa";
            ColumnTarefa.ReadOnly = true;
            // 
            // ColumnClassificacao
            // 
            ColumnClassificacao.HeaderText = "Classificação";
            ColumnClassificacao.Name = "ColumnClassificacao";
            ColumnClassificacao.ReadOnly = true;
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "Data";
            ColumnData.Name = "ColumnData";
            ColumnData.ReadOnly = true;
            // 
            // labelTarefas
            // 
            labelTarefas.AutoSize = true;
            labelTarefas.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTarefas.ForeColor = SystemColors.Desktop;
            labelTarefas.Location = new Point(12, 34);
            labelTarefas.Name = "labelTarefas";
            labelTarefas.Size = new Size(251, 25);
            labelTarefas.TabIndex = 1;
            labelTarefas.Text = "O que tem pra hoje?";
            labelTarefas.Click += label1_Click;
            // 
            // labelTarefa
            // 
            labelTarefa.AutoSize = true;
            labelTarefa.Location = new Point(647, 78);
            labelTarefa.Name = "labelTarefa";
            labelTarefa.Size = new Size(38, 15);
            labelTarefa.TabIndex = 2;
            labelTarefa.Text = "Tarefa";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(750, 382);
            labelData.Name = "labelData";
            labelData.Size = new Size(90, 15);
            labelData.TabIndex = 3;
            labelData.Text = "Data de entrega";
            // 
            // labelNivell
            // 
            labelNivell.AutoSize = true;
            labelNivell.Location = new Point(647, 141);
            labelNivell.Name = "labelNivell";
            labelNivell.Size = new Size(99, 15);
            labelNivell.TabIndex = 4;
            labelNivell.Text = "Nivel de urgência";
            // 
            // textBoxTarefa
            // 
            textBoxTarefa.Location = new Point(647, 96);
            textBoxTarefa.Name = "textBoxTarefa";
            textBoxTarefa.Size = new Size(318, 23);
            textBoxTarefa.TabIndex = 2;
            // 
            // comboBoxNivel
            // 
            comboBoxNivel.FormattingEnabled = true;
            comboBoxNivel.Location = new Point(647, 159);
            comboBoxNivel.Name = "comboBoxNivel";
            comboBoxNivel.Size = new Size(318, 23);
            comboBoxNivel.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(728, 438);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 68);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(647, 438);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 68);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(890, 438);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(75, 68);
            buttonApagar.TabIndex = 9;
            buttonApagar.Text = "Apagar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(809, 438);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 68);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelFiltro
            // 
            labelFiltro.AutoSize = true;
            labelFiltro.Location = new Point(344, 18);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Size = new Size(34, 15);
            labelFiltro.TabIndex = 13;
            labelFiltro.Text = "Filtro";
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(344, 36);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(212, 23);
            textBoxFiltro.TabIndex = 14;
            textBoxFiltro.TextChanged += textBoxFiltro_TextChanged;
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(647, 223);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(318, 130);
            richTextBoxDescricao.TabIndex = 4;
            richTextBoxDescricao.Text = "";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(647, 205);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(107, 15);
            labelDescricao.TabIndex = 16;
            labelDescricao.Text = "Descrição da tarefa";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(647, 17);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(105, 15);
            labelNome.TabIndex = 17;
            labelNome.Text = "Nome responsável";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(647, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(318, 23);
            textBoxNome.TabIndex = 1;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(647, 400);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(318, 23);
            dateTimePickerData.TabIndex = 5;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(468, 516);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 20;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelQuantidadeValor
            // 
            labelQuantidadeValor.AutoSize = true;
            labelQuantidadeValor.Location = new Point(543, 516);
            labelQuantidadeValor.Name = "labelQuantidadeValor";
            labelQuantidadeValor.Size = new Size(13, 15);
            labelQuantidadeValor.TabIndex = 21;
            labelQuantidadeValor.Text = "0";
            // 
            // labelCodigoEditar
            // 
            labelCodigoEditar.AutoSize = true;
            labelCodigoEditar.Location = new Point(982, 12);
            labelCodigoEditar.Name = "labelCodigoEditar";
            labelCodigoEditar.Size = new Size(0, 15);
            labelCodigoEditar.TabIndex = 22;
            // 
            // GerenciarTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 575);
            Controls.Add(labelCodigoEditar);
            Controls.Add(labelQuantidadeValor);
            Controls.Add(labelQuantidade);
            Controls.Add(dateTimePickerData);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelDescricao);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(textBoxFiltro);
            Controls.Add(labelFiltro);
            Controls.Add(buttonEditar);
            Controls.Add(buttonApagar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonCancelar);
            Controls.Add(comboBoxNivel);
            Controls.Add(textBoxTarefa);
            Controls.Add(labelNivell);
            Controls.Add(labelData);
            Controls.Add(labelTarefa);
            Controls.Add(labelTarefas);
            Controls.Add(dataGridViewLista);
            Name = "GerenciarTarefas";
            Text = "GerenciarTarefas";
            Load += GerenciarTarefas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLista;
        private Label labelTarefas;
        private Label labelTarefa;
        private Label labelData;
        private Label labelNivell;
        private TextBox textBoxTarefa;
        private ComboBox comboBoxNivel;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Button buttonApagar;
        private Button buttonEditar;
        private Label labelFiltro;
        private TextBox textBoxFiltro;
        private RichTextBox richTextBoxDescricao;
        private Label labelDescricao;
        private Label labelNome;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerData;
        private Label labelQuantidade;
        private Label labelQuantidadeValor;
        private Label labelCodigoEditar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnTarefa;
        private DataGridViewTextBoxColumn ColumnClassificacao;
        private DataGridViewTextBoxColumn ColumnData;
    }
}