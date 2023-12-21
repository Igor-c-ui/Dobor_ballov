using System;

namespace Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            int[] cubedNumbers = numbers.Cube();
            int[] evenNumbers = numbers.Even();

            Console.WriteLine(string.Join(", ", cubedNumbers));
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
