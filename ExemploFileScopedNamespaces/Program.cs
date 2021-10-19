using System.Runtime.InteropServices;
using ExemploFileScopedNamespaces;

Console.WriteLine(
    $"Versão utilizada: {RuntimeInformation.FrameworkDescription}");
Console.WriteLine();

var medicoesFahrenheit = new double[]  { 32, 88, 212 };
foreach (double medicaoFahrenheit in medicoesFahrenheit)
    Console.WriteLine($"{medicaoFahrenheit} graus Fahrenheit = " +
        $"{ConversorTemperatura.FahrenheitParaCelsius(medicaoFahrenheit)} graus Celsius");

Console.WriteLine();
Console.WriteLine("Testes concluídos!");