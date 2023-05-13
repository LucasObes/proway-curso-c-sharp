using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = 0;
            try
            {
                quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
                textBoxQuantidadeHoras.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantidade de horas deve conter somente números");
                textBoxQuantidadeHoras.Focus();
                textBoxQuantidadeHoras.ForeColor = Color.Red;
                return;
            }

            double valorHora = 0;
            try
            {
                valorHora = Convert.ToDouble(textBoxValorHora.Text);
                textBoxValorHora.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("O valor hora deve conter somenteo valor real");
                textBoxValorHora.Focus();
                textBoxValorHora.ForeColor = Color.Red;
                return;
            }

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;
            folhaPagamento.ValorHora = valorHora;

            MessageBox.Show(
            $@"Folha de pagamento: {folhaPagamento.NomeColaborador}
            Salário bruto: {folhaPagamento.CalcularSalarioBruto():C}
            Desconto INSS: {folhaPagamento.CalcularInss():C}");

            string jsonFolhaPagamento = JsonConvert.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\73368\\Desktop\\Arquivo.json", jsonFolhaPagamento);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValorHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelValorHora_Click(object sender, EventArgs e)
        {

        }
    }
}