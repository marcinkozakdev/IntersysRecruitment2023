using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            bool isPalindrome = true;

            Console.Write("Enter a string to check palindrome: ");
            text = Console.ReadLine().ToLower();

            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            text = rgx.Replace(text, "").Replace(" ", "");

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("yes".ToUpper());
            else
                Console.WriteLine("no".ToUpper());
        }
    }
}

