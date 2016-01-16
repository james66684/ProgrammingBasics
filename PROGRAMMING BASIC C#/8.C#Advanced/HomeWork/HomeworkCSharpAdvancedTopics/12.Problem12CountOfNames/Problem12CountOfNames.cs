using System;
using System.Collections.Generic;

    class Problem12CountOfNames
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();
            IDictionary<string, int> words =
                     new SortedDictionary<string, int>();
            foreach (string item in word)
            {
                if (string.IsNullOrEmpty(item.Trim()))
                {
                    continue;
                }
                int count;
                if (!words.TryGetValue(item, out count))
                {
                    count = 0;
                }
                words[item] = count + 1;
            }
            foreach (KeyValuePair<string, int> itemEntry
                      in words)
            {
                Console.WriteLine(
                      "{0} -> {1}",
                      itemEntry.Key, itemEntry.Value);
            }
        }
    }

