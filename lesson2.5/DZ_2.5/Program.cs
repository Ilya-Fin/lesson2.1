using System;

namespace DZ_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            string month = Console.ReadLine();

            Console.WriteLine("Введите МИНИМАЛЬНУЮ температуру за месяц");
            string a = Console.ReadLine();

            Console.WriteLine("Введите МАКСИМАЛЬНУЮ температуру за месяц");
            string b = Console.ReadLine();

            decimal sred = (Convert.ToDecimal(a) + Convert.ToDecimal(b)) / 2;
            Console.WriteLine($"Среднемесячная температура: {sred}");

            switch (month)
            {
                case "1":
                    Console.WriteLine($"Месяц под номером {month}: Январь");   // проверяем температуру в зимний месяц
                    if (sred > 0)
                    { Console.WriteLine("Дождливая зима!"); }
                    else
                    { Console.WriteLine("Морозная зима!"); }
                    break;
                case "2":
                    Console.WriteLine($"Месяц под номером {month}: Февраль");  // проверяем температуру в зимний месяц
                    if (sred > 0) 
                    { Console.WriteLine("Дождливая зима!"); }
                    else
                    { Console.WriteLine("Морозная зима!"); }                        
                    break;
                case "3":
                    Console.WriteLine($"Месяц под номером {month}: Март");
                    break;
                case "4":
                    Console.WriteLine($"Месяц под номером {month}: Апрель");
                    break;
                case "5":
                    Console.WriteLine($"Месяц под номером {month}: Май");
                    break;
                case "6":
                    Console.WriteLine($"Месяц под номером {month}: Июнь");
                    break;
                case "7":
                    Console.WriteLine($"Месяц под номером {month}: Июль");
                    break;
                case "8":
                    Console.WriteLine($"Месяц под номером {month}: Август");
                    break;
                case "9":
                    Console.WriteLine($"Месяц под номером {month}: Сентябрь");
                    break;
                case "10":
                    Console.WriteLine($"Месяц под номером {month}: Октябрь");
                    break;
                case "11":
                    Console.WriteLine($"Месяц под номером {month}: Ноябрь");
                    break;
                case "12":
                    Console.WriteLine($"Месяц под номером {month}: Декабрь");   // проверяем температуру в зимний месяц
                    if (sred > 0)
                    { Console.WriteLine("Дождливая зима!"); }
                    else
                    { Console.WriteLine("Морозная зима!"); }
                    break;
                default:
                    Console.WriteLine("Месяца с таким номером в году нет!");
                    break;
                    Console.ReadKey();

            }
        }
    }
}
