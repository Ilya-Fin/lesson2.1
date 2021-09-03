using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            char[] char1 = txt.ToCharArray();

            for (int i = 1; i < txt.Length; i++)

            {
                Console.Write(char1[txt.Length - 1 * i]);
            }
            Console.Write(char1[0]);
        }
    }
}
