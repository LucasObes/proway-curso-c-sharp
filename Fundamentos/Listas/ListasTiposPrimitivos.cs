using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Listas
{
    internal class ListasTiposPrimitivos
    {
        public void Executar()
        {
            // Tipos primitivos: guardam somente uma informação
            //   string, int, short, long, byte, float, double, decimal, bool, char, object...
            //   bit.ly/41U8o76

            // Criando uma lista(vetor) de string
            List<string> nomes = new List<string>();
            nomes.Add("Fabiana");
            nomes.Add("Joana");
            nomes.Add("Uélington");
            nomes.Add("Manuell");
            nomes.Add("Robinson");

            Console.WriteLine("Nomes: ");
            Console.WriteLine("Index 0: " + nomes[0]);       
            Console.WriteLine($"Index 1: {nomes[1]}");       
            Console.WriteLine($"Index 2: {nomes[2]}");       
            Console.WriteLine($"Index 3: {nomes[3]}");       
            Console.WriteLine($"Index 4: {nomes[4]}");

            nomes.Remove("Joana"); // remove o item que voce informar
            nomes.RemoveAt(2); // remove na posição que você selecionar

            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(7);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(8);
            numeros.Add(10);

            int soma = numeros[0] + numeros[1] + numeros[2];

            // "Count" é como se fosse o "Length" nas listas. OBS: "Length" é utilizado em VETORES; Já "Count" é utilizado em LISTS
            int somaComFor = 0;
            for (int i = 0; i < numeros.Count; i+= 1)
                somaComFor = somaComFor + numeros[i];

            for (int i = 0; i < numeros.Count; i += 1)
                Console.WriteLine($"Posição {i}: {numeros[i]}");
            
            Console.WriteLine("Soma: " +somaComFor);

            bool existeNumero11NaLista = numeros.Contains(11);
            Console.WriteLine($"Existe o número 11 na lista? {existeNumero11NaLista}");
            
            int indiceNumero8NaLista = numeros.IndexOf(8);
            Console.WriteLine($"O índice do número oito é: {indiceNumero8NaLista}");

            // Retorna -1 porque não existe o número 11 na lista
            int indiceNumero11NaLista = numeros.IndexOf(11);
            Console.WriteLine($"O índice do número onze é: {indiceNumero11NaLista}");
        }    
    }
}
