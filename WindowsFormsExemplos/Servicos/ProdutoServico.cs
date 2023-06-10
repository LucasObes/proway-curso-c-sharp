using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico
    {
        // CRUD
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Cadastrar(nome, precoUnitario, quantidade);
        }

        public List<Produto> ObterTodos()
        {
            // Obter a lista de produtos da tabela de produtos
            var produtoRepositorio = new ProdutoRepositorio();
            var produtos = produtoRepositorio.ObterTodosProdutos();

            // Retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            // Instanciando um objeto da classe ProdutoRepositorio
            var produtoRepositorio = new ProdutoRepositorio();
            // Chamar o método Apagar do ProdutoRepositorio (executa o DELETE)
            produtoRepositorio.Apagar(id);
        }
    }
}
