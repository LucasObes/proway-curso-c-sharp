namespace WindowsFormsExemplos.Modelos
{
    internal class Cliente : ModeloBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
