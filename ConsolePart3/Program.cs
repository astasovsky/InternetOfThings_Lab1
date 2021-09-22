using System;
using MyLib;

namespace ConsolePart3
{
    class Program
    {
        /// <summary>
        /// Calling library method Ln(x,e) from MyLib.dll.
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Введите число х: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите точность e: ");
            double e = double.Parse(Console.ReadLine());

            //Calling the method of calculation Ln(x,e) from library.
            double my_ln = MyMethods.Ln(x, e);

            ///Calling the method from <see cref="Math"/>.
            double ln = Math.Log(x);

            double calculation_error = 100 * Math.Abs(ln - ln) / ln;

            Console.WriteLine("\nСумма ряда = " + ln);
            Console.WriteLine("Точное значение = " + ln);
            Console.WriteLine($"Ошибка вычислений = {Math.Round(calculation_error, 2)}%");
        }
    }
}
