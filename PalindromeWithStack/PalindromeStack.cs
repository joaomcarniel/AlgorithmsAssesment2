namespace PalindromeWithStack
{
    public class PalindromeStack
    {
        private Stack<char> _word = new Stack<char>();

        public void Push(char c)
        {
            _word.Push(c);
        }

        public char Pop()
        {
            if (!IsEmpty())
            {
                return _word.Pop();
            }
            throw new Exception("Stack is empty");
        }

        public bool IsEmpty()
        {
            return _word.Count == 0;
        }

        public bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
