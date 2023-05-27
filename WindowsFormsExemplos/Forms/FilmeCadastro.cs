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
        public FilmeCadastro()
        {
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

            if (codigoParaEditar == "")
            {
                AdicionarNovoFilme(nome);
            }
            else
            {
                EditarFilme(nome, codigoParaEditar);
            }

            AdicionarFilmesDataGridView(filmes);
            SalvarFilmesEmArquivoJson();
            LimparCampos();
        }

        private void EditarFilme(string nome, string codigoParaEditar)
        {
            // Percorrer a lista de filmes buscando pelo código do filme que será alterado as informações
            for (var i = 0; i < filmes.Count; i++)
            {
                var filme = filmes[i];
                // Verifica se o filme alterado contém o códigoParaEditar
                if (filme.Codigo.ToString() == codigoParaEditar)
                {
                    filme.Nome = nome;
                }
            }
        }
        private void AdicionarNovoFilme(string nome)
        {
            var filme = new Filme();
            filme.Nome = nome;
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
            File.WriteAllText("C:\\Users\\73368\\Downloads\\filmes.json", filmesSerializados);
        }

        private void LerFilmesNoArquivoJson()
        {
            // Verificar se o arquivo filmes.json não existe
            if (File.Exists("C:\\Users\\73368\\Downloads\\filmes.json") == false)
            {
                return;
            }

            var arquivoLinhas = File.ReadAllText("C:\\Users\\73368\\Downloads\\filmes.json");
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
                    filme.Codigo, filme.Nome
                });
            }

            labelQuantidadeValor.Text = filmes.Count.ToString();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            richTextBoxDescricao.Clear();
            numericUpDownMinutos.Value = 0;

            // ComboBox é uma lista de itens, ou seja, para remover a seleção deve-se atribuir -1 para o índice do item selecionado

            comboBoxCategoria.SelectedIndex = -1;
            dateTimePickerDataLancamento.ResetText();
            checkBoxVitoriaEmmy.Checked = false;
            checkBoxVitoriaGrammy.Checked = false;
            checkBoxVitoriaOscar.Checked = false;
            radioButtonFlopouNao.Checked = false;
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
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();

            textBoxNome.Text = nome;
            labelCodigoEditar.Text = codigo.ToString();
            // TODO: salvar o código para que depois seja possível editar na lista
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
    }
}
