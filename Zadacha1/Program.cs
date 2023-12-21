using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        public static string Diamond_thread(int size)
        {
            if (size % 2 == 0 | size < 0)
            {
                return null;
            }
            string diamondStr = "";

            // Верхняя половина ромба
            for (int i = 1; i <= size; i += 2)
            {
                int spaces = (size - i) / 2;
                diamondStr += new string(' ', spaces) + new string('*', i) + "\n";
            }

            // Нижняя половина ромба
            for (int i = size - 2; i > 0; i -= 2)
            {
                int spaces = (size - i) / 2;
                diamondStr += new string(' ', spaces) + new string('*', i) + "\n";
            }

            return diamondStr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Diamond_thread(9));
        }
    }
}
