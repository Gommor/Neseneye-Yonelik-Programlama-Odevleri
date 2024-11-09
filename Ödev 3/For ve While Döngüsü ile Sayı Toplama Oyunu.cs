using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
        int sayi;
        int toplam = 0;

        Console.WriteLine("Pozitif tam sayılar girin (girişi sonlandırmak için 0 girin):");

        while (true)
        {
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0)
            {
                break;
            }
            else if (sayi > 0)
            {
                sayilar.Add(sayi);
                toplam += sayi;
            }
            else
            {
                Console.WriteLine("Lütfen sadece pozitif sayılar girin.");
            }
        }

        Console.WriteLine("Girilen pozitif sayıların toplamı:" + toplam);

        Console.WriteLine("Girilen pozitif sayılar:");
        for (int i = 0; i < sayilar.Count; i++)
        {
            Console.WriteLine(sayilar[i]);
        }
    }
}
