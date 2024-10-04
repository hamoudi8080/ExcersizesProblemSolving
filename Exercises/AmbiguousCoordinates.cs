using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class AmbiguousCoordinates
    {
        public static IList<string> AmbiguousCoordinatesFunction(string s)
        {
            var result = new List<string>();
            // Remove the parentheses
            string digits = s.Substring(1, s.Length - 2);

            // Loop through each possible split point
            for (int i = 1; i < digits.Length; i++)
            {
                string left = digits.Substring(0, i);
                string right = digits.Substring(i);

                var leftParts = GenerateValidNumbers(left);
                var rightParts = GenerateValidNumbers(right);

                // Combine valid left and right parts into coordinates
                foreach (var l in leftParts)
                {
                    foreach (var r in rightParts)
                    {
                        result.Add($"({l}, {r})");
                    }
                }
            }

            return result;
        }

        // Helper function to generate all valid representations of a string as a number
        private static IList<string> GenerateValidNumbers(string s)
        {
            var validNumbers = new List<string>();

            // If the string is just a single digit or doesn't start with '0', it's valid as is
            if (IsValidInteger(s))
            {
                validNumbers.Add(s);
            }

            // Try inserting a decimal point in all possible positions
            for (int i = 1; i < s.Length; i++)
            {
                string integerPart = s.Substring(0, i);
                string fractionalPart = s.Substring(i);

                // Ensure that both parts are valid (e.g., no leading zeros, no trailing zeros after decimal)
                if (IsValidInteger(integerPart) && IsValidFraction(fractionalPart))
                {
                    validNumbers.Add($"{integerPart}.{fractionalPart}");
                }
            }

            return validNumbers;
        }

        // Check if the string is a valid integer (no leading zeros unless it's '0')
        private static bool IsValidInteger(string s)
        {
            return s.Length == 1 || s[0] != '0';
        }

        // Check if the string is a valid fractional part (no trailing zeros)
        private static bool IsValidFraction(string s)
        {
            return s[s.Length - 1] != '0';
        }
    }
}
