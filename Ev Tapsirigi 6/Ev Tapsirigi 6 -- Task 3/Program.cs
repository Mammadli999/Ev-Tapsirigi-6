using System;

namespace Ev_Tapsirigi_6____Task_3
/*Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Edin: ");

            string word = Console.ReadLine();
            word = word.ToLower();

            int countA = 0;
            int countB = 0;

            for (int i = 0; i < word.Length; i++)
            {
                
                if (i % 2 != 0)
                {
                    countA++;
                    if (word [i] == 'b')
                    {
                        countB++;
                    }
                }
            }

            Console.WriteLine($"Tek yerde Dayanan B-lerin sayi: {countB}");
            
        }
    }
}
