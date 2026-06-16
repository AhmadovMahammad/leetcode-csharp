public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        for(int i = 0; i < n; i++)
        {
            prefix[i] = i == 0 ? nums[i] : nums[i] * prefix[i - 1];
        }

        for(int i = n - 1; i >= 0; i--)
        {
            suffix[i] = i == n - 1 ? nums[i] : nums[i] * suffix[i + 1];
        }

        for(int i = 0; i < n; i++)
        {
            nums[i] = i switch
            {
                0 => suffix[i + 1],
                int index when index == n - 1 => prefix[i - 1],
                _ => nums[i] = prefix[i - 1] * suffix[i + 1]
            };
        }

        return nums;
    }
}
