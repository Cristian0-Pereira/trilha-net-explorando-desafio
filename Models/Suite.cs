namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (string.IsNullOrWhiteSpace(tipoSuite))
                throw new ArgumentException("O tipo da suíte não pode ser vazio.", nameof(tipoSuite));
            if (capacidade <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacidade), "A capacidade da suíte precisa ser maior que zero.");
            if (valorDiaria <= 0)
                throw new ArgumentOutOfRangeException(nameof(valorDiaria), "O valor da diária precisa ser maior que zero.");

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}