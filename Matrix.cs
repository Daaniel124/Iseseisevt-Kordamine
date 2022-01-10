using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_Kordamine
{
    class Matrix
    {
        public static void Table(int a, int b, int x, int y)
        {
            int[,] matrix = new int[a, b];

            Random rand = new Random();
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rand.Next(x, y);
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                    else
                    {
                        count2++;
                    }
                }
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество отрицательных чисел: {0}, положительных: {1}", count, count2);
        }
    }
}
