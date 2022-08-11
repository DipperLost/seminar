Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(count < N)
{
    while(count <= N)
    {
        Console.WriteLine(count);
        count++;
    }
}
else
{
    while(count >= N)
    {
        Console.WriteLine(N);
        N++;
    }
}
