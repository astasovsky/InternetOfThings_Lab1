using System;
using MyLib;

namespace ConsolePart1
{
    class Program
    {
        /// <summary>
        /// Calling library method CircleLength(radius) from MyLib.dll.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина круга = " + MyMethods.CircleLength(r));
        }
    }
}
