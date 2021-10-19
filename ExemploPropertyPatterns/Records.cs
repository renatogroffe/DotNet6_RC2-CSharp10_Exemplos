namespace ExemploPropertyPatterns;

public record Cidade(string Nome, PaisRegiao Pais);
public record PaisRegiao(string Nome, bool Capital, int Populacao);