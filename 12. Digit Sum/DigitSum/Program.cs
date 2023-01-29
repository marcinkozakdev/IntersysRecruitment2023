namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = EnterNumberOfNumbers();
            int[] numbers = EnterNumbers(n);
            DisplayInputData(numbers, n);
            int[] digitSumArray = SumOfDigitsOfValues(numbers, n);
            DisplayIndexOfMaxValue(digitSumArray);
        }

        private static int EnterNumberOfNumbers()
        {
            int x = 2;
            int y = 20;
            int n;

            Headline("Enter input data: ");
            Console.Write($"Enter number of numbers: ");
            n = int.Parse(Console.ReadLine());

            return n;
        }

        private static int[] EnterNumbers(int n)
        {
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}: ");
                var number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    numbers[i] = number;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("You provided incorrect data!");
                    Console.WriteLine("----------------------------");
                    Console.ResetColor();
                    Environment.Exit(0);
                }
            }
            return numbers;
        }

        private static int[] SumOfDigitsOfValues(int[] numbers, int n)
        {
            int result = 0;
            int i = 0;
            int[] sum = new int[n];
            foreach (int number in numbers)
            {
                result = number.ToString().Sum(n => Convert.ToInt32(n.ToString()));
                sum[i] = result;
                i++;
            }

            return sum;
        }

        private static string DisplayInputData(int[] numbers, int n)
        {
            Headline("Input: ");
            Console.WriteLine(n);
            var result = String.Join(" ", numbers);
            Console.WriteLine(result);
            return result;
        }

        private static void DisplayIndexOfMaxValue(int[] sum)
        {
            Headline("Output: ");

            int index = 0;
            for (int i = 1; i < sum.Length; i++)
                if (sum[i] > sum[index])
                    index = i;

            Console.WriteLine(index);
        }

        private static void Headline(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----------------");
            Console.WriteLine($"{text.ToUpper()}");
            Console.WriteLine("-----------------");
            Console.ResetColor();
        }
    }
}