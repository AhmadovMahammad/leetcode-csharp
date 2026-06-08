// Q1. Set Mismatch
public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        // Solution 1 : did not work.

        // nums.Sort();

        // int prev = nums[0];

        // for(int i = 1; i < nums.Length; i++)
        // {
        //     int val = nums[i];

        //     if(val == prev)
        //     {
        //         return new int[] { val, nums[0] == 1 ? val + 1 : 1 };
        //     }

        //     prev = val;
        // }

        // return null;



        // Solution 2 :

        int n = nums.Length;
        int sumToN = (n + 1) * n / 2;
        int uniqueSum = 0;
        int repeatedNum = 0;

        HashSet<int> uniqueNumbers = [];

        for(int i = 0; i < n; i++)
        {
            if(uniqueNumbers.Add(nums[i]))
            {
                uniqueSum += nums[i];
            }
            else
            {
                repeatedNum = nums[i];
            }
        }

        return new int[] { repeatedNum, sumToN - uniqueSum };
    }
}
