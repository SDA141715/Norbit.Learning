using System;

namespace CalculatorLibrary
{
    public class MathCalculator
    {
        public double Add(double x, double y) => x + y;

        public double Subtract(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;

        public double Divide(double x, double y)
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
