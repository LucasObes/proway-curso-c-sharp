namespace Fundamentos.Heranca
{
    // ContaCorrente herda as propriedades e métodos da classe Conta
    public class ContaCorrente : Conta
    {
        public decimal SaldoChequeEspecial { get; set; }

        // Override: uma sobreescrita do método ObterExtrati, ou seja, mudamos o comportamento do método da classe pai
        public override string ObterExtrato()
        {
            // Obtém o extrato da classe pai Conta
            // base é utilizado para chamar métodos de classes pai, avô
            var extratoPai = base.ObterExtrato();
            var extratoFilho = $"Saldo cheque especial: {SaldoChequeEspecial}";

            // Retorna o extrado classe pai Conta + extrato da ContaCorrente
            return $"{extratoPai}\n{extratoFilho}";
        }
    }
}