using System;
using System.Collections.Generic;

class Problem11CountOfLetters
    {
        static void Main(string[] args)
        {
            string[] symbol = Console.ReadLine().Split();
            IDictionary<string, int> letters =
                     new SortedDictionary<string, int>();
            foreach (string letter in symbol)
            {
                if (string.IsNullOrEmpty(letter.Trim()))
                {
                    continue;
                }
                int count;
                if (!letters.TryGetValue(letter, out count))
                {
                    count = 0;
                }
                letters[letter] = count + 1;
            }
            foreach (KeyValuePair<string, int> letterEntry
                      in letters)
            {
                Console.WriteLine(
                      "{0} -> {1}",
                      letterEntry.Key, letterEntry.Value);
            }
    }
    }
