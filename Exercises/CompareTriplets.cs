using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    internal class CompareTriplets
    {

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    aliceScore++;
                }
                else if (a[i] < b[i])
                {
                    bobScore++;
                }
                // If a[i] == b[i], no points are added, so no else block is needed
            }

            // Return the results as a list
            return new List<int> { aliceScore, bobScore };
        }

    }
}
