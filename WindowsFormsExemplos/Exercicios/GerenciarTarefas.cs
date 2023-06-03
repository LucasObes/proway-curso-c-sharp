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
    public partial class GerenciarTarefas : Form
    {
        List<Tarefas> tarefas = new List<Tarefas>();
        int codigo = 1;
        public GerenciarTarefas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void GerenciarTarefas_Load(object sender, EventArgs e)
        {
            PreencherComboBoxNivel();
            AdicionarTarefasDataGridView(tarefas);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var tarefa = textBoxTarefa.Text;
            var nivel = (TarefaNivel)comboBoxNivel.SelectedItem;
            var descricao = richTextBoxDescricao.Text;
            var data = dateTimePickerData.Value;

            if (comboBoxNivel.SelectedIndex == -1)
            {
                MessageBox.Show("Você deve definir o nivel de urgência da tarefa");
                return;
            }

            var tarefas1 = new Tarefas();

            tarefas1.nomeResponsavel = nome;
            tarefas1.tarefa = tarefa;
            tarefas1.nivel = nivel;
            tarefas1.descricao = descricao;
            tarefas1.data = data;

            AdicionarTarefasDataGridView(tarefas);
            AdicionarNovaTarefa(tarefas1);

        }

        private void AdicionarNovaTarefa(Tarefas tarefa)
        {
            tarefa.codigo = codigo;
            codigo++;

            tarefas.Add(tarefa);
        }
        private void AdicionarTarefasDataGridView(List<Tarefas> tarefas)
        {
            dataGridViewLista.Rows.Clear();

            for (var i = 0; i < tarefas.Count; i++)
            {
                var tarefa = tarefas[i];

                dataGridViewLista.Rows.Add(new object[]
                {
                    tarefa.nomeResponsavel, tarefa.tarefa, tarefa.nivel, tarefa.data
                });
            }

            labelQuantidadeValor.Text = tarefas.Count.ToString();
        }

        private void PreencherComboBoxNivel()
        {
            var niveis = Enum.GetValues<TarefaNivel>().OrderBy(x => x).ToList();
            comboBoxNivel.DataSource = niveis;
            comboBoxNivel.SelectedIndex = -1;
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxTarefa.Clear();
            comboBoxNivel.SelectedIndex = -1;
            richTextBoxDescricao.Clear();
            dateTimePickerData.ResetText();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Pesquisa()
        {
            var textoPesquisa = textBoxFiltro.Text.Trim().ToLower();
            var tarefasFiltradas = new List<Tarefas>();

            for (var i = 0; i < tarefas.Count; i++)
            {
                var tarefa = tarefas[i];

                if (tarefa.nomeResponsavel.ToLower().Contains(textoPesquisa))
                {
                    tarefasFiltradas.Add(tarefa);
                }
            }

            AdicionarTarefasDataGridView(tarefasFiltradas);
        }

        private void textBoxFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisa();
            }
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
