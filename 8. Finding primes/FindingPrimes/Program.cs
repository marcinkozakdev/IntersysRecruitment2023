namespace FindingPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of test cases T = ");
            int t = int.Parse(Console.ReadLine());
            int testCase = 0;

            while (testCase < t)
            {
                for (int i = 1; i <= t; i++)
                {
                    bool primeNumber = true;
                    int result = 0;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"\n{i} - TEST CASE:");
                    Console.ResetColor();
                    Console.WriteLine("Enter numbers in the interval [m,n]:");
                    Console.Write("Enter m: ");
                    int m = int.Parse(Console.ReadLine());

                    Console.Write("Enter n: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    if ((m < 1) || (n < 1) || (m > n) || (n > 1000000000) || ((n - m) > 100000))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("You provided incorrect data!");
                        Console.ResetColor();
                        Environment.Exit(0);
                    };

                    for (int k = m; k <= n; k++)
                    {
                        for (int j = 2; j < k; j++)
                        {
                            if (k % j == 0)
                                primeNumber = false;
                        }

                        if ((primeNumber == true) && (k > 1))
                            result++;

                        else primeNumber = true;
                    }

                    Console.Write($"The number of prime numbers in the interval [{m},{n}] is: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(result);
                    Console.ResetColor();
                }
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
