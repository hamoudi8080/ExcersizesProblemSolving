using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize.Exercises
{
    internal class WeightSort
    {
        // Function to sum the digits of a number represented as a string
    private static int GetWeight(string number)
    {
        return number.Sum(c => c - '0'); // Convert each char to int and sum the digits
    }

    // Main function to sort the weights
    public static string orderWeight(string strng)
    {
        // Split the input string into numbers, removing any extra whitespaces
        var numbers = strng.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Sort the numbers based on their weight and string value (alphabetical order for ties)
        var sortedNumbers = numbers
            .OrderBy(n => GetWeight(n))      // First sort by the sum of digits (weight)
            .ThenBy(n => n)                  // If weights are equal, sort by the string value
            .ToArray();

        // Join the sorted numbers into a single string and return the result
        return string.Join(" ", sortedNumbers);
    }
    }
}
