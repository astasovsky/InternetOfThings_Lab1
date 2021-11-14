using System;

namespace MyLib
{
    /// <summary>
    /// Methods that implement the task.
    /// </summary>
    public class MyMethods
    {
        /// <summary>
        /// Calculating the length of a circle.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        /// <returns>Returns the length of the circle.</returns>
        static public double CircleLength(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Function of finding the multiplication P = a(a-n)(a-2n)..(a-n^2).
        /// </summary>
        /// <param name="n">Natural number.</param>
        /// <param name="a">Real number.</param>
        /// <returns>Returns P.</returns>
        static public double FindMultiplication(int n, double a)
        {
            if (n <= 0)
            {
                throw new ArgumentException($"{n} is not a natural number.", "n");
            }
            double P = 0;
            for (int i = 0; i <= n; i++)
            {
                P += a - i * n;
            }
            return P;
        }

        /// <summary>
        /// Ln(x).
        /// </summary>
        /// <param name="x">Real number.</param>
        /// <param name="n">Accuracy.</param>
        /// <returns>Returns the natural logarithm of a given number.</returns>
        static public double Ln(double x, int n)
        {
            double ln = 0;
            for (int i = 0; i < n; i++)
            {
                ln += (x - 1) / ((2 * n - 1) * Math.Pow(x + 1, 2 * n - 1));
            }
            return ln;
        }
    }
}
