using ExemploRecords;

Console.WriteLine("***** Testes com Records + C# 10 + .NET 6 *****");
Console.WriteLine();

Console.WriteLine("Criando um Record...");
var ipi10 = new Imposto(
    "IPI", "Imposto sobre Produtos Industrializados", 10);
Console.WriteLine(ipi10);

Console.WriteLine("Criando um Record com With-expression...");
Imposto ipi07 = ipi10 with { VlPercAliquota = 7 };
Console.WriteLine(ipi07);

Console.WriteLine("Criando um Record com construtor sem parametros...");
var irpf15 = new Imposto()
{
    Sigla = "IRPF",
    Nome = "Imposto de Renda sobre Pessoa Fisica",
    VlPercAliquota = 15
};
Console.WriteLine(irpf15);

Console.WriteLine("Testando a heranca em Records - parte 1...");
ImpostoEstadual icms12 = new()
{
    Sigla = "ICMS",
    Nome = "Imposto sobre Circulacao de Mercadorias e Servicos",
    VlPercAliquota = 12,
    CodEstado = "SP"
};
Console.WriteLine(icms12);

Console.WriteLine("Testando a heranca em Records - parte 2...");
ImpostoEstadual icms08 =
    icms12 with { CodEstado = "MG", VlPercAliquota = 8 };
Console.WriteLine(icms08);

Console.WriteLine("Testando a heranca em Records - parte 3...");
ImpostoMunicipal iss05 =
    new("ISS", "Imposto sobre Servico", 5, "Sao Paulo");
Console.WriteLine(iss05);