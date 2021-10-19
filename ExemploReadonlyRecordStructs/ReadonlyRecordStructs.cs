namespace ExemploReadonlyRecordStructs;

// Novidade C# 10: Readonly Record Structs
public readonly record struct Demografia
{
    public string Pais { get; init; }
    public int Ano { get; init; }
    public int Populacao { get; init; }

    public Demografia()
    {
        Pais = "Brasil";
        Ano = 2000;
        Populacao = 174_800_000;
    }
    
    public Demografia(string pais, int ano, int populacao) =>
        (Pais, Ano, Populacao) = (pais, ano, populacao);
}