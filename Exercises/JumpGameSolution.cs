using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
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
