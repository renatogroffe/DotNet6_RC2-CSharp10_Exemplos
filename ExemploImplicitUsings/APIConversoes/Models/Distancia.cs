namespace APIConversoes.Models;

public class Distancia
{
    public double Milhas { get; }
    public double Km { get; }

    public Distancia(double milhas)
    {
        if (milhas <= 0)
        {
            throw new ArgumentException(
                "A distancia em Milhas deve ser maior do que zero!");
        }

        Milhas = milhas;
        Km = Math.Round(milhas * 1.609, 3);
    }
}