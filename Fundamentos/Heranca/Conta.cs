using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Heranca
{
    public class Conta         
    {                          
        // Propriedades        
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataAbertura { get; set; }
                               
        public void Depositar(decimal valor)
        {                      
            // Adicionar no saldo o valor do depósito
            Saldo += valor;    
        }

        // Virtual: permite que classes filhas modifiquem o comportamento do método de uma classe pai
        public virtual string ObterExtrato()
        {
            var extrato = $"Nome: {Cliente}\nSaldo: {Saldo}";
            return extrato;
        }
    }
}                       
                               