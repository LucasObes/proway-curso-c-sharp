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
        private ProdutoRepositorio produtoRepositorio;
        // CRUD
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            produtoRepositorio.Cadastrar(nome, precoUnitario, quantidade);
        }

        public List<Produto> ObterTodos(string pesquisa)
        {
            // Obter a lista de produtos da tabela de produtos
            var produtos = produtoRepositorio.ObterTodosProdutos(pesquisa);

            // Retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            // Chamar o método Apagar do ProdutoRepositorio (executa o DELETE)
            produtoRepositorio.Apagar(id);
        }

        public Produto ObterPorId(int id)
        {
            var produto = produtoRepositorio.ObterPorId(id);
            return produto;
        }

        internal void Editar(int idProdutoEditar, string nome, decimal precoUnitario, int quantidade)
        {
            produtoRepositorio.Editar(idProdutoEditar, nome, precoUnitario, quantidade);
        }
    }
}
