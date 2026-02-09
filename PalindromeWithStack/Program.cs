using PalindromeWithStack;

class Program
{
    static void Main()
    {
        while (true)
        {
            PalindromeStack stack = new PalindromeStack();
            Console.WriteLine("=******=");
            Console.WriteLine("=******=");
            Console.WriteLine("Welcome to the Palindrome Checker Program");
            Console.WriteLine("Write a word: ");
            var word = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(word))
            {
                word = word.ToLower();
                foreach (char i in word)
                {
                    stack.Push(i);
                }

                var isPalindrome = stack.IsPalindrome(word);
                Console.WriteLine($"The word {word} is a Palindrome? --->>> {isPalindrome}");
            }

            Console.WriteLine("Close Program? [y/n]");
            if (Console.ReadLine() == "y") break;
        }
    }
}
