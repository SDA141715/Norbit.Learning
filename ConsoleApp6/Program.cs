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

            var square = GetSquare(num);

            foreach (var row in square)
            {
                Console.WriteLine(string.Join("", row));
            }

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

        static List<List<string>> GetSquare(int size)
        {
            List<List<string>> square = new List<List<string>>();

            for (int i = 0; i < size; i++)
            {
                List<string> rowSquare = new List<string>();

                for (int j = 0; j < size; j++)
                {
                    rowSquare.Add("+");
                }

                square.Add(rowSquare);
            }

            return square;
        }

    }
}
