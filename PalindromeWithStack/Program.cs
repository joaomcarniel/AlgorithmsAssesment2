// João Marcos Carniel (20082653)
// Alba Ciardini Utiel (20056357)

/*
Complexity Explanation:

This program checks whether a word or sentence is a palindrome using a Stack<char>.

Step 1 – Preparing the word:
The method PrepareWord removes spaces and punctuation using:
    .Where(char.IsLetterOrDigit)
and then converts everything to lowercase.

This operation scans each character of the string once.
If the word has n characters, this step runs in O(n) time.

Step 2 – Pushing characters into the stack:
In the IsPalindrome method, each character of the prepared word is pushed into a stack.
Since we push n characters, this operation takes O(n) time.

Step 3 – Comparing characters:
We iterate through the word again and pop one character from the stack for each letter.
Each pop operation is O(1), and we perform it n times.
Therefore, this step also runs in O(n) time.

Overall Time Complexity:
O(n) + O(n) + O(n) = O(n)

Even though we run the loop many times, they are sequential operations,
so the total complexity remains linear.

Space Complexity:
The stack stores all n characters of the word.
Therefore, the extra space required is O(n).

There are no additional complex data structures created during execution,
only the stack and the prepared string.

Conclusion:
The algorithm is efficient because its time grows linearly
with the size of the input string.
*/
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
            string preparedWord = PrepareWord(word);

            //This bool variable stores the answer if the word is a palindrome or not
            bool isPalindrome = IsPalindrome(preparedWord);

            Console.WriteLine($"The word {word} is a Palindrome? --->>> {isPalindrome}");

            //Client decides with it wants to continue or not
            Console.WriteLine("Close Program? [y/n]");
            if (Console.ReadLine() == "y") break;
        }
    }

    static string PrepareWord(string word)
    {
        return new string(word
                .Where(char.IsLetterOrDigit)
                .ToArray())
                .ToLower();
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
