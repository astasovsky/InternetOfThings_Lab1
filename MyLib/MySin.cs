using System;

namespace MyLib
{
    /// <summary>
    /// Calculation of mathematical functions.
    /// </summary>
    public class MySin
    {
        /// <summary>
        /// Sin(x).
        /// </summary>
        /// <param name="x">Angle in radians.</param>
        /// <param name="n">Degree indicator.</param>
        /// <returns>Returns the value of the function Sin for a given angle.</returns>
        public static double Sin(double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1)) / F(2 * i + 1);
            }
            return result;
        }

        static double F(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
    }
}