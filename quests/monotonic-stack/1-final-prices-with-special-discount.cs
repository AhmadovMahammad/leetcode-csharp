// Q1. Final Prices With a Special Discount in a Shop
public class Solution 
{
    public int[] FinalPrices(int[] prices) 
    {
        // Solution 1 : 

        // for(int i = 0; i < prices.Length; i++)
        // {
        //     int val = prices[i];

        //     for(int j = i + 1; j < prices.Length; j++)
        //     {
        //         if(prices[j] <= prices[i])
        //         {
        //             prices[i] -= prices[j];
        //             break;
        //         }
        //     }
        // }

        // return prices;



        // Solution 2 : 

        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < prices.Length; i++)
        {
            while(stack.Count != 0 && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }

            stack.Push(i);
        }

        return prices;
    }
}