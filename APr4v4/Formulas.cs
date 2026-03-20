using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APr4v4
{
    public class Formulas
    {
        /// <summary>
        /// Считает по первой формуле
        /// </summary>
        /// <param name="x">Параметр икс</param>
        /// <param name="y">Параметр игрек</param>
        /// <param name="z">Параметр Z</param>
        /// <returns>Подсчитанное значение</returns>
        public static double calc_1(double x, double y, double z)
        {
            return Math.Pow(
                Math.Abs(
                    Math.Cos(x) - Math.Cos(y)
                ),
                1 + 2 * Math.Pow(Math.Sin(y), 2)
            ) * (
                1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4
            );
        }
        public enum Function2
        {
            sh_x, x2, ex
        }
        /// <summary>
        /// Считает по второй формуле
        /// </summary>
        /// <param name="x">Параметр икс</param>
        /// <param name="y">Параметр игрек</param>
        /// <param name="func">Функция из `enum Function2`</param>
        /// <returns>Подсчитанное значение</returns>
        public static double calc_2(double x, double y, Function2 func)
        {
            Func<double, double> f = func == Function2.sh_x
                ? new Func<double, double>(x_ => Math.Sinh(x_))
                : (func == Function2.x2
                    ? new Func<double, double>(x_ => x_ * x_)
                    : new Func<double, double>(x_ => Math.Pow(Math.E, x_))
                );

            return x == y ? 0.5 + Math.Pow(y + f(x), 3) : (
                Math.Atan(f(x)) + Math.Pow(f(x) - y, 3) * (x > y ? 1 : -1) // очевидно
            );
        }
        /// <summary>
        /// Считает по третьей формуле
        /// </summary>
        /// <param name="a">Параметр а</param>
        /// <param name="b">Параметр бэ</param>
        /// <param name="x">Параметр икс</param>
        /// <returns>Подсчитанное значение</returns>
        public static double calc_3(double a, double b, double x)
        {
            return a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
        }
    }
}
