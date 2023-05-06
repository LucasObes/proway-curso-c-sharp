using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class FolhaPagamento
    {
        //Propriedades (características)
        public string NomeColaborador;
        public double ValorHora;
        public int QuantidadeHoras;

        private const double AliquotaInss14Porcento = 0.14;
        private const double AliquotaInss12Porcento = 0.12;
        private const double AliquotaInss9Porcento = 0.09;
        private const double AliquotaInss7MeioPorcento = 0.075;


        // Método (ações) com retorno e sem parâmetros
        public double CalcularSalarioBruto()
        {
            double salarioBruto = ValorHora * QuantidadeHoras;

            return salarioBruto;
        }

        public double CalcularInss()
        {
            double salarioBruto = CalcularSalarioBruto();
            double aliquota = ObterAliquota(salarioBruto);

            return salarioBruto * aliquota;
        }

        private double ObterAliquota(double salarioBruto)
        {
            if (salarioBruto <= 1320.00)
            {
                return AliquotaInss7MeioPorcento;
            }
            if (salarioBruto <= 2571.29)
            {
                return AliquotaInss9Porcento;
            }
            if (salarioBruto <= 3856.94)
            {
                return AliquotaInss12Porcento;
            }

            return AliquotaInss14Porcento;
        }
    }
}
