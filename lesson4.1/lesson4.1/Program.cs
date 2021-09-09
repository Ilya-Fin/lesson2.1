using System;

namespace lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FIO = "";
            Console.WriteLine("Введите количество пользователей");
            int i = int.Parse(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                FIO = FIO + "\n" + GetFullName();
                Console.WriteLine(FIO);
            }





        }
        static string GetFullName()
        {
            Console.WriteLine("Введите Фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите Имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите Отчество");
            string patronymic = Console.ReadLine();
            string FullName = lastName + " " + firstName + " " + patronymic;
            return FullName;
        }

    }

}

