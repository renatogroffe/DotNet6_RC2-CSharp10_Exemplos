namespace ExemploRecordStructs;

// Novidade C# 10: Record Structs
public record struct Demografia
{
    public string Pais { get; init; }
    public int Ano { get; set; }
    public int Populacao { get; set; }

    public Demografia()
    {
        Pais = "Brasil";
        Ano = 2000;
        Populacao = 174_800_000;
    }
    
    public Demografia(string pais, int ano, int populacao) =>
        (Pais, Ano, Populacao) = (pais, ano, populacao);
}