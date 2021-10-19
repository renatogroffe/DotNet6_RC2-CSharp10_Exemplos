using ExemploPropertyPatterns;

Console.WriteLine("..... Extended Property Patterns + C# 10 + .NET 6 .....");

List<Cidade> cidades = new()
{
    new("Brasilia", new("Brasil", true, 212_600_000)),
    new("Barcelona", new("Espanha", false, 47_350_000)),
    new("Nova York", new("Estados Unidos", false, 329_500_000)),
    new("Toquio", new("Japao", true, 125_800_000))
};

Console.WriteLine("***** Utilizando Property Patterns *****");

foreach (var cidade in cidades)
{
    //if (cidade is { Pais: { Capital: true, Populacao: > 99_999_999 }}) // C# 9
    if (cidade is { Pais.Capital: true, Pais.Populacao: > 99_999_999 }) // C# 10
        Console.WriteLine($"{cidade.Nome}: uma capital em um dos maiores paises do mundo!");
    else
        Console.WriteLine($"{cidade.Nome}: uma importante metropole!");
}