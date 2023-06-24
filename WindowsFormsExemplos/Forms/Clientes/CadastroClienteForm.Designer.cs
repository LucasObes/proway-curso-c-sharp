namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class CadastroClienteForm
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
            textBoxNome = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            labelCPF = new Label();
            labelDataDeNascimento = new Label();
            dateTimePickerDataDeNascimento = new DateTimePicker();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            labelBairro = new Label();
            textBoxBairro = new TextBox();
            labelCep = new Label();
            labelLogradouro = new Label();
            textBoxLogradouro = new TextBox();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            labelComplemento = new Label();
            richTextBoxComplemento = new RichTextBox();
            maskedTextBoxCep = new MaskedTextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(8, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(8, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(337, 23);
            textBoxNome.TabIndex = 1;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(8, 75);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(121, 23);
            maskedTextBoxCpf.TabIndex = 2;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(8, 57);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(28, 15);
            labelCPF.TabIndex = 3;
            labelCPF.Text = "CPF";
            // 
            // labelDataDeNascimento
            // 
            labelDataDeNascimento.AutoSize = true;
            labelDataDeNascimento.Location = new Point(145, 57);
            labelDataDeNascimento.Name = "labelDataDeNascimento";
            labelDataDeNascimento.Size = new Size(114, 15);
            labelDataDeNascimento.TabIndex = 4;
            labelDataDeNascimento.Text = "Data de Nascimento";
            // 
            // dateTimePickerDataDeNascimento
            // 
            dateTimePickerDataDeNascimento.Format = DateTimePickerFormat.Short;
            dateTimePickerDataDeNascimento.Location = new Point(145, 75);
            dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            dateTimePickerDataDeNascimento.Size = new Size(200, 23);
            dateTimePickerDataDeNascimento.TabIndex = 3;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(8, 107);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 6;
            labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxEstado.Location = new Point(8, 125);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(84, 23);
            comboBoxEstado.TabIndex = 4;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(101, 107);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(44, 15);
            labelCidade.TabIndex = 8;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(101, 125);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(244, 23);
            textBoxCidade.TabIndex = 5;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(8, 155);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 10;
            labelBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(8, 175);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(215, 23);
            textBoxBairro.TabIndex = 6;
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(239, 157);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 12;
            labelCep.Text = "CEP";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(8, 208);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 14;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(8, 226);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(337, 23);
            textBoxLogradouro.TabIndex = 8;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(8, 257);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 16;
            labelNumero.Text = "Número";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(8, 275);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(337, 23);
            textBoxNumero.TabIndex = 9;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(8, 312);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 18;
            labelComplemento.Text = "Complemento";
            // 
            // richTextBoxComplemento
            // 
            richTextBoxComplemento.Location = new Point(8, 330);
            richTextBoxComplemento.Name = "richTextBoxComplemento";
            richTextBoxComplemento.Size = new Size(337, 134);
            richTextBoxComplemento.TabIndex = 10;
            richTextBoxComplemento.Text = "";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(239, 175);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(106, 23);
            maskedTextBoxCep.TabIndex = 7;
            maskedTextBoxCep.KeyDown += maskedTextBoxCep_KeyDown;
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(8, 470);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(337, 34);
            buttonCadastrar.TabIndex = 21;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 509);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(richTextBoxComplemento);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumero);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelLogradouro);
            Controls.Add(labelCep);
            Controls.Add(textBoxBairro);
            Controls.Add(labelBairro);
            Controls.Add(textBoxCidade);
            Controls.Add(labelCidade);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(dateTimePickerDataDeNascimento);
            Controls.Add(labelDataDeNascimento);
            Controls.Add(labelCPF);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "CadastroClienteForm";
            Text = "CadastroClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelCPF;
        private Label labelDataDeNascimento;
        private DateTimePicker dateTimePickerDataDeNascimento;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private Label labelBairro;
        private TextBox textBoxBairro;
        private Label labelCep;
        private TextBox textBoxCep;
        private Label labelLogradouro;
        private TextBox textBoxLogradouro;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private Label labelComplemento;
        private RichTextBox richTextBoxComplemento;
        private MaskedTextBox maskedTextBoxCep;
        private Button buttonCadastrar;
    }
}