using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class RemoveDuplicatessSolution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // If the array is empty or has only one element, return its length
            if (nums.Length == 0) return 0;

            // Pointer for the position of the unique elements
            int k = 1;

            // Traverse the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // If the current element is different from the previous unique element
                if (nums[i] != nums[i - 1])
                {
                    // 1 != 0 false   1 = 1
                    // 2 != 1 true    2 = 1  true cause it is not equal



                    nums[k] = nums[i]; // Move the unique element to the front
                    k++; // Increment the count of unique elements
                }
            }

            return k; // Return the number of unique elements
        }




    }
}
