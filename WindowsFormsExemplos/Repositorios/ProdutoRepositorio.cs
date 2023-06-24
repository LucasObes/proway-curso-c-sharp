using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BancoDados;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio
    {
        private BancoDadosConexao bancoDadosConexao;

        // Método construtor: executado quando ocorre um new da classe, ou seja um "new ProdutoRepositorio()", irá executar o construtor
        public ProdutoRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }
        
        // CRUD
        public void Cadastrar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "INSERT INTO produtos (nome, preco_unitario, quantidade) VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"UPDATE produtos SET 
                nome = @NOME,
                preco_unitario = @PRECO_UNITARIO,
                quantidade = @QUANTIDADE
            WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            comando.Parameters.AddWithValue("@ID", produto.Id);

            comando.ExecuteNonQuery();
        }

        public void Apagar(int id)
        {
            // Abrir conexao
            var comando = bancoDadosConexao.Conectar();

            // Definir o comando
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Executar o comando de apagar o registro
            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodosProdutos(string pesquisa)
        {
            var produtos = new List<Produto>();

            // Abrir a conexao
            var comando = bancoDadosConexao.Conectar();

            // Executar o comando SELECT
            comando.CommandText = "SELECT * FROM produtos WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", $"%{pesquisa}%");

            // Criar tabela em memória para carregar os registros da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criar a lista de produtos com os produtos do banco de dados
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter o resgistro (consultando a tabela de produtos)
                var registro = tabelaEmMemoria.Rows[i];

                var produto = ConstruirProdutoDoRegistro(registro);

                // Adicionar o produto na lista de produtos
                produtos.Add(produto);
            }

            // Retornar a lista de produtos com os registros da tabela de produtos (banco de dados)
            return produtos;
        }

        public Produto ObterPorId(int id)
        {
            // Abrir conexao com o Banco de dados
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "SELECT * FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            // Criar tabela em memória para carregar o registro
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Pegar o primeiro registro da consulta
            var linha = tabelaEmMemoria.Rows[0];

            var produto = ConstruirProdutoDoRegistro(linha);

            // Retornar o objeto do produto preenchido com os dados do registro consultado
            return produto;
        }

        private Produto ConstruirProdutoDoRegistro(DataRow linha)
        {
            // Instanciar o objeto de Produto e preencher as propriedades do produto com os dados do primeiro registro
            var produto = new Produto();

            produto.Id = Convert.ToInt32(linha["id"]);
            produto.Nome = linha["nome"].ToString();
            produto.Quantidade = Convert.ToInt32(linha["quantidade"]);
            produto.PrecoUnitario = Convert.ToDecimal(linha["preco_unitario"]);

            return produto;
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
