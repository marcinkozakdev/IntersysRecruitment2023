namespace CommonDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = EnterNumberOfNumbers();
            int[] numbers = EnterNumbers(n); 
            DisplayInputData(numbers, n);
            var sortedInputData = SortedInputData(numbers);
            var resultCountNumber = CountOccurances(sortedInputData);
            DisplayOutputData(resultCountNumber);
        }

        private static int EnterNumberOfNumbers()
        {
            int x = 2;
            int y = 20;
            int n;

            Headline("Enter input data: ");
            Console.Write($"Enter number of numbers in the interval [{x}, {y}]: ");
            n = int.Parse(Console.ReadLine());

            return n;
        }

        private static int[] EnterNumbers(int n)
        {
            int[] numbers = new int[n];

            if (n >= 2 && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}: ");
                    var number = int.Parse(Console.ReadLine());
                    numbers[i] = number;
                }
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
            return numbers;
        }

        private static string SortedInputData(int[] numbers)
        {
            var sortedResult = String.Join(" ", numbers.OrderByDescending(x=>x));
            return sortedResult;
        }

        private static Dictionary<char, int> CountOccurances(string text)
        {
            var countOccurances = new Dictionary<char, int>();

            foreach (var mark in text)
            {
                if (mark != ' ')
                {
                    if (!countOccurances.ContainsKey(mark))
                        countOccurances.Add(mark, 1);
                    else
                        countOccurances[mark]++;
                }
            }
            return countOccurances;
        }

        private static string DisplayInputData(int[] numbers, int n)
        {
            Headline("Input: ");
            Console.WriteLine(n);
            var result = String.Join(" ", numbers);
            Console.WriteLine(result);
            return result;
        }


        private static void DisplayOutputData(Dictionary<char, int> result)
        {
            Headline("Output: ");

            var maxOccurance = result
                .OrderByDescending(x => x.Value)
                .FirstOrDefault();

            Console.WriteLine(maxOccurance.Key);
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

