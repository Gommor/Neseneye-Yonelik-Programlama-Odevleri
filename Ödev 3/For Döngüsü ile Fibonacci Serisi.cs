using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fibonacci serisi için bir sayı girin:");
        int n = int.Parse(Console.ReadLine());

        int sayi1 = 0, sayi2 = 1, sonraki;

        Console.Write("Fibonacci Serisi: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(sayi1 + " ");

            sonraki = sayi1 + sayi2;
            sayi1 = sayi2;
            sayi2 = sonraki;
        }
    }
}
