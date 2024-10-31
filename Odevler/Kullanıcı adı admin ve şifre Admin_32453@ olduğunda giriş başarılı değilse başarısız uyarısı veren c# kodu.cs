Console.WriteLine("Kullanıcı Adı");
string kullanıcı_adı = Console.ReadLine();
Console.WriteLine("Şifre");
string sifre = Console.ReadLine();

if (kullanıcı_adı == "admin" && sifre == "123")
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("BAŞARISIZ");
}

Console.ReadKey();