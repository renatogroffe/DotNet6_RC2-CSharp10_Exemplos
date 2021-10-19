namespace ExemploFileScopedNamespaces;

public static class ConversorTemperatura
{
    public static double FahrenheitParaCelsius(double temperatura)
    {
        if (temperatura < -459.67)
        {
            throw new ArgumentException(
                $"Valor de temperatura em Fahrenheit inválido: {temperatura}");
        }
            
        return Math.Round((temperatura - 32) / 1.8, 2);
    }
}