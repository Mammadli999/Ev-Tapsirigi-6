using System;

namespace Ev_Tapsirigi_6____Task_8
/* Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();
            word = word.ToLower();



            int index = word.IndexOf('a');
            int index2 = index + 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{word[index2]}");
            }
        }
    }
}
