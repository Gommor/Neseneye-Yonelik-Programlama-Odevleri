using System;

class Program
{
    static void Main()
    {
        double sayi1, sayi2, sonuç;
        char işlem;
        string seçim;

        do
        {
            Console.WriteLine("Birinci sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlem seçin (+, -, *, /):");
            işlem = Convert.ToChar(Console.ReadLine());

            switch (işlem)
            {
                case '+':
                    sonuç = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + sonuç);
                    break;
                case '-':
                    sonuç = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuç);
                    break;
                case '*':
                    sonuç = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + sonuç);
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuç = sayi1 / sayi2;

                        Console.WriteLine("Sonuç: " + sonuç);
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme hatası.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }

            while (true)
            {
                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? (e/cikis): ");
                seçim = Console.ReadLine().ToLower();

                if (seçim == "e")
                {
                    break;
                }
                else if (seçim == "cikis")
                {      
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen 'e' veya 'cikis' yazın.");
                }
            }

        } while (seçim == "e");


    }
}
