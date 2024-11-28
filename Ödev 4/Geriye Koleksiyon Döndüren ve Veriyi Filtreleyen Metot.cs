class Program
{
    public static List<string> StringFiltresi(string[] Strings)
    {
        List<string> geçen = new List<string> { };

        foreach (string str in Strings)
        {
            if (str.Length > 5)
            {
                geçen.Add(str);
            }
        }

        return geçen;
    }

    public static void Main()
    {
        string[] StringDizi = { "Hasan", "Berkay", "Muhammed", "Emir", "Ali", "Ahmet" };

        List<string> FiltrelenmişDizi = StringFiltresi(StringDizi);

        Console.WriteLine(string.Join(", ", FiltrelenmişDizi));
    }
}
