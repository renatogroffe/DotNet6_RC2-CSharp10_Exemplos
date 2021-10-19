namespace ExemploStructs;

public struct Demografia
{
    public string Pais { get; init; }
    public int Ano { get; set; }
    public int Populacao { get; set; }

    // Novidade C# 10: structs com construtor sem parâmetros
    public Demografia()
    {
        Pais = "Brasil";
        Ano = 2000;
        Populacao = 174_800_000;
    }
    
    public Demografia(string pais, int ano, int populacao) =>
        (Pais, Ano, Populacao) = (pais, ano, populacao);
}