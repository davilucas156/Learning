using System;

public static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public static double FahrenheitParaCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Fahrenheit: " + ConversorTemperatura.CelsiusParaFahrenheit(c));

        Console.Write("Digite a temperatura em Fahrenheit: ");
        double f = double.Parse(Console.ReadLine());
        Console.WriteLine("Celsius: " + ConversorTemperatura.FahrenheitParaCelsius(f));
    }
}