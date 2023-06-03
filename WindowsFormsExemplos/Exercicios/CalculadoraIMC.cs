using ProWayModelos;
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
    public partial class CalculadoraIMC : Form
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void buttonCalcularImc_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();

            var altura = 0.0;
            try
            {
                altura = Convert.ToDouble(textBoxAltura.Text);
                textBoxAltura.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("O valor correspondente da altura deve conter somente números");
                textBoxAltura.Focus();
                textBoxAltura.ForeColor = Color.Crimson;
                return;
            }

            var peso = 0.0;
            try
            {
                peso = Convert.ToDouble(textBoxPeso.Text);
                textBoxPeso.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("O valor que corresponde ao peso deve conter somente números");
                textBoxPeso.Focus();
                textBoxPeso.ForeColor = Color.Crimson;
                return;
            }

            CalculadoraImc calcularIMC = new CalculadoraImc();
            calcularIMC.nome = nome;
            calcularIMC.altura = altura;
            calcularIMC.peso = peso;

            MessageBox.Show($@"Nome: {calcularIMC.nome}
            IMC: {calcularIMC.CalcularImc()}
            Classificação: {calcularIMC.IndiceImc}");
        }
    }
}
