using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nazvanie, adress, kassa, licenzia, tovar1, tovar2, tovar3, tovar4, tovar5, propusk, konec;
            int kolvo1, kolvo2, kolvo3;
            double price1, price2, price3, price4, price5, ves1, ves2, sum, pr1, pr2, pr3, pr4, pr5;
            DateTime data = new DateTime(2021, 7, 2, 15, 20, 14);
            nazvanie = "ООО Лента";
            adress = "115573, г. Москва, Ореховый б-р, 22 А";
            kassa = "КАССА: 0016 Кассир: Иванов Иван Петрович";
            licenzia = "ДОКУМЕНТ НА ПРОДАЖУ №18 СМЕНА №0257";
            propusk = "--------------------------------------------------------";
            tovar1 = "Пакет Лента средний майка 1";
            price1 = 6.79;
            kolvo1 = 1;
            pr1 = price1 * kolvo1;
            tovar2 = "Яблоки Глостер вес 1кг";
            price2 = 99.99;
            ves1 = 1.296;
            pr2 = Math.Round(price2 * ves1, 2); // Округление ПОДИТОГА до 2х знаков после запятой
            tovar3 = "Морковь мытая п/3 1000г";
            price3 = 75.20;
            ves2 = 2.562;
            pr3 = Math.Round(price3 * ves2, 2); // Округление ПОДИТОГА до 2х знаков после запятой
            tovar4 = "Молоко ДОМИК В ДЕРЕВНЕ у/па";
            price4 = 56.99;
            kolvo2 = 3;
            pr4 = price4 * kolvo2;
            tovar5 = "Минибагет оригинал";
            price5 = 26.23;
            kolvo3 = 2;
            pr5 = price5 * kolvo3;
            sum = pr1 + pr2 + pr3 + pr4 + pr5;
            konec = $"Итого к оплате   ={sum} \nБаноквская карта ={sum}";
            Console.WriteLine(nazvanie);
            Console.WriteLine(adress);
            Console.WriteLine(propusk);
            Console.WriteLine(kassa);
            Console.WriteLine(licenzia);
            Console.WriteLine(propusk);
            Console.WriteLine("     Название товара          Цена   Кол-во     ИТОГ ");
            Console.WriteLine($"{tovar1}   {price1}     {kolvo1}        {pr1}");
            Console.WriteLine($"{tovar2}        {price2}    {ves1}    {pr2}");
            Console.WriteLine($"{tovar3}       {price3}     {ves2}    {pr3}");
            Console.WriteLine($"{tovar4}   {price4}    {kolvo2}        {pr4}");
            Console.WriteLine($"{tovar5}            {price5}    {kolvo3}        {pr5}");
            Console.WriteLine(propusk);
            Console.WriteLine($"ПОДИТОГ    РУБ= {Math.Round(sum, 2)}"); // Округление ПОДИТОГА до 2х знаков после запятой
            Console.WriteLine(propusk);
            Console.WriteLine(konec);
            Console.WriteLine(propusk);
            Console.WriteLine(data.ToString("dd.MM.yy") + "                                       " + data.ToString("HH:mm:ss")); //Вывод слева только ДАТА , а справа только ВРЕМЯ
            Console.WriteLine("*Продажа товара!* \nСПАСИБО ЗА ПОКУПКУ!");
            Console.ReadKey();
        }
    }
}
