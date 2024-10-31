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
            arraylist1.Add(11);
            arraylist1.Add(1);
            arraylist1.Add(20);
            arraylist1.Add(6);
            arraylist1.Add(7);
            foreach (int i in arraylist1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");
            int toplam = 0;

            Console.WriteLine("Toplamları:");
            foreach (int i in arraylist1)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
        }
    }
}


