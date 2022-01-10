using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtöö_Kordamine
{
    class Palindrome
    {
        public static void Symbols(string text)
        {
            char[] obrtext = text.ToCharArray();
            Array.Reverse(obrtext);
            string finaltext = new string(obrtext);
            if (text == finaltext)
            {
                Console.Write("Это палиндромом");
            }
            if (text != finaltext)
            {
                Console.Write("Это не палиндромом");
            }
        }
    }
}
