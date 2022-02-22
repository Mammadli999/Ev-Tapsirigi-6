using System;

namespace Ev_Tapsirigi_6____Task_9
/*Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();
            word = word.ToLower();

            string word1 = word.Substring(0,3);
            string word2 = word.Substring(word.Length-3,3);

            string NewWord = "";

            for (int i = word2.Length - 1; i > -1; i--)
            {
                NewWord = NewWord + word2[i];
            }

            if (word1 == NewWord)
            {
                Console.WriteLine("Ilk 3 Simvol,Son 3 Simvolun Tersinesine Beraberdir");
            }
            else
            {
                Console.WriteLine("Ilk 3 Simvol,Son 3 Simvolun Tersinesine Beraber Deyildir");
            }
        }
    }
}
