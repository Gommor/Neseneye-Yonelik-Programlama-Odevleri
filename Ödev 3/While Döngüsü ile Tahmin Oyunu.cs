using System;

class Program
{
    static void Main()
    {
        Random rastgele = new Random();
        int dogruSayi = rastgele.Next(1, 101);
        int tahmin;

        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin:");

        while (true)
        {
            tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin < dogruSayi)
            {
                Console.WriteLine("Daha büyük bir sayı deneyin:");
            }
            else if (tahmin > dogruSayi)
            {
                Console.WriteLine("Daha küçük bir sayı deneyin:");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin.");
                break;
            }
        }
    }
}
