using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class Sentence_Similarity
    {
        public static bool AreSentencesSimilar(string sentence1, string sentence2)
        {
            // Split sentences into words
            var words1 = sentence1.Split(' ');
            var words2 = sentence2.Split(' ');

            int len1 = words1.Length;
            int len2 = words2.Length;

            // Step 1: Find common prefix
            int i = 0;
            while (i < len1 && i < len2 && words1[i] == words2[i])
            {
                i++;
            }

            // Step 2: Find common suffix
            int j = 0;
            while (j < (len1 - i) && j < (len2 - i) && words1[len1 - 1 - j] == words2[len2 - 1 - j])
            {
                j++;
            }

            // Step 3: Check if the remaining words are valid
            return i + j >= len1 || i + j >= len2;
        }

    }
}
