using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradores
    {
        public void CalcularFolhasPagamento()
        {
            // Objeto jose é uma instancia da classe FolhaPagamento
            FolhaPagamento jose = new FolhaPagamento();
            jose.NomeColaborador = "José";
            jose.ValorHora = 60;
            jose.QuantidadeHoras = 160;
            double salarioJose = jose.CalcularSalarioBruto();
            double inssJose = jose.CalcularInss();

            FolhaPagamento matheus = new FolhaPagamento();
            matheus.NomeColaborador = "Matheus";
            matheus.ValorHora = 50;
            matheus.QuantidadeHoras = 220;
            double salarioMatheus = matheus.CalcularSalarioBruto();
            double inssMatheus = matheus.CalcularInss();

            FolhaPagamento francisco = new FolhaPagamento();
            francisco.NomeColaborador = "Francisco";
            francisco.ValorHora = 15.00;
            francisco.QuantidadeHoras = 220;
            double salarioFrancisco = francisco.CalcularSalarioBruto();
            double inssFrancisco = francisco.CalcularInss();

            Console.WriteLine($@"Folha pagamento: {francisco.NomeColaborador} 
            Salário Líquido: {salarioFrancisco}
            INSS: {inssFrancisco}

            Folha pagamento: {matheus.NomeColaborador}
            Salário Líqudio: {salarioMatheus}
            INSS: {inssMatheus}

            Folha pagamento: {jose.NomeColaborador}
            Salário Líqudio: {salarioJose}
            INSS: {inssJose}");
        }
    }
}
