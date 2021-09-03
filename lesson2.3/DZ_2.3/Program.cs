using System;

namespace DZ_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            a = a % 2; //Остакток от деления числа на 2
            if (a == 0)
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Число нечётное.");
            }
            Console.ReadKey();
        }
    }
}
