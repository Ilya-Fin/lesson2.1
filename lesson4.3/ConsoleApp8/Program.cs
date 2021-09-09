using System;

namespace ConsoleApp8
{
    class Program
    {
        enum Season { Spring = 1, Summer, Autumn, Winter }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            string month = Console.ReadLine();
            string TimeOfAYear = GetMonth(month);
            Console.WriteLine(TimeOfAYear);
            
        }

        static string GetMonth(string month)
        {
            
            if (month == "1" || month == "2" || month == "12")
            {
                return Season.Winter.ToString();
            }
            else
            {
                if (month == "3" || month == "4" || month == "5")
                {
                    return Season.Spring.ToString();
                }
                else
                {
                    if (month == "6" || month == "7" || month == "8")
                    {
                        return Season.Summer.ToString();
                    }
                    else
                    {
                        if (month == "9" || month == "10" || month == "11")
                        {
                            return Season.Autumn.ToString();
                        }
                        else
                        {
                            return "Ошибка: введите число от 1 до 12";
                        }
                    }
                }
            }

        }
    }
}
