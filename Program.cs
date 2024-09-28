using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Globalization;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes ( melhorado)
List<Pessoa> hospedes = new()
{
    new Pessoa(nome: "Hóspede 1"),
    new Pessoa(nome: "Hóspede 2")
};

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 5);

// Tratando possíveis erros.
try{
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total: {reserva.CalcularValorDiaria().ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
}
catch(Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}