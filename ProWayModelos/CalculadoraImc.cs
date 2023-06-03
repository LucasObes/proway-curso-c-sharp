using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWayModelos
{
    public class CalculadoraImc
    {
        public string nome;
        public double altura;
        public double peso;

        public string IndiceImcAbaixoPeso = "Você se encontra abaixo do peso";
        public string IndiceImcPesoIdeal = "Você está com o peso ideal, parabéns";
        public string IndiceImcLeveAcima = "Você está levemente acima do peso, cuidado";
        public string IndiceImcObeso1 = "Você está com Obesidade de grau I, cuidado!";
        public string IndiceImcObeso2 = "Você está com Obesidade de grau II, comece a se cuidar!";
        public string IndiceImcObeso3 = "Você está com Obesidade de grau III, comece a se cuidar imediatamente!";
        public double CalcularImc()
        {
            var imc = peso / Math.Pow(altura, 2);
            
            return imc;
        }

        public string IndiceImc(double imc)
        {
            if (imc < 18.5)
            {
                return IndiceImcAbaixoPeso;
            }
            if (imc >= 18.6 || imc <= 24.9)
            {
                return IndiceImcPesoIdeal;   
            }
            if (imc >= 25 || imc <= 29.9)
            {
                return IndiceImcLeveAcima;
            }
            if (imc >= 30 || imc <= 34.9)
            {
                return IndiceImcObeso1;
            }
            if (imc >= 35 || imc <= 39.9)
            {
                return IndiceImcObeso2;
            }

            return IndiceImcObeso3;
        }

    }
}
