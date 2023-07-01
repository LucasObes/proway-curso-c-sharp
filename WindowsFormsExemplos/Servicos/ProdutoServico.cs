using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Modelos;
using WindowsFormsExemplos.Repositorios;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico
    {
        private ProdutoRepositorio produtoRepositorio;

        // Método construtor
        public ProdutoServico()
        {
            // Instanciando o objeto de ProdutoRepositorio
            produtoRepositorio = new ProdutoRepositorio();
        }

        // CRUD
        public void Cadastrar(Produto produto)
        {

            produtoRepositorio.Cadastrar(produto);
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

        internal void Editar(Produto produto)
        {
            produtoRepositorio.Editar(produto);
        }
    }
}
