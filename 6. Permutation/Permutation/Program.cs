namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            Console.WriteLine($"Input {n} array elements as integers for the first array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i} - element: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nInput {n} array elements as integers for the first array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i} - element: ");
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nElements in first array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", firstArray[i]);
            }

            Console.WriteLine("\nElements in second array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", secondArray[i]);
            }

            if (firstArray.Sum() == secondArray.Sum())
                Console.WriteLine("\n\nyes".ToUpper());
            else
                Console.WriteLine("\n\nno".ToUpper());
        }
    }
}
