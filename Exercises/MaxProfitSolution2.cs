using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exercises
{
    public class MaxProfitSolution2
    {

        public static int MaxProfit(int[] prices)
        {
            int totalProfit = 0;

            // Iterate through the prices array
            for (int i = 1; i < prices.Length; i++)
            {
                // If the price today is higher than yesterday, buy yesterday and sell today
                if (prices[i] > prices[i - 1])
                {
                    totalProfit = totalProfit + prices[i] - prices[i - 1];
                }
            }

            return totalProfit;
        }
    }
}
