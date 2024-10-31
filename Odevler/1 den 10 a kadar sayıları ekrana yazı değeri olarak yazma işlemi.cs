Console.WriteLine("1-10 arasi sayi giriniz.");
int sayi = int.Parse(Console.ReadLine());
switch (sayi)
{
    case 1: Console.Write("Bir"); break;
    case 2: Console.Write("İki"); break;
    case 3: Console.Write("Üç"); break;
    case 4: Console.Write("Dört"); break;
    case 5: Console.Write("Beş"); break;
    case 6: Console.Write("Altı"); break;
    case 7: Console.Write("Yedi"); break;
    case 8: Console.Write("Sekiz"); break;
    case 9: Console.Write("Dokuz"); break;
    case 10: Console.Write("On"); break;
    default: Console.Write("Yanlış değer girdiniz! Lütfen 1-10 arası bir değer giriniz."); break;
}
Console.ReadKey();