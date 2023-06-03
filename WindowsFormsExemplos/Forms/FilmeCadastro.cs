using Newtonsoft.Json;
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

namespace WindowsFormsExemplos.Forms
{
    public partial class FilmeCadastro : Form
    {
        List<Filme> filmes = new List<Filme>();
        int codigo = 1;
        string CaminhoArquivoJsonFilmesDesktop = "";
        public FilmeCadastro()
        {
            CaminhoArquivoJsonFilmesDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + //  entende o sistema operacional
            Path.DirectorySeparatorChar + "filmes.json"; // se adapta à barra utilizada no sistema do usuário
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelListaDeFilmes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // tipos primitivos número inteiro: byte, short, int, long
            // tipos primitivos com decimal: float, double, decimal
            // tipos primitivos com texto: string, char (1 caracter)
            // tipos primitivos V e F: bool
            var nome = textBoxNome.Text.Trim();
            var codigoParaEditar = labelCodigoEditar.Text;
            var minutos = Convert.ToUInt16(numericUpDownMinutos.Value);
            var vitoriaOscar = checkBoxVitoriaOscar.Checked;
            var vitoriaEmmy = checkBoxVitoriaEmmy.Checked;
            var vitoriaGrammy = checkBoxVitoriaGrammy.Checked;
            var flopou = radioButtonFlopouSim.Checked;
            var descricao = richTextBoxDescricao.Text;
            var dataLancamento = dateTimePickerDataLancamento.Value;

            if (dataLancamento >= DateTime.Today)
            {
                MessageBox.Show("Data de lançamento deve ser menor que a data atual");
                return;
            }


            if (comboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma categoria");
                return;
            }

            var categoria = (FilmeCategoria)comboBoxCategoria.SelectedItem;

            var filme = new Filme();
            if (codigoParaEditar != "")
            {
                filme = ObterFilmeParaEditar(codigoParaEditar);
            }
            filme.Nome = nome;
            filme.Minutos = minutos;
            filme.VitoriaEmmy = vitoriaEmmy;
            filme.VitoriaGrammy = vitoriaGrammy;
            filme.VitoriaOscar = vitoriaOscar;
            filme.Flopou = flopou;
            filme.Descricao = descricao;
            filme.DataLancamento = dataLancamento;
            filme.Categoria = categoria;

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(filme);
            }

            AdicionarFilmesDataGridView(filmes);
            SalvarFilmesEmArquivoJson();
            LimparCampos();
        }

        private Filme ObterFilmeParaEditar(string codigoParaEditar)
        {
            // Percorrer a lista de filmes buscando pelo código do filme que será alterado as informações
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                // Verifica se o filme alterado contém o códigoParaEditar
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    return filme;
                }
            }

            // Neste caso não existe um filme com o códigoParaEditar
            return null;
        }
        private void AdicionarNovoFilme(Filme filme)
        {
            filme.Codigo = codigo;
            codigo++;

            filmes.Add(filme);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void richTextBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarFilmesEmArquivoJson()
        {
            // Serializando a lista pode-se transformar a lista de objetos (filmes) em uma string contendo JSON
            var filmesSerializados = JsonConvert.SerializeObject(filmes);
            File.WriteAllText(CaminhoArquivoJsonFilmesDesktop, filmesSerializados);
        }

        private void LerFilmesNoArquivoJson()
        {
            // Verificar se o arquivo filmes.json não existe
            if (File.Exists(CaminhoArquivoJsonFilmesDesktop) == false)
            {
                return;
            }

            var arquivoLinhas = File.ReadAllText(CaminhoArquivoJsonFilmesDesktop);
            var filmesDeserializados = JsonConvert.DeserializeObject<List<Filme>>(arquivoLinhas);

            filmes = filmesDeserializados;

            ObterProximoCodigoDosFilmes();
        }

        private void ObterProximoCodigoDosFilmes()
        {
            var maiorCodigo = 0;

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo > maiorCodigo)
                {
                    maiorCodigo = filme.Codigo;
                }
            }
            maiorCodigo++;
            codigo = maiorCodigo;
        }

        private void AdicionarFilmesDataGridView(List<Filme> filmes)
        {
            dataGridView.Rows.Clear();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                dataGridView.Rows.Add(new object[]
                {
                    filme.Codigo, filme.Nome, filme.Categoria, filme.Minutos
                });
            }

            labelQuantidadeValor.Text = filmes.Count.ToString();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = numericUpDownMinutos.Minimum;

            // ComboBox é uma lista de itens, ou seja, para remover a seleção deve-se atribuir -1 para o índice do item selecionado

            comboBoxCategoria.SelectedIndex = -1;
            dateTimePickerDataLancamento.ResetText();
            checkBoxVitoriaEmmy.Checked = false;
            checkBoxVitoriaGrammy.Checked = false;
            checkBoxVitoriaOscar.Checked = false;
            radioButtonFlopouNao.Checked = true;
            radioButtonFlopouSim.Checked = false;
            labelCodigoEditar.Text = "";
        }

        private void Pesquisar()
        {
            var textoParaPesquisa = textBoxPesquisa.Text.Trim().ToLower();
            var filmesFiltrados = new List<Filme>();

            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];

                if (filme.Nome.ToLower().Contains(textoParaPesquisa))
                {
                    filmesFiltrados.Add(filme);
                }
            }

            AdicionarFilmesDataGridView(filmesFiltrados);
        }

        private void FilmeCadastro_Load(object sender, EventArgs e)
        {
            LerFilmesNoArquivoJson();
            AdicionarFilmesDataGridView(filmes);
            PreencherComboBoxCategoria();
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            // filtra para quando o usuário apertar "enter" no campo de pesquisa, será filtrada a lista de filmes no dataGridView
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme cadastrado");
                return;
            }

            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigo = linhaSelecionada.Cells[0].Value.ToString();
            var filme = ObterFilmeParaEditar(codigo);

            textBoxNome.Text = filme.Nome;
            labelCodigoEditar.Text = codigo;
            dateTimePickerDataLancamento.Value = filme.DataLancamento;
            checkBoxVitoriaEmmy.Checked = filme.VitoriaEmmy;
            checkBoxVitoriaGrammy.Checked = filme.VitoriaGrammy;
            checkBoxVitoriaOscar.Checked = filme.VitoriaOscar;
            richTextBoxDescricao.Text = filme.Descricao;
            numericUpDownMinutos.Value = filme.Minutos;
            if (filme.Flopou == true)
            {
                radioButtonFlopouSim.Checked = true;
            }
            else
            {
                radioButtonFlopouNao.Checked = true;
            }
        }

        private void buttonApagar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum filme cadastrado");
                return;
            }

            // Pegar a linha selecionada
            var linhaSelecionada = dataGridView.SelectedRows[0];
            var codigoParaApagar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            // Percorre a lista de filmes buscando o filme que contém o código escolhido pelo usuário
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                if (filme.Codigo == codigoParaApagar)
                {
                    filmes.Remove(filme);
                    break;
                }
            }
            SalvarFilmesEmArquivoJson();
            AdicionarFilmesDataGridView(filmes);
            MessageBox.Show("Filme apagado com sucesso");
        }

        private void PreencherComboBoxCategoria()
        {
            // Obter lista de categorias ordenadas de A -> Z
            var categorias = Enum.GetValues<FilmeCategoria>().OrderBy(x => x).ToList();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.SelectedIndex = -1;
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
