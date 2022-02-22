using System;

namespace Ev_Tapsirigi_6____Task_6
/*Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Et:");
            string word = Console.ReadLine();

            string NewWord = "";

            int index = word.IndexOf('a');

            for (int i = word.Length-1; i >= 0; i--)
            {
                NewWord=NewWord+word[i];
            }
            
            int index2=NewWord.IndexOf('a');


            if (index == index2)
            {
                Console.WriteLine("Indexler Iki Terefdende Eynidir");
            }
            else
            {
                Console.WriteLine("Indexler Iki Terefdende Eyni Deyildir");
            }
        }
    }
}
