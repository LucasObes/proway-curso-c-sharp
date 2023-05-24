namespace WindowsFormsExemplos.Forms
{
    partial class FilmeCadastro
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            labelListaDeFilmes = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            labelMinutos = new Label();
            numericUpDownMinutos = new NumericUpDown();
            labelCategoria = new Label();
            comboBoxCategoria = new ComboBox();
            checkBoxVitoriaOscar = new CheckBox();
            checkBoxVitoriaEmmy = new CheckBox();
            checkBoxVitoriaGrammy = new CheckBox();
            radioButtonFlopouSim = new RadioButton();
            radioButtonFlopouNao = new RadioButton();
            buttonSalvar = new Button();
            richTextBoxDescricao = new RichTextBox();
            labelDescricao = new Label();
            labelDataLancamento = new Label();
            dateTimePickerDataLancamento = new DateTimePicker();
            labelQuantidadeValor = new Label();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            labelQuantidade = new Label();
            buttonCancelar = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelVitórias = new Label();
            labelFlopou = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(7, 68);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(563, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoria";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Duração";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // labelListaDeFilmes
            // 
            labelListaDeFilmes.AutoSize = true;
            labelListaDeFilmes.Font = new Font("Segoe UI Historic", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelListaDeFilmes.ForeColor = Color.Red;
            labelListaDeFilmes.Location = new Point(12, 21);
            labelListaDeFilmes.Name = "labelListaDeFilmes";
            labelListaDeFilmes.Size = new Size(175, 31);
            labelListaDeFilmes.TabIndex = 1;
            labelListaDeFilmes.Text = "Lista de filmes";
            labelListaDeFilmes.Click += labelListaDeFilmes_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(717, 24);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(459, 23);
            textBoxNome.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(717, 6);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelMinutos
            // 
            labelMinutos.AutoSize = true;
            labelMinutos.Location = new Point(717, 55);
            labelMinutos.Name = "labelMinutos";
            labelMinutos.Size = new Size(51, 15);
            labelMinutos.TabIndex = 4;
            labelMinutos.Text = "Minutos";
            // 
            // numericUpDownMinutos
            // 
            numericUpDownMinutos.Location = new Point(717, 73);
            numericUpDownMinutos.Name = "numericUpDownMinutos";
            numericUpDownMinutos.Size = new Size(162, 23);
            numericUpDownMinutos.TabIndex = 5;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(924, 55);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(58, 15);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoria";
            labelCategoria.Click += label4_Click;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(924, 73);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(252, 23);
            comboBoxCategoria.TabIndex = 7;
            comboBoxCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBoxVitoriaOscar
            // 
            checkBoxVitoriaOscar.AutoSize = true;
            checkBoxVitoriaOscar.Location = new Point(717, 132);
            checkBoxVitoriaOscar.Name = "checkBoxVitoriaOscar";
            checkBoxVitoriaOscar.Size = new Size(56, 19);
            checkBoxVitoriaOscar.TabIndex = 8;
            checkBoxVitoriaOscar.Text = "Oscar";
            checkBoxVitoriaOscar.UseVisualStyleBackColor = true;
            // 
            // checkBoxVitoriaEmmy
            // 
            checkBoxVitoriaEmmy.AutoSize = true;
            checkBoxVitoriaEmmy.Location = new Point(717, 157);
            checkBoxVitoriaEmmy.Name = "checkBoxVitoriaEmmy";
            checkBoxVitoriaEmmy.Size = new Size(60, 19);
            checkBoxVitoriaEmmy.TabIndex = 9;
            checkBoxVitoriaEmmy.Text = "Emmy";
            checkBoxVitoriaEmmy.UseVisualStyleBackColor = true;
            // 
            // checkBoxVitoriaGrammy
            // 
            checkBoxVitoriaGrammy.AutoSize = true;
            checkBoxVitoriaGrammy.Location = new Point(717, 182);
            checkBoxVitoriaGrammy.Name = "checkBoxVitoriaGrammy";
            checkBoxVitoriaGrammy.Size = new Size(72, 19);
            checkBoxVitoriaGrammy.TabIndex = 10;
            checkBoxVitoriaGrammy.Text = "Grammy";
            checkBoxVitoriaGrammy.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouSim
            // 
            radioButtonFlopouSim.AutoSize = true;
            radioButtonFlopouSim.Location = new Point(924, 132);
            radioButtonFlopouSim.Name = "radioButtonFlopouSim";
            radioButtonFlopouSim.Size = new Size(45, 19);
            radioButtonFlopouSim.TabIndex = 11;
            radioButtonFlopouSim.TabStop = true;
            radioButtonFlopouSim.Text = "Sim";
            radioButtonFlopouSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFlopouNao
            // 
            radioButtonFlopouNao.AutoSize = true;
            radioButtonFlopouNao.Location = new Point(924, 157);
            radioButtonFlopouNao.Name = "radioButtonFlopouNao";
            radioButtonFlopouNao.Size = new Size(47, 19);
            radioButtonFlopouNao.TabIndex = 12;
            radioButtonFlopouNao.TabStop = true;
            radioButtonFlopouNao.Text = "Não";
            radioButtonFlopouNao.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(1101, 478);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(717, 296);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(459, 176);
            richTextBoxDescricao.TabIndex = 14;
            richTextBoxDescricao.Text = "";
            richTextBoxDescricao.TextChanged += richTextBoxDescricao_TextChanged;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(717, 278);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(58, 15);
            labelDescricao.TabIndex = 15;
            labelDescricao.Text = "Descrição";
            // 
            // labelDataLancamento
            // 
            labelDataLancamento.AutoSize = true;
            labelDataLancamento.Location = new Point(717, 216);
            labelDataLancamento.Name = "labelDataLancamento";
            labelDataLancamento.Size = new Size(113, 15);
            labelDataLancamento.TabIndex = 16;
            labelDataLancamento.Text = "Data de lançamento";
            labelDataLancamento.Click += label6_Click;
            // 
            // dateTimePickerDataLancamento
            // 
            dateTimePickerDataLancamento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataLancamento.Location = new Point(717, 234);
            dateTimePickerDataLancamento.Name = "dateTimePickerDataLancamento";
            dateTimePickerDataLancamento.Size = new Size(459, 23);
            dateTimePickerDataLancamento.TabIndex = 19;
            // 
            // labelQuantidadeValor
            // 
            labelQuantidadeValor.AutoSize = true;
            labelQuantidadeValor.Location = new Point(557, 506);
            labelQuantidadeValor.Name = "labelQuantidadeValor";
            labelQuantidadeValor.Size = new Size(13, 15);
            labelQuantidadeValor.TabIndex = 18;
            labelQuantidadeValor.Text = "0";
            labelQuantidadeValor.Click += label7_Click;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(353, 21);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(53, 15);
            labelPesquisa.TabIndex = 19;
            labelPesquisa.Text = "Pesquisa";
            labelPesquisa.Click += labelPesquisa_Click;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(353, 39);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(287, 23);
            textBoxPesquisa.TabIndex = 20;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(468, 506);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 21;
            labelQuantidade.Text = "Quantidade";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(1020, 478);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(576, 68);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(64, 61);
            buttonEditar.TabIndex = 23;
            buttonEditar.Text = "Apagar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Location = new Point(576, 135);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(64, 61);
            buttonApagar.TabIndex = 24;
            buttonApagar.Text = "Editar";
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelVitórias
            // 
            labelVitórias.AutoSize = true;
            labelVitórias.Location = new Point(717, 114);
            labelVitórias.Name = "labelVitórias";
            labelVitórias.Size = new Size(46, 15);
            labelVitórias.TabIndex = 25;
            labelVitórias.Text = "Vitórias";
            // 
            // labelFlopou
            // 
            labelFlopou.AutoSize = true;
            labelFlopou.Location = new Point(924, 114);
            labelFlopou.Name = "labelFlopou";
            labelFlopou.Size = new Size(49, 15);
            labelFlopou.TabIndex = 26;
            labelFlopou.Text = "Flopou?";
            // 
            // FilmeCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 542);
            Controls.Add(labelFlopou);
            Controls.Add(labelVitórias);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCancelar);
            Controls.Add(labelQuantidade);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(labelQuantidadeValor);
            Controls.Add(dateTimePickerDataLancamento);
            Controls.Add(labelDataLancamento);
            Controls.Add(labelDescricao);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(buttonSalvar);
            Controls.Add(radioButtonFlopouNao);
            Controls.Add(radioButtonFlopouSim);
            Controls.Add(checkBoxVitoriaGrammy);
            Controls.Add(checkBoxVitoriaEmmy);
            Controls.Add(checkBoxVitoriaOscar);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(numericUpDownMinutos);
            Controls.Add(labelMinutos);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelListaDeFilmes);
            Controls.Add(dataGridView1);
            Name = "FilmeCadastro";
            Text = "FilmeCadastro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelListaDeFilmes;
        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelMinutos;
        private NumericUpDown numericUpDownMinutos;
        private Label labelCategoria;
        private ComboBox comboBoxCategoria;
        private CheckBox checkBoxVitoriaOscar;
        private CheckBox checkBoxVitoriaEmmy;
        private CheckBox checkBoxVitoriaGrammy;
        private RadioButton radioButtonFlopouSim;
        private RadioButton radioButtonFlopouNao;
        private Button buttonSalvar;
        private RichTextBox richTextBoxDescricao;
        private Label labelDescricao;
        private Label labelDataLancamento;
        private DateTimePicker dateTimePickerDataLancamento;
        private Label labelQuantidadeValor;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Label labelQuantidade;
        private Button buttonCancelar;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelVitórias;
        private Label labelFlopou;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}