class Program
{
    public static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    public static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    public static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }

    public static void Main()
    {
        Console.WriteLine(CalculateSum(20, 50));
        Console.WriteLine(CalculateSum(20.6, 50.3));
        Console.WriteLine(CalculateSum(20, 50, 30));
    }
}
