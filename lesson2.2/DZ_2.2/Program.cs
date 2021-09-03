using System;

namespace DZ_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine($"Месяц под номером {a}: Январь");
                    break;
                case "2":
                    Console.WriteLine($"Месяц под номером {a}: Февраль");
                    break;
                case "3":
                    Console.WriteLine($"Месяц под номером {a}: Март");
                    break;
                case "4":
                    Console.WriteLine($"Месяц под номером {a}: Апрель");
                    break;
                case "5":
                    Console.WriteLine($"Месяц под номером {a}: Май");
                    break;
                case "6":
                    Console.WriteLine($"Месяц под номером {a}: Июнь");
                    break;
                case "7":
                    Console.WriteLine($"Месяц под номером {a}: Июль");
                    break;
                case "8":
                    Console.WriteLine($"Месяц под номером {a}: Август");
                    break;
                case "9":
                    Console.WriteLine($"Месяц под номером {a}: Сентябрь");
                    break;
                case "10":
                    Console.WriteLine($"Месяц под номером {a}: Октябрь");
                    break;
                case "11":
                    Console.WriteLine($"Месяц под номером {a}: Ноябрь");
                    break;
                case "12":
                    Console.WriteLine($"Месяц под номером {a}: Декабрь");
                    break;
                default:
                    Console.WriteLine("Месяца с таким номером в году нет!");
                    break;
                    Console.ReadKey();
            }

        }
    }
}
