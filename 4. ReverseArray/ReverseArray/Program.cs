namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");

            int n;
            Int32.TryParse(Console.ReadLine(), out n);
            int[] array = new int[n];

            Console.WriteLine("\nEnter array elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(array);
            Console.WriteLine($"\nReversed array: " + String.Join(' ', array));
        }
    }
}
