using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_Kordamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Палиндром");
            Console.WriteLine("Введите текст:");
            string answer = Console.ReadLine();
            Palindrome.Symbols(answer);
            Console.WriteLine();

            Console.WriteLine("Матрица");
            Console.WriteLine("Введите количество стобцов:");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк:");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальное число (отрицательное):");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное число (положительное):");
            int y = int.Parse(Console.ReadLine());
            Matrix.Table(column, line, x, y);

            Console.WriteLine("Сортировка по ASCII");
            Console.WriteLine("Введите символы:");
            
            StringBuilder symbols = new StringBuilder(Console.ReadLine());
            CodeAsci.Symbols(symbols);

            Console.ReadLine();
        }
    }
}
