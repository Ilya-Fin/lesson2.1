using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            Console.WriteLine("Введите строку чисел, чтобы получить сумму.");
            string line = Console.ReadLine();
            string[] numbers = line.Split(" ");
            var dlinna = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                dlinna[i] = int.Parse(numbers[i]);
            }

            for (int i = 0; i < dlinna.Length; i++)
            {
                summ = summ + dlinna[i];
            }
            Console.WriteLine(summ);
        }
    }
}
