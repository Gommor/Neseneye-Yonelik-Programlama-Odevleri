using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Koleksiyonlar
{
    class Dizi
    {
        static void Main(string[] args)
        {
            ArrayList arraylist1 = new ArrayList();

            Console.WriteLine("5 adet kelime giriniz.");
            string kelime1 = Console.ReadLine();
            string kelime2 = Console.ReadLine();
            string kelime3 = Console.ReadLine();
            string kelime4 = Console.ReadLine();
            string kelime5 = Console.ReadLine();

            arraylist1.Add(kelime1);  
            arraylist1.Add(kelime2);  
            arraylist1.Add(kelime3);  
            arraylist1.Add(kelime4);  
            arraylist1.Add(kelime5);

            Console.WriteLine("Alfabetik sıralanmış liste: ");

            arraylist1.Sort();
            foreach(string i in arraylist1)
                Console.WriteLine(i.ToString());
        }
    }
}


