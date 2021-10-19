using ExemploRecordStructs;

Console.WriteLine("***** Testes com Record Structs + C# 10 + .NET 6 *****");
Console.WriteLine();

var brasil2000 = new Demografia();

var brasil1970 = brasil2000 with { Ano = 1970, Populacao = 90_000_000 };

var brasil2021 = brasil1970;
brasil2021.Ano = 2021;
brasil2021.Populacao = 212_600_000;

Console.WriteLine(brasil1970);
Console.WriteLine(brasil2000);
Console.WriteLine(brasil2021);