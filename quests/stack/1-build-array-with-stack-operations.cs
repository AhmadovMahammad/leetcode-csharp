// Q1. Build an Array With Stack Operations
public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        // Solution 1 :
        // List<string> ans = [];
        // int numToCheck = 1;

        // for(int i = 0; i < target.Length; i++)
        // {
        //     if(target[i] == numToCheck)
        //     {
        //         ans.Add("Push");
        //     }
        //     else
        //     {
        //         ans.Add("Push");
        //         ans.Add("Pop");
        //         i -= 1;
        //     }

        //     numToCheck += 1;
        // }

        // return ans;



        // Solution 2 :
        List<string> ans = [];
        int numToCheck = 1;

        for(int i = 0; i < target.Length; i++)
        {
            while(target[i] != numToCheck)
            {
                ans.Add("Push");
                ans.Add("Pop");
                numToCheck += 1;
            }

            numToCheck += 1;
            ans.Add("Push");
        }

        return ans;
    }
}
