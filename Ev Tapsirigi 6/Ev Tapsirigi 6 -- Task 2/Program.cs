using System;

namespace Ev_Tapsirigi_6____Task_2
/*Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Amerika Xeyallar Olkesidir";
            word = word.ToLower();

            int countA = 0;
            int countB = 0;


            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    countA++;
                    if (word[i] == 'a')
                    {
                        countB++;
                    }
                }
                
            }
            if (countA == countB)
            {
                Console.WriteLine("Tek Yerde Dayanan Herflerin Hamisi A-dir");
            }
            else
            {
                Console.WriteLine("Tek Yerde Dayanan Simvollarin Hamisi A Deyildir");
            }
        }
    }
    
}
