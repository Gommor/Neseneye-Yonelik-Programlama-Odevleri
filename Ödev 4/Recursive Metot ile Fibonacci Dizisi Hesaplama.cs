class Program
{
    public static int Fibonacci(int Terim)
    {
        if (Terim < 2)
            return Terim;

        return Fibonacci(Terim - 1) + Fibonacci(Terim - 2);
    }

    public static void Main()
    {
        Console.Write("Terim: ");
        int terim = Convert.ToInt32(Console.ReadLine());

        Console.Write(Fibonacci(terim));
    }
}
