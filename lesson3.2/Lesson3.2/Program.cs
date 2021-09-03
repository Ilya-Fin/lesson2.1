using System;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[5, 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                Console.Write("Введите имя пользователя, а затем номер или e-mail ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[i, j] = Console.ReadLine();
                }

            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }


        }
    }
}