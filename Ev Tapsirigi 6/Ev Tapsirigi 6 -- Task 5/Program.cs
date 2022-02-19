using System;

namespace Ev_Tapsirigi_6____Task_5
    /*Verilmish metnde sol terefden saydiqda {a},{b},{c} simvollarindan hansi birinci gelir?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et: ");
            string word = Console.ReadLine();
            word = word.ToLower();

            char[] symbols = { 'a', 'b', 'c' };

            int index = word.IndexOfAny(symbols);

            Console.WriteLine($"Ilk Gelen Simvol:{word[index]}\n" +
                $"Indexi:{index}");
        }
    }
}
