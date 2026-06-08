// Q3. Max Consecutive Ones
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int currentMax = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                currentMax += 1;
                max = Math.Max(max, currentMax);
            }
            else
            {
                currentMax = 0;
            }
        }

        return max;
    }
}
