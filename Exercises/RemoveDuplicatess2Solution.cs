using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class RemoveDuplicatess2Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0; // Pointer for the position of the modified array
            int count = 1; // Count occurrences of the current number

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[j - 1])
                {
                    // If the current number is the same as the previous
                    if (count < 2)
                    {
                        // If we have not added it twice yet
                        i++;
                        nums[i] = nums[j];
                        count++;
                    }
                }
                else
                {
                    // New number found, reset count
                    i++;
                    nums[i] = nums[j];
                    count = 1; // Reset count to 1 for the new number
                }
            }

            // The length of the modified array is i + 1
            return i + 1;
        }
    }
}
