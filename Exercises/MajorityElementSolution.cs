using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class MajorityElementSolution
    {/*
      Given an array nums of size n, return the majority element.

        The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

        Example 1:

        Input: nums = [3,2,3]
        Output: 3
        Example 2:

        Input: nums = [2,2,1,1,1,2,2]
        Output: 2
 

        Constraints:

        n == nums.length
        1 <= n <= 5 * 104
        -109 <= nums[i] <= 109
 */
        public static int MajorityElement(int[] nums)
        {

            int[] numbers = nums;
           
            int majorityCount = numbers.Length / 2;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }

                }
                // If count exceeds majorityCount, return the element
                if (count > majorityCount)
                {
                    return numbers[i];
                }

            }
            return -1; // This line should never be reached as per the problem assumption



        }
    }
}
