using System.Runtime.InteropServices;
using ExemploConstantInterpolatedStrings;

Console.WriteLine("***** Exemplo com Constant Interpolated Strings *****");
Console.WriteLine();

Console.WriteLine(
    $"Versão utilizada: {RuntimeInformation.FrameworkDescription}");
Console.WriteLine();

Console.WriteLine($"{nameof(InfoAplicacao.Proposito)} = {InfoAplicacao.Proposito}");
Console.WriteLine($"{nameof(InfoAplicacao.Versao)} = {InfoAplicacao.Versao}");
Console.WriteLine($"{nameof(InfoAplicacao.Autor)} = {InfoAplicacao.Autor}");
Console.WriteLine($"{nameof(InfoAplicacao.Descritivo)} = {InfoAplicacao.Descritivo}");

Console.WriteLine();
Console.WriteLine("Testes concluídos!");