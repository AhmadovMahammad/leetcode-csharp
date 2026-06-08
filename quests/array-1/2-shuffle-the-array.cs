// Q2. Shuffle the Array
public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[n * 2];

        for(int i = 0; i < n; i++)
        {
            ans[i * 2] = nums[i];
            ans[(i * 2) + 1] = nums[i + n];
        }

        return ans;
    }
}
