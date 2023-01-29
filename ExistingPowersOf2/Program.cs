namespace ExistingPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of numbers: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("\nEnter the numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

            int result = 0;
            List<int> results = new List<int>();

            foreach (int number in numbers)
                result |= number;

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;
                if (IsPow2(result & power) == true)
                    results.Add(power);
            }

            Console.Write("Results: ");
            Console.WriteLine(String.Join(", ", results));
            Console.ReadKey();
        }

        public static bool IsPow2(int value) 
            => (value & (value - 1)) == 0 && value > 0;
    }
}