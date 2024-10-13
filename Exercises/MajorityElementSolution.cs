using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class MajorityElementSolution
    {
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
