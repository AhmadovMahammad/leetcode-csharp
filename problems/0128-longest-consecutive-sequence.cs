public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        Array.Sort(nums);

        int cm = 1;

        int gm = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                continue;
            }

            if (nums[i] == nums[i - 1] + 1)
            {
                cm += 1;
            }
            else
            {
                gm = Math.Max(gm, cm);
                cm = 1;
            }
        }

        return Math.Max(gm, cm);
    }
}