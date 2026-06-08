// Q1. Final Prices With a Special Discount in a Shop
public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        // Solution 1 :

        for(int i = 0; i < prices.Length; i++)
        {
            int val = prices[i];

            for(int j = i + 1; j < prices.Length; j++)
            {
                if(prices[j] <= prices[i])
                {
                    prices[i] = prices[i] - prices[j];
                    break;
                }
            }
        }

        return prices;
    }
}
