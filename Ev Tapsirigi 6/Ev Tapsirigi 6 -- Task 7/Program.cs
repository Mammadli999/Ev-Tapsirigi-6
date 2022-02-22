using System;

namespace Ev_Tapsirigi_6____Task_7
/*Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et:");
            string word=Console.ReadLine();
            word=word.ToLower();

            int index = word.IndexOf('a');
            int index2 = word.IndexOf('b');
            int index3 = word.IndexOf('c');

            if (index<index2 && index2<index3)
            {
                Console.WriteLine("A Simvolu B-den, B Simvolu Ise C-den Evvel Gelir");
            }
            else
            {
                Console.WriteLine("A Simvolu B-den, B Simvolu Ise C-den Evvel Gelmir");
            }
        }
    }
}
