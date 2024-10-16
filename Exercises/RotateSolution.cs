using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    /*
     Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

 

    Example 1:

    Input: nums = [1,2,3,4,5,6,7], k = 3
    Output: [5,6,7,1,2,3,4]
    Explanation:
    rotate 1 steps to the right: [7,1,2,3,4,5,6]
    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    rotate 3 steps to the right: [5,6,7,1,2,3,4]
    Example 2:

    Input: nums = [-1,-100,3,99], k = 2
    Output: [3,99,-1,-100]
    Explanation: 
    rotate 1 steps to the right: [99,-1,-100,3]
    rotate 2 steps to the right: [3,99,-1,-100]
 

    Constraints:

    1 <= nums.length <= 105
    -231 <= nums[i] <= 231 - 1
    0 <= k <= 105
 

    Follow up:

    Try to come up with as many solutions as you can. There are at least three different ways to solve this problem.
    Could you do it in-place with O(1) extra space?*/
    public class RotateSolution
    {
        public static int[] Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n;  // In case k is greater than the length of the array

            // Step 1: Reverse the entire array
            Reverse(nums, 0, n - 1);
            // Step 2: Reverse the first k elements
            Reverse(nums, 0, k - 1);
            // Step 3: Reverse the remaining n - k elements
            Reverse(nums, k, n - 1);

            return nums;
        }

        // Helper function to reverse a portion of the array
        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
