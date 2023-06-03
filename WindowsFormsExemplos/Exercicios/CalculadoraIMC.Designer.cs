namespace WindowsFormsExemplos.Exercicios
{
    partial class CalculadoraIMC
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
            buttonCalcularImc = new Button();
            labelAltura = new Label();
            labelPeso = new Label();
            textBoxAltura = new TextBox();
            textBoxPeso = new TextBox();
            labelNome = new Label();
            textBoxNome = new TextBox();
            SuspendLayout();
            // 
            // buttonCalcularImc
            // 
            buttonCalcularImc.Location = new Point(12, 175);
            buttonCalcularImc.Name = "buttonCalcularImc";
            buttonCalcularImc.Size = new Size(392, 57);
            buttonCalcularImc.TabIndex = 4;
            buttonCalcularImc.Text = "Calcular IMC";
            buttonCalcularImc.UseVisualStyleBackColor = true;
            buttonCalcularImc.Click += buttonCalcularImc_Click;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(13, 72);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(42, 15);
            labelAltura.TabIndex = 6;
            labelAltura.Text = "Altura:";
            // 
            // labelPeso
            // 
            labelPeso.AutoSize = true;
            labelPeso.Location = new Point(13, 128);
            labelPeso.Name = "labelPeso";
            labelPeso.Size = new Size(35, 15);
            labelPeso.TabIndex = 5;
            labelPeso.Text = "Peso:";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(13, 90);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(392, 23);
            textBoxAltura.TabIndex = 2;
            // 
            // textBoxPeso
            // 
            textBoxPeso.Location = new Point(13, 146);
            textBoxPeso.Name = "textBoxPeso";
            textBoxPeso.Size = new Size(392, 23);
            textBoxPeso.TabIndex = 3;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 7;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(392, 23);
            textBoxNome.TabIndex = 1;
            // 
            // CalculadoraIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 245);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(textBoxPeso);
            Controls.Add(textBoxAltura);
            Controls.Add(labelPeso);
            Controls.Add(labelAltura);
            Controls.Add(buttonCalcularImc);
            Name = "CalculadoraIMC";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcularImc;
        private Label labelAltura;
        private Label labelPeso;
        private TextBox textBoxAltura;
        private TextBox textBoxPeso;
        private Label labelNome;
        private TextBox textBoxNome;
    }
}