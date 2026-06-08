// Q2. How Many Numbers Are Smaller Than the Current Number
public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];
        Dictionary<int, int> kvp = [];

        for(int i = 0; i < n; i++)
        {
            int countSmaller = 0;

            if(kvp.TryGetValue(nums[i], out countSmaller))
            {
                ans[i] = countSmaller;
            }
            else
            {
                for(int j = 0; j < n; j++)
                {
                    if(i != j && nums[j] < nums[i])
                    {
                        countSmaller += 1;
                    }
                }

                kvp[nums[i]] = countSmaller;
                ans[i] = countSmaller;
            }
        }

        return ans;
    }
}
