using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadacha_4
{
    internal class Program
    {
        static int CountSmileys(string[] arr)
        {
            string pattern = "[:;][-~]?[)D]";

            int count = arr.Count(s => Regex.IsMatch(s, pattern));

            return count;
        }

        static void Main(string[] args)
        {
            string[] arr = { ":)", ":D", ";-D", ":~)", ";)", ":>", ":}", ":]" };

            int result = CountSmileys(arr);
            Console.WriteLine(result);
        }
    }
}
