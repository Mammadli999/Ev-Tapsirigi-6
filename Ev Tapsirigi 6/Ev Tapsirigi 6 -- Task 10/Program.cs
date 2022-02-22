using System;
using System.Text.RegularExpressions;

namespace Ev_Tapsirigi_6____Task_10
/*Verilmish metinde butun reqemleri legv et.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();
            word = word.ToLower();

            word = Regex.Replace(word, @"[\d]",string.Empty);

            Console.WriteLine(word);
        }
    }
}
