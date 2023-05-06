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
            int quantidadeHoras = Convert.ToInt32(textBoxQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(textBoxValorHora.Text);

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
    }
}