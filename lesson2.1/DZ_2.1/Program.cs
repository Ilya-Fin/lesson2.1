using System;

namespace DZ_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите МИНИМАЛЬНУЮ температуру за сутки");
            string a = Console.ReadLine();
            Console.WriteLine("Введите МАКСИМАЛЬНУЮ температуру за сутки");
            string b = Console.ReadLine();
            Console.WriteLine($"Среднесуточная температура {(Convert.ToDecimal(a) + Convert.ToDecimal(b)) / 2}");
            Console.ReadKey();
        }
    }
}
