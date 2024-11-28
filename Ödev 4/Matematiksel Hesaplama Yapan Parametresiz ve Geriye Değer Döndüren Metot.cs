class Program
{
    public static double ÜçgenAlanıHesapla()
    {
        double taban, yükseklik;

        Console.Write("Üçgenin tabanını giriniz: ");
        taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini giriniz: ");
        yükseklik = Convert.ToDouble(Console.ReadLine());

        return (taban * yükseklik) / 2;
    }

    public static void Main()
    {
        Console.WriteLine(ÜçgenAlanıHesapla());
    }
}
