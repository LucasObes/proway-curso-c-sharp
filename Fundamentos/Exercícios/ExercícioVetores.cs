using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Fundamentos.Exercícios
{
    internal class ExercícioVetores
    {
        public void Executar()
        {
            ExercicioVetor();
        }

        private void ExercicioVetor()
        {
            string[] nomes = new string[5];
            double[] alturas = new double[5];
            double[] pesos = new double[5];
            double[] imcs = new double[5];

            SolicitarDadosUsuario(nomes, alturas, pesos);
            CalcularImc(alturas, pesos, imcs);
            ApresentarDados(nomes, alturas, pesos, imcs);
        }
        
        private void SolicitarDadosUsuario(string[] nomes, double[] alturas, double[] pesos)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = SolicitarNomes();
                alturas[i] = SolicitarAlturas();
                pesos[i] = SolicitarPesos();
            }
        }
        
        private string SolicitarNomes()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine().Trim();

            while(nome.Length < 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O nome deve contér no MÍNIMO 5 caracteres");
                Console.ResetColor();

                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }

            return nome;
        }

        private double SolicitarAlturas()
        {
            double altura = 0;
            bool alturaValida = false;
            while (alturaValida == false)
            {
                try
                {
                    Console.Write("Altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    if (altura < 0.20 || altura > 3.00)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("A altura deve ser entre 0,20 e 3,00");
                        Console.ResetColor();
                    }
                    else
                    {
                    alturaValida = true;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("O valor inserido não pode ser caracterizado como altura");
                    Console.ResetColor();
                }
            }

            return altura;
        }

        private double SolicitarPesos()
        {
            double peso = 0;
            bool pesoValido = false;
            while(pesoValido == false)
            {
                try
                {
                    Console.Write("Peso: ");
                    peso = Convert.ToDouble(Console.ReadLine());
                    if (peso < 3 || peso > 400)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("O peso deve ser entre 3.00 e 400.00");
                        Console.ResetColor();
                    }
                    else
                    {
                        pesoValido = true;
                    }
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("O peso digitado não é válido");
                    Console.ResetColor();
                }
            }

            return peso;
        }

        private void CalcularImc(double[] alturas, double[] pesos, double[] imcs)
        {
            for (int i = 0; i  < alturas.Length; i++)
            {
                imcs[i] = pesos[i] / Math.Pow(alturas[i], 2);
            }
        }

        private void ApresentarDados(string[] nomes,double[] alturas, double[] pesos, double[] imcs)
        {
            var table = new ConsoleTable("Nome", "Altura", "Peso", "IMC");
            for (int i = 0; i < alturas.Length; i++)
            {
                table.AddRow(nomes[i], alturas[i], pesos[i], imcs[i]);
            }
            Console.Clear();
            table.Write();
            Console.WriteLine();
        }
    }
}