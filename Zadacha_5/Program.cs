using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Program
    {

        static int? FindClosestToZero(int[] arr)
        {
            int[] nonNegativeValues = arr.Where(x => x >= 0).ToArray();
            int[] negativeValues = arr.Where(x => x < 0).ToArray();


            if (arr.Contains(0))
                return 0;

            if (nonNegativeValues.Length > 0 && (negativeValues.Length == 0 || nonNegativeValues.Min() < Math.Abs(negativeValues.Min())))
                return nonNegativeValues.Min();

            return negativeValues.Max();
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 2, -2 };
            int? result = FindClosestToZero(array);
            Console.WriteLine(result.HasValue ? result.Value.ToString() : "None");
        }
    }
}
