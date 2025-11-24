namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            //var oddNumbers = GetListOddNumbers(num);

            //Console.WriteLine(string.Join(", ", oddNumbers));

            //var square = GetSquare(num);

            //foreach (var row in square)
            //{
            //    Console.WriteLine(string.Join("", row));
            //}

            Console.WriteLine(GetStringOddNumbers(num));

            //Console.WriteLine(GetEmptySquare(num));


            Console.Write("Input string: ");
            string s = Console.ReadLine();

            if (GetWord(s))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }

        /// <summary>
        /// Возвращает строку, содержащую все нечетные числа от 1 до указанного числа
        /// </summary>
        /// <param name="num">Верхняя граница диапазона</param>
        /// <returns>Строка из нечетных чисел, разделенных запятой</returns>
        static string GetStringOddNumbers(int num)
        {
            string oddNumbers = string.Empty;

            for (int i = 1; i <= num; i += 2)
            {
                oddNumbers += i + ", ";
            }
            //Удаление запятой и пробела в конце
            return oddNumbers.TrimEnd(',', ' ');
        }

        /// <summary>
        /// Возвращает список нечетных чисел от 1 до указанного числа
        /// </summary>
        /// <param name="num">Верхняя граница диапазона</param>
        /// <returns>Список целых нечетных чисел</returns>
        static List<int> GetListOddNumbers(int num)
        {
            var oddNumbers = new List<int>();

            for (int i = 1; i <= num; i += 2)
            {
                oddNumbers.Add(i);
            }

            return oddNumbers;
        }

        /// <summary>
        /// Возвращает двумерную структуру, представляющую заполненный квадрат.
        /// </summary>
        /// <param name="size">Размер стороны квадрата</param>
        /// <param name="symbol">Символ, которым будет заполнен квадрат (по умолчанию "X")</param>
        /// <returns>Список списков строк, образующий квадрат.</returns>
        static List<List<string>> GetSquare(int size, string symbol = "X")
        {
            List<List<string>> square = new List<List<string>>();

            for (int i = 0; i < size; i++)
            {
                List<string> rowSquare = new List<string>();

                for (int j = 0; j < size; j++)
                {
                    rowSquare.Add(symbol);
                }

                square.Add(rowSquare);
            }

            return square;
        }

        /// <summary>
        /// Возвращает строковое представление пустого квадрата (только рамка).
        /// </summary>
        /// <param name="num">Размер стороны квадрата</param>
        /// <param name="symbol">Символ для отрисовки рамки (по умолчанию "X")</param>
        /// <returns>Строка, содержащая рисунок пустого квадрата</returns>
        static string GetEmptySquare(int num, string symbol = "X")
        {
            string square = string.Empty;

            square = new string(symbol[0], num);// Создаем полную строку
            square += "\n";
            // Создаем строки с пробелами
            for (int i = num; i < num * (num - 1); i++)
            {
                if (i % num == 0) square += symbol;
                else if ((i + 1) % num == 0) square += $"{symbol}\n";
                else square += ' ';
            }
            square += new string(symbol[0], num);

            return square;
        }

        /// <summary>
        /// Проверяет, содержится ли искомое слово в строке как подпоследовательность (символы идут в нужном порядке, но могут быть разделены другими символами).
        /// </summary>
        /// <param name="inputWord">Входная строка для проверки</param>
        /// <param name="target">Искомое слово (по умолчанию "hello").</param>
        /// <returns>True, если слово можно составить, иначе False.</returns>
        static bool GetWord(string inputWord, string target = "hello")
        {
            int targetIndex = 0; // Индекс для target
            int inputIndex = 0;  // Индекс для входной строки

            while (inputIndex < inputWord.Length && targetIndex < target.Length)
            {
                if (inputWord[inputIndex] == target[targetIndex])
                    targetIndex++;
                inputIndex++;
            }

            return targetIndex == target.Length;
        }

    }
}