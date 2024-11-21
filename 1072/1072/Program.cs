internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int inCount = int.Parse(Console.ReadLine());
        int outCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                inCount++;
            }
            else
            {
                outCount++;
            }
        }
        Console.WriteLine(inCount);
        Console.WriteLine(outCount);
    }
}