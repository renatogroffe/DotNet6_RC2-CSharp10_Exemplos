using System.Text.Json;

namespace ExemploRecords;

public record Imposto
{
    public string? Sigla { get; init; }
    public string? Nome { get; init; }
    public double VlPercAliquota { get; init; }

    public Imposto() { }
    public Imposto(string sigla, string nome, double vlPercAliquota) =>
        (Sigla, Nome, VlPercAliquota) = (sigla, nome, vlPercAliquota);
    
    public sealed override string ToString() =>
        $"{Environment.NewLine}{JsonSerializer.Serialize(this)}{Environment.NewLine}";
}

public record ImpostoEstadual : Imposto
{
    public string? CodEstado { get; init; }
}

public record ImpostoMunicipal : Imposto
{
    public string NomeCidade { get; init; }

    public ImpostoMunicipal(string sigla, string nome, double vlPercAliquota, string nomeCidade) :
        base(sigla, nome, vlPercAliquota) => (NomeCidade) = (nomeCidade);
}