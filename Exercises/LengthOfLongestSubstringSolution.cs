using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class LengthOfLongestSubstringSolution
    {

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            // Initialize the set and the two pointers
            HashSet<char> charSet = new HashSet<char>();
            int maxLength = 0;
            int left = 0;

            // Expand the window by moving the right pointer
            for (int right = 0; right < s.Length; right++)
            {
                // If the character is a duplicate, shrink the window from the left
                while (charSet.Contains(s[right]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }

                // Add the new character and update max length if needed
                charSet.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }


    }
}
