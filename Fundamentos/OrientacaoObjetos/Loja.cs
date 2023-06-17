using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class Loja : Executor
    {
        public override void Executar()
        {
            //Instanciando um objeto chamado computadorJose da classe Computador
            Computador computadorJose = new Computador();
            computadorJose.Processador = "i5 11500H";
            computadorJose.PlacaVideo = "GTX 1650 4GB";
            computadorJose.Preco = 4000.00;

            Computador computadorFrancisco = new Computador();
            computadorFrancisco.Processador = "i7 8700";
            computadorFrancisco.PlacaVideo = "GTX 1060 6GB";
            computadorFrancisco.Preco = 3500.00;

            Computador computadorCristina = new Computador();
            computadorCristina.Processador = "i5 12400K";
            computadorCristina.PlacaVideo = "RTX 4090";
            computadorCristina.Preco = 18000.00;

            double total = computadorJose.Preco + computadorFrancisco.Preco + computadorCristina.Preco;

            Console.WriteLine(
                "Computador do José: " +
                "\nProcessador: " + computadorJose.Processador +
                "\nPlaca de vídeo: " + computadorJose.PlacaVideo +
                "\nPreço: " + computadorJose.Preco +
                "\n\nComputador do Francisco: " +
                "\nProcessador: " + computadorFrancisco.Processador +
                "\nPlaca de vídeo: " + computadorFrancisco.PlacaVideo +
                "\nPreço: " + computadorFrancisco.Preco +
                "\n\nComputador da Cristina: " +
                "\nProcessador: " + computadorCristina.Processador +
                "\nPlaca de vídeo: " + computadorCristina.PlacaVideo +
                "\nPreço: " + computadorCristina.Preco +
                "\n\nValor total: " + total);
        }
    }
}
