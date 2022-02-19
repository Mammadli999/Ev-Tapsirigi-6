using System;

namespace Ev_Tapsirigi_6____Task_4
/*Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metn Daxil Edin: ");
            string word = Console.ReadLine();
            word = word.ToLower();

            int word1 = word.IndexOf('a');

            Console.WriteLine($"A simvolunun Yeri: {word1}");

            if (word1 % 2 == 0)
            {
                Console.WriteLine("{A Simvolunun Yeri Cut Ededdir");
            }
            else
            {
                Console.WriteLine("A Simvolunun Yeri Tek Ededdir");
            }


        }
    }
}
