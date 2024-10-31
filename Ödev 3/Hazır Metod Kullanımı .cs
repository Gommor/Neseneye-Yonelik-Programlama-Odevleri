Console.WriteLine("Bir cümle giriniz.");
string cümle = Console.ReadLine();
string[] kelime = cümle.Split(' ');

Console.WriteLine(" ");
Console.WriteLine("Cümlede kullanılan kelime sayısı:");
Console.WriteLine(kelime.Length);