// João Marcos Carniel (20082653)
// Alba Ciardini Utiel (20056357)

// Time Complexity: O(n) — each character is pushed and popped once
// Space Complexity: O(n) — stack stores n characters
class Program
{
    static void Main()
    {
        //This loop goes on until client wants to exit.
        while (true)
        {
            Console.WriteLine("=******=");
            Console.WriteLine("=******=");
            Console.WriteLine("Welcome to the Palindrome Checker Program");
            Console.WriteLine("Write a word: ");
            var word = Console.ReadLine() ?? string.Empty;

            // this operation deletes empty spaces, punctuation and ignore case
            string preparedWord = new string(word
                .Where(char.IsLetterOrDigit)
                .ToArray())
                .ToLower();

            //This bool variable stores the answer if the word is a palindrome or not
            bool isPalindrome = IsPalindrome(preparedWord);

            Console.WriteLine($"The word {word} is a Palindrome? --->>> {isPalindrome}");

            //Client decides with it wants to continue or not
            Console.WriteLine("Close Program? [y/n]");
            if (Console.ReadLine() == "y") break;
        }
    }

    static bool IsPalindrome(string word)
    {
        Stack<char> stack = new Stack<char>();

        // This foreach pushes all the characters into the stack
        foreach (char c in word)
        {
            stack.Push(c);
        }

        // This foreach compares characters by popping from the stack
        foreach (char c in word)
        {
            if (c != stack.Pop())
            {
                return false;
            }
        }

        return true;
    }
}
