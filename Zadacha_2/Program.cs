using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    internal class Program
    {
        static string[] SortByLength(string[] array)
        {
            string[] sortedArray = array.OrderBy(s => s.Length).ToArray();
            return sortedArray;
        }

    static void Main(string[] args)
        {
            string[] strings = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] strings2 = SortByLength(strings); 
            foreach (string s in strings2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
