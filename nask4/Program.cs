internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число А: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число C: ");
        int numberC = Convert.ToInt32(Console.ReadLine());
        int max = 0;
        if (numberA > numberB)
        {
            max = numberA;
        }
        else
        {
            max = numberB;
        }

        if (numberC > max)
        {
            max = numberC;
        }
        Console.WriteLine(max);
    }
}