using System;

namespace CalculatorLibrary
{
    public static class MathCalculator
    {
        /// <summary>
        /// Складывает <paramref name="x"/> и <paramref name="y"/>
        /// </summary>
        /// <param name="x">Первый аргумент</param>
        /// <param name="y">Второй аргумент</param>
        /// <returns>сумму чисел</returns>
        public static double Add(double x, double y) => x + y;

        public static double Subtract(double x, double y) => x - y;

        public static double Multiply(double x, double y) => x * y;

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Аргумент не должен быть нулем", 
                    nameof(y));
            }

            return x / y;
        }
    }
}
