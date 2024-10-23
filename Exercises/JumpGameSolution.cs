using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    /*
     You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

        Return true if you can reach the last index, or false otherwise.

 

        Example 1:

        Input: nums = [2,3,1,1,4]
        Output: true
        Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.


        Example 2:

        Input: nums = [3,2,1,0,4]
        Output: false
        Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
 

        Constraints:

        1 <= nums.length <= 104
        0 <= nums[i] <= 105*/
    public class JumpGameSolution
    {
        public static bool CanJump(int[] nums)
        {
            // Variable to track the farthest index we can reach
            int farthest = 0;

            // Loop through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // If current index is greater than the farthest reachable index, we can't proceed
                if (i > farthest)
                {
                    return false;
                }

                // Calculate the farthest index we can reach from the current position
                int potentialFarthest = i + nums[i];

                // Using a loop to simulate the max update process
                for (int j = farthest; j <= potentialFarthest; j++)
                {
                    farthest = j;
                }

                // If the farthest index we can reach is beyond or at the last index, return true
                if (farthest >= nums.Length - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
