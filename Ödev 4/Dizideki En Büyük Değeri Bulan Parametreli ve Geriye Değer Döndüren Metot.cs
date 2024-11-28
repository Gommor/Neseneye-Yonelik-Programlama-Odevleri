class Program
{
    public static int EnBüyükBul(int[] Dizi)
    {
        int enBüyük = Dizi[0];

        for (int i = 1; i < Dizi.Length; i++)
        {
            if (enBüyük < Dizi[i])
            {
                enBüyük = Dizi[i];
            }
        }

        return enBüyük;
    }

    public static void Main()
    {
        int[] Dizi = { -15, 200, 150, 350, 7540, 12, -53678, 7000 };

        Console.WriteLine(EnBüyükBul(Dizi));
    }
}
