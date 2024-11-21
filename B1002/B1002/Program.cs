using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double area;
        double pi = 3.14159;

        Console.WriteLine("Digite o valor do raio");
        double raio = double.Parse(Console.ReadLine());

        area = pi * Math.Pow(raio, 2);

        Console.WriteLine("A=" + area.ToString("F4"));
    }
}