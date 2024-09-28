namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = !string.IsNullOrWhiteSpace(nome) ? nome: throw new ArgumentException("Nome não pode ser vazio.");
    }

    public Pessoa(string nome, string sobrenome)
    {
        // Não aceitando valores nulos.
        Nome = !string.IsNullOrWhiteSpace(nome) ? nome: throw new ArgumentException("Nome não pode ser vazio.");
        Sobrenome = !string.IsNullOrWhiteSpace(sobrenome) ? sobrenome : string.Empty; // Opcional
    }

    public string Nome { get;}
    public string Sobrenome { get;}
    
    // Fazendo uma verificação no NomeCompleto.
    public string NomeCompleto => string.IsNullOrWhiteSpace(Sobrenome) ? Nome.ToUpper() : $"{Nome} {Sobrenome}".ToUpper();
}