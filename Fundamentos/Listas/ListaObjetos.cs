using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListaObjetos : Executor
    {
        public override void Executar()
        {
            // Lista da classe "Filme" que guarda objetos chamados "filmes"
            List<Filme> filmes = new List<Filme>();

            Filme dragonBallEvolution = new Filme();
            dragonBallEvolution.Nome = "Dragon Ball Evolution";
            dragonBallEvolution.Duracao = 85;
            dragonBallEvolution.Categoria = filmeCategoriaEnum.LiveAction;
            filmes.Add(dragonBallEvolution);

            Filme beethovenMagnifico = new Filme();
            beethovenMagnifico.Nome = "Beethoven, o Magnífico";
            beethovenMagnifico.Duracao = 87;
            beethovenMagnifico.Categoria = filmeCategoriaEnum.Comedia;
            filmes.Add(beethovenMagnifico);

            Filme noLimiteAmanha = new Filme();
            noLimiteAmanha.Nome = "No limite do amanhã";
            noLimiteAmanha.Duracao = 113;
            noLimiteAmanha.Categoria = filmeCategoriaEnum.LiveAction;
            filmes.Add(noLimiteAmanha);

            Filme guardioesDaGalaxia3 = new Filme();
            guardioesDaGalaxia3.Nome = "Guardiões da galáxia Vol. 3";
            guardioesDaGalaxia3.Duracao = 150;
            guardioesDaGalaxia3.Categoria = filmeCategoriaEnum.Acao;
            filmes.Add(guardioesDaGalaxia3);

            Filme pearlHarbor = new Filme();
            pearlHarbor.Nome = "Pearl Harbor";
            pearlHarbor.Duracao = 170;
            pearlHarbor.Categoria = filmeCategoriaEnum.Acao;
            filmes.Add(pearlHarbor);

            Console.WriteLine("Lista de filmes sem for: ");
            Console.WriteLine(filmes[0].Nome);
            Console.WriteLine(filmes[0].Duracao);
            Console.WriteLine(filmes[0].Categoria);

            Console.WriteLine(filmes[1].Nome);
            Console.WriteLine(filmes[1].Duracao);
            Console.WriteLine(filmes[1].Categoria);

            Console.WriteLine(filmes[2].Nome);
            Console.WriteLine(filmes[2].Duracao);
            Console.WriteLine(filmes[2].Categoria);

            Console.WriteLine(filmes[3].Nome);
            Console.WriteLine(filmes[3].Duracao);
            Console.WriteLine(filmes[3].Categoria);

            Console.WriteLine("\nFilmes com for:");
            for (int i = 0; i < filmes.Count; i++)
            {
                Console.WriteLine(filmes[i].Nome);
                Console.WriteLine(filmes[i].Duracao);
                Console.WriteLine(filmes[i].Categoria);
            }
        }

        enum filmeCategoriaEnum // "enum" facilita no controle para ver o que o usuário pode utilizar
        {
            LiveAction,
            Comedia,
            Acao
        }
        class Filme
        {
            public string Nome;
            public ushort Duracao; // ushort = 0 até 65535
            public filmeCategoriaEnum Categoria;
        }
    }
}