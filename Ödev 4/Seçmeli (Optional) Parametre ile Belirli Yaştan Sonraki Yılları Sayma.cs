class Program
{
    public static int YaşBüyüklüğü(int Yaş = 18)
    {
        return Yaş - 18;
    }

    public static void Main()
    {
        Console.WriteLine(YaşBüyüklüğü());
        Console.WriteLine(YaşBüyüklüğü(18));
        Console.WriteLine(YaşBüyüklüğü(29));
    }
}
