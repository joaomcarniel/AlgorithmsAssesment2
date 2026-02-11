// João Marcos Carniel (20082653)
// Alba Ciardini Utiel (20056357)

// Insertion: O(1) average per word
// Search by key: O(1)
// Search by synonym: O(n * m) where n = number of words, m = synonyms per word
// Sorting synonyms: O(m log m)

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> synonymDict = new Dictionary<string, List<string>>();

        // Read 5 words with 4 synonyms each
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Word {i}");
            Console.Write("Enter a word: ");
            string word = (Console.ReadLine() ?? string.Empty).ToLower();

            if (synonymDict.ContainsKey(word))
            {
                Console.WriteLine("This word already exists. Skipping...\n");
                i--;
                continue;
            }

            List<string> synonyms = new List<string>();

            for (int j = 1; j <= 4; j++)
            {
                Console.Write($"Enter synonym {j}: ");
                string synonym = (Console.ReadLine() ?? string.Empty).ToLower();
                synonyms.Add(synonym);
            }

            synonymDict.Add(word, synonyms);
            Console.WriteLine();
        }

        Console.WriteLine("All words in the dictionary:");
        foreach (string key in synonymDict.Keys)
        {
            Console.WriteLine(key);
        }

        while (true)
        {
            Console.Write("\nEnter a word to find its synonyms: ");
            string searchWord = (Console.ReadLine() ?? string.Empty).ToLower();

            if (synonymDict.ContainsKey(searchWord))
            {
                var foundSynonyms = synonymDict[searchWord].OrderBy(s => s).ToList();

                Console.WriteLine($"\nSynonyms for '{searchWord}' (sorted):");
                foreach (string syn in foundSynonyms)
                {
                    Console.WriteLine(syn);
                }
            }
            else
            {
                Console.WriteLine("Word not found in the dictionary.");
            }
            Console.WriteLine("Would you like to try again? [y/n]");
            string choice = Console.ReadLine()?.ToLower();

            if (choice == "n") break;
        }
    }
}