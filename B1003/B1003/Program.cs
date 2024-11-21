internal class Program
{
    private static void Main(string[] args)
    {
        int valor1, valor2, soma;

        Console.WriteLine("Digite o valor 1");
        valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor 2");
        valor2 = int.Parse(Console.ReadLine());

        soma = valor1 + valor2;

        Console.WriteLine("SOMA = " + soma);
    }
}