using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_Kordamine
{
    class CodeAsci
    {
        public static void Symbols(StringBuilder line)
        {
            for (int i = 0; i < line.Length - 1; i++)
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[i] > line[j])
                    {
                        char a = line[i];
                        line[i] = line[j];
                        line[j] = a;
                    }
                }
            Console.WriteLine("Преобразованная строка: {0}",line);
            string c = line.ToString();
            char[] b = c.ToCharArray();
            Array.Reverse(b);
            string output = new string(b);
            Console.WriteLine("Отсортированная строка: {0}", output);
        }
    }
}
