using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Введите размерность матрицы ");
            int dl = int.Parse(Console.ReadLine());
            int vs = int.Parse(Console.ReadLine());
            var matrix = new int[dl, vs];
            Console.WriteLine("Введите матрицу по строкам ");
            for (j = 0; j < vs; j++)
                for (i = 0; i < dl; i++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Графический вывод матрицы");

            for (j = 0; j < vs; j++)
            {
                Console.Write("\n");
                for (i = 0; i < dl; i++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write("  ");

                }
            }
            Console.Write("\nДиагональные элементы матрциы равны\n");
            for (j = 0; j < vs; j++)
                for (i = 0; i < dl; i++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j]);
                        Console.Write("  ");
                    }
                }

        }
    }
}
