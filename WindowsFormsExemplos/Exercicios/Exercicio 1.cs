using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExemplos.Exercicios
{
    public partial class Exercicio_1 : Form
    {
        public Exercicio_1()
        {
            InitializeComponent();
        }

        private void buttonGerenciarTarefas_Click(object sender, EventArgs e)
        {
            GerenciarTarefas form = new GerenciarTarefas();
            form.ShowDialog();
        }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            CalculadoraIMC form = new CalculadoraIMC();
            form.ShowDialog();
        }
    }
}
