Console.WriteLine("Sıcaklık kaç derece?");
int s = int.Parse(Console.ReadLine());


if (s >= 10 && s < 20)
{
    Console.WriteLine("normal");
}
else if (s >= 20 && s < 30)
{
    Console.WriteLine("sıcak");
}
else if (s >= 30 && s <= 40)
{
    Console.WriteLine("çok sıcak");
}
else
{
    Console.WriteLine("Girilen parametre yanlış");
}

Console.ReadKey();