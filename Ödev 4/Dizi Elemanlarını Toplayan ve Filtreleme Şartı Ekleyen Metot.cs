class Program
{
    public static int FiltreliToplam(int[] Dizi, int Filtre)
    {
        int toplam = 0;

        foreach (int i in Dizi)
        {
            if (i > Filtre)
            {
                toplam = toplam + i;
            }
        }

        return toplam;
    }

    public static void Main()
    {
        int[] Dizi = { 7, 12, 13, 14, 15, 16, 17, 18, 20, 30 };
        int Filtre = 18;

        Console.WriteLine(FiltreliToplam(Dizi, Filtre));
    }
}
