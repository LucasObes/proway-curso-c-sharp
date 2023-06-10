﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.BancoDados;

namespace WindowsFormsExemplos.Forms
{
    public partial class ProdutoCadastroSimplificadoBancoDadosForm : Form
    {
        private int idParaEditar = -1;

        public ProdutoCadastroSimplificadoBancoDadosForm()
        {
            InitializeComponent();
        }

        private void ProdutoCadastroSimplificadoBancoDadosForm_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var quantidade = Convert.ToInt32(textBoxQuantidade.Text.Trim());
            var precoUnitario = Convert.ToDouble(textBoxPrecoUnitario.Text.Trim());

            if (idParaEditar == -1)
            {
                Cadastrar(nome, quantidade, precoUnitario);
            }
            else
            {
                Editar(nome, quantidade, precoUnitario);
            }

            LimparCampos();
            ListarProdutos();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxPrecoUnitario.Clear();
            textBoxQuantidade.Clear();
            idParaEditar = -1;
        }

        private void Editar(string nome, int quantidade, double precoUnitario)
        {
            var comando = Conectar();
            comando.CommandText = @"UPDATE produtos SET 
                        nome = @NOME, 
                        quantidade = @QUANTIDADE, 
                        preco_unitario = @PRECO_UNITARIO 
                        WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);
            comando.Parameters.AddWithValue("@ID", idParaEditar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Produto alterado com sucesso");
        }

        private void Cadastrar(string nome, int quantidade, double precoUnitario)
        {
            var comando = Conectar();
            comando.CommandText = "INSERT INTO produtos (nome, preco_unitario, quantidade) VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
            MessageBox.Show("Produto cadastrado com sucesso");
        }

        private void ListarProdutos()
        {
            var comando = Conectar();
            comando.CommandText = "SELECT * FROM produtos";

            // Tabela em memória para ler os dados da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Fechar conexão com banco de dados
            comando.Connection.Close();

            // Remover linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Percorrer a tabela em memória
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                dataGridView1.Rows.Add(new object[]
                {
                    linha ["id"],
                    linha ["nome"],
                    linha ["quantidade"],
                    linha ["preco_unitario"]
                });
            }
        }

        private SqlCommand Conectar()
        {
            var bancoDadosConexao = new BancoDadosConexao();
            return bancoDadosConexao.Conectar();
        }

        private void button1Apagar_Click(object sender, EventArgs e)
        {
            var comando = Conectar();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = linhaSelecionada.Cells[0].Value;
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();

            MessageBox.Show("Prouto apagado com sucesso");
            ListarProdutos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var conexao = Conectar();
            conexao.CommandText = "SELECT * FROM produtos WHERE id = @ID";

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            conexao.Parameters.AddWithValue("@ID", id);

            // Criar tabela em memória para resgatar os registros
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(conexao.ExecuteReader());

            // Obter dados do registro obtido no select realizado
            var registro = tabelaEmMemoria.Rows[0];
            var nome = registro["nome"].ToString();
            var precoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
            var quantidade = Convert.ToInt32(registro["quantidade"]);

            // Preencher campos para permitir editar o registro
            textBoxNome.Text = nome;
            textBoxQuantidade.Text = quantidade.ToString();
            textBoxPrecoUnitario.Text = precoUnitario.ToString();
            idParaEditar = id;

            // Foco no campo do nome, para  usuário poder alterar o nome caso desejar
            textBoxNome.Focus();
        }
    }
}
