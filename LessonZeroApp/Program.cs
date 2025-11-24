namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Input number: ");
            //int num = int.Parse(Console.ReadLine());

            //var oddNumbers = GetListOddNumbers(num);

            //Console.WriteLine(string.Join(", ", oddNumbers));

            //var square = GetSquare(num);

            //foreach (var row in square)
            //{
            //    Console.WriteLine(string.Join("", row));
            //}

            //Console.WriteLine(GetStringOddNumbers(num));

            //Console.WriteLine(GetEmptySquare(num));


            Console.Write("Input string: ");
            string s = Console.ReadLine();

            if (GetWord(s))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
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

        static List<int> GetListOddNumbers(int num)
        {
            var oddNumbers = new List<int>();

            for (int i = 1; i <= num; i += 2)
            {
                oddNumbers.Add(i);
            }

            return oddNumbers;
        }

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