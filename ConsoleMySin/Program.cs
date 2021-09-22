using System;

namespace ConsoleMySin
{
    class Program
    {
        /// <summary>
        /// Calling library method Sin(x,n) from MyLib.dll.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите х (угол в радианах): ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите показатель степени n: ");
            int n = int.Parse(Console.ReadLine());
            //Calling the method of calculation Sin(x,n) from library.
            double my_sin = MyLib.MySin.Sin(x, n);
            ///Calling the method from <see cref="Math"/>
            double sin = Math.Sin(x);
            double delta = sin - my_sin;
            Console.WriteLine($"my_sin = {my_sin}, sin = {sin}, delta = {delta}");
        }
    }
}