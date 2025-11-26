using System.Text;

namespace LessonTwoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetDiamond(num));

            Console.WriteLine(GetTriangle(num));

            Console.WriteLine(GetArrow(num));
        }

        /// <summary>
        /// Выбрасывает ошибку
        /// </summary>
        /// <param name="value">Переменная, в которой ошибка</param>
        /// <param name="textException">Текст сообщения об ошибке</param>
        /// <exception cref="ArgumentException"></exception>
        static void ValidateInput(int value, string textException)
        {
            throw new ArgumentException(textException, nameof(value));
        }

        /// <summary>
        /// Возвращает строку, содержащую рисунок ромба
        /// </summary>
        /// <param name="n">Длина диагонали ромба</param>
        /// <param name="symbol">Символ для отрисовки ромба</param>
        /// <returns>Строка с рисунком ромба</returns>
        static StringBuilder GetDiamond(int n, char symbol = 'X')
        {
            if (n <= 0)
            {
                ValidateInput(n, "Число N должно быть положительным.");
            }

            if (n % 2 == 0)
            {
                ValidateInput(n, "Число N должно быть нечётным.");
            }

            StringBuilder diamond = new StringBuilder();

            // Индекс центральной строки
            int center = n / 2;

            for (int i = 0; i < n; i++)
            {
                // Внешний отсутп
                int outerSpaces = Math.Abs(center - i);
                // Внутренний отсутп
                int innerSpaces = n - 2 * outerSpaces - 2;

                diamond.Append(' ', outerSpaces);
                diamond.Append('X');

                if (innerSpaces >= 0)
                {
                    diamond.Append(' ', innerSpaces);
                    diamond.Append('X');
                }

                // Перенос строки
                diamond.AppendLine();
            }

            return diamond;
        }

        /// <summary>
        /// Возвращает строку, содержащую рисунок пустого треугольника
        /// </summary>
        /// <param name="n">Высота треугольника</param>
        /// <param name="symbol">Символ для отрисовки</param>
        /// <returns>Строка с рисунком треугольника</returns>
        static StringBuilder GetTriangle(int n, char symbol = 'X')
        {
            if (n <= 0)
            {
                ValidateInput(n, "Высота треугольника N должна быть положительной.");
            }

            StringBuilder triangle = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                // Основание треугольника
                if (i == n - 1)
                {
                    triangle.Append(symbol, n);
                }
                else
                {
                    // Левая стенка
                    triangle.Append(symbol);

                    // Если это не верхушка
                    if (i > 0)
                    {
                        int innerSpaces = i - 1;

                        triangle.Append(' ', innerSpaces);

                        // Правая стенка
                        triangle.Append(symbol);
                    }
                }

                // Перенос строки
                triangle.AppendLine();
            }

            return triangle;
        }

        /// <summary>
        /// Возвращает строку, содержащую рисунок стрелки
        /// </summary>
        /// <param name="n">Высота стрелки (должно быть нечётным числом)</param>
        /// <param name="symbol">Символ для отрисовки</param>
        /// <returns>Строка с рисунком стрелки</returns>
        static StringBuilder GetArrow(int n, char symbol = 'X')
        {
            if (n < 0)
            {
                ValidateInput(n, "Высота стрелки N должна быть положительной.");
            }

            if (n % 2 == 0)
            {
                ValidateInput(n, "Высота стрелки N должна быть нечётной.");
            }

            StringBuilder arrow = new StringBuilder();

            // Середина фигуры
            int center = n / 2;

            for (int i = 0; i < n; i++)
            {
                arrow.Append(symbol);

                // Расстояние от центральной строки.
                int distanceFromCenter = Math.Abs(center - i);

                // Отступ для второго символа
                int innerSpaces = (center - 1) - distanceFromCenter;

                if (innerSpaces == 0)
                {
                    arrow.Append(symbol);
                }
                else if (innerSpaces > 0)
                {
                    arrow.Append(' ', innerSpaces);
                    arrow.Append(symbol);
                }

                // Перенос строки
                arrow.AppendLine();
            }

            return arrow;
        }
    }
}
