//João Marcos Carniel (20082653)
// Alba

// Insertion Complexity: O(1) average per word
// Search by key: O(1)
// Search by synonym: O(n * m) where n = number of words, m = synonyms per word
// Sorting synonyms: O(m log m)

class Program
{
    static void Main()
    {

        Dictionary<string, List<string>> synonymDict = new Dictionary<string, List<string>>();


        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Word " + i);
            Console.Write("Enter a word: ");
            string word = (Console.ReadLine() ?? string.Empty).ToLower();

            List<string> synonyms = new List<string>();

            for (int j = 1; j <= 4; j++)
            {
                Console.Write("Enter synonym " + j + ": ");
                string synonym = Console.ReadLine() ?? string.Empty;
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


        Console.WriteLine("\nEnter a word to find its synonyms:");
        string searchWord = (Console.ReadLine() ?? string.Empty).ToLower();


        if (synonymDict.ContainsKey(searchWord))
        {
            List<string> foundSynonyms = synonymDict[searchWord];


            foundSynonyms.Sort();

            Console.WriteLine("\nSynonyms for '" + searchWord + "' (sorted):");
            foreach (string syn in foundSynonyms)
            {
                Console.WriteLine(syn);
            }
        }
        else
        {
            bool foundAsSynonym = false;
            string originalWord = "";

            foreach (string key in synonymDict.Keys)
            {
                List<string> syns = synonymDict[key];
                foreach (string syn in syns)
                {
                    if (syn.ToLower() == searchWord)
                    {
                        foundAsSynonym = true;
                        originalWord = key;
                        break;
                    }
                }
                if (foundAsSynonym)
                    break;
            }

            if (foundAsSynonym)
            {
                Console.WriteLine("\n'" + searchWord + "' is a synonym of '" + originalWord + "'");
                Console.WriteLine("\nOriginal word: " + originalWord);
                Console.WriteLine("Other synonyms:");

                List<string> otherSynonyms = synonymDict[originalWord];
                otherSynonyms.Sort();

                foreach (string syn in otherSynonyms)
                {
                    if (syn.ToLower() != searchWord)
                    {
                        Console.WriteLine(syn);
                    }
                }
            }
            else
            {
                Console.WriteLine("Word not found in the dictionary.");
            }
        }
    }
}