using System;
using MyLib;

namespace ConsolePart2
{
    class Program
    {
        /// <summary>
        /// Calling library method FindMultiplication(n, a) from MyLib.dll.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("P = " + MyMethods.FindMultiplication(n, a));
        }
    }
}
