using System;

namespace Ev_Tapsirigi_6____Task_1
/*Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz = "Hezi Aslanov Baki Seheri";

            char a;
            char b;

            int countA = 0;
            int countB = 0;

            for (int i = 0; i < soz.Length; i++)
            {
                if (soz.ToLower()[i] == 'a')
                {
                    countA++;
                }
                else if (soz.ToLower()[i] == 'b')
                {
                    countB++;
                }
            }

            double cavab = countA * 1.0 / countB;
            Console.WriteLine($">>>{cavab}");
        }
    }
    
}
