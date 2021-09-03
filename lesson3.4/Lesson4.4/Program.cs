using System;

namespace Lesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seafight = new string[10, 10];
            seafight[0, 0] = "O";
            seafight[0, 1] = "O";
            seafight[0, 2] = "X";
            seafight[0, 3] = "O";
            seafight[0, 4] = "O";
            seafight[0, 5] = "O";
            seafight[0, 6] = "O";
            seafight[0, 7] = "O";
            seafight[0, 8] = "O";
            seafight[0, 9] = "O";

            seafight[1, 0] = "O";
            seafight[1, 1] = "O";
            seafight[1, 2] = "O";
            seafight[1, 3] = "O";
            seafight[1, 4] = "O";
            seafight[1, 5] = "O";
            seafight[1, 6] = "X";
            seafight[1, 7] = "O";
            seafight[1, 8] = "O";
            seafight[1, 9] = "O";

            seafight[2, 0] = "O";
            seafight[2, 1] = "O";
            seafight[2, 2] = "O";
            seafight[2, 3] = "X";
            seafight[2, 4] = "X";
            seafight[2, 5] = "O";
            seafight[2, 6] = "O";
            seafight[2, 7] = "O";
            seafight[2, 8] = "O";
            seafight[2, 9] = "O";

            seafight[3, 0] = "O";
            seafight[3, 1] = "O";
            seafight[3, 2] = "O";
            seafight[3, 3] = "O";
            seafight[3, 4] = "O";
            seafight[3, 5] = "O";
            seafight[3, 6] = "O";
            seafight[3, 7] = "X";
            seafight[3, 8] = "O";
            seafight[3, 9] = "O";

            seafight[4, 0] = "O";
            seafight[4, 1] = "O";
            seafight[4, 2] = "O";
            seafight[4, 3] = "X";
            seafight[4, 4] = "O";
            seafight[4, 5] = "O";
            seafight[4, 6] = "O";
            seafight[4, 7] = "X";
            seafight[4, 8] = "O";
            seafight[4, 9] = "O";

            seafight[5, 0] = "X";
            seafight[5, 1] = "X";
            seafight[5, 2] = "O";
            seafight[5, 3] = "O";
            seafight[5, 4] = "O";
            seafight[5, 5] = "O";
            seafight[5, 6] = "O";
            seafight[5, 7] = "X";
            seafight[5, 8] = "O";
            seafight[5, 9] = "O";

            seafight[6, 0] = "O";
            seafight[6, 1] = "O";
            seafight[6, 2] = "O";
            seafight[6, 3] = "X";
            seafight[6, 4] = "X";
            seafight[6, 5] = "X";
            seafight[6, 6] = "O";
            seafight[6, 7] = "X";
            seafight[6, 8] = "O";
            seafight[6, 9] = "O";

            seafight[7, 0] = "O";
            seafight[7, 1] = "O";
            seafight[7, 2] = "O";
            seafight[7, 3] = "O";
            seafight[7, 4] = "O";
            seafight[7, 5] = "O";
            seafight[7, 6] = "O";
            seafight[7, 7] = "O";
            seafight[7, 8] = "O";
            seafight[7, 9] = "O";

            seafight[8, 0] = "O";
            seafight[8, 1] = "O";
            seafight[8, 2] = "O";
            seafight[8, 3] = "O";
            seafight[8, 4] = "O";
            seafight[8, 5] = "X";
            seafight[8, 6] = "O";
            seafight[8, 7] = "O";
            seafight[8, 8] = "X";
            seafight[8, 9] = "O";

            seafight[9, 0] = "O";
            seafight[9, 1] = "X";
            seafight[9, 2] = "X";
            seafight[9, 3] = "X";
            seafight[9, 4] = "O";
            seafight[9, 5] = "O";
            seafight[9, 6] = "O";
            seafight[9, 7] = "O";
            seafight[9, 8] = "X";
            seafight[9, 9] = "O";



            for (int i = 0; i < seafight.GetLength(0); i++)
            {
                for (int j = 0; j < seafight.GetLength(1); j++)
                {
                    
                    Console.Write(" ");
                    Console.Write(seafight[i, j]);
                    Console.Write(" |");
                }
                Console.WriteLine("\n----------------------------------------");
            }

        }
    }
}
