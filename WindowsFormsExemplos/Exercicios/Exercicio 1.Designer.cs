namespace WindowsFormsExemplos.Exercicios
{
    partial class Exercicio_1
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
            buttonGerenciarTarefas = new Button();
            buttonGerenciarContatos = new Button();
            buttonCalculadora = new Button();
            SuspendLayout();
            // 
            // buttonGerenciarTarefas
            // 
            buttonGerenciarTarefas.Location = new Point(12, 12);
            buttonGerenciarTarefas.Name = "buttonGerenciarTarefas";
            buttonGerenciarTarefas.Size = new Size(222, 201);
            buttonGerenciarTarefas.TabIndex = 0;
            buttonGerenciarTarefas.Text = "Gerenciamento de tarefas";
            buttonGerenciarTarefas.UseVisualStyleBackColor = true;
            buttonGerenciarTarefas.Click += buttonGerenciarTarefas_Click;
            // 
            // buttonGerenciarContatos
            // 
            buttonGerenciarContatos.Location = new Point(240, 12);
            buttonGerenciarContatos.Name = "buttonGerenciarContatos";
            buttonGerenciarContatos.Size = new Size(222, 201);
            buttonGerenciarContatos.TabIndex = 1;
            buttonGerenciarContatos.Text = "Gerenciamento de contatos";
            buttonGerenciarContatos.UseVisualStyleBackColor = true;
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Location = new Point(468, 12);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(222, 201);
            buttonCalculadora.TabIndex = 2;
            buttonCalculadora.Text = "Calculadora IMC";
            buttonCalculadora.UseVisualStyleBackColor = true;
            buttonCalculadora.Click += buttonCalculadora_Click;
            // 
            // Exercicio_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 610);
            Controls.Add(buttonCalculadora);
            Controls.Add(buttonGerenciarContatos);
            Controls.Add(buttonGerenciarTarefas);
            Name = "Exercicio_1";
            Text = "Exercicio_1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGerenciarTarefas;
        private Button buttonGerenciarContatos;
        private Button buttonCalculadora;
    }
}