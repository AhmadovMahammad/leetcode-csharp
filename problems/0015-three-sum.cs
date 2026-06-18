public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    if(i != j && j != k && i != k && nums[i] + nums[j] + nums[k] == 0)
                    {
                        if (!ans.Any(a => a[0] == nums[i] && a[1] == nums[j] && a[2] == nums[k]))
                        {
                            ans.Add([nums[i], nums[j], nums[k]]);
                        }
                    }
                }
            }
        }

        return ans;
    }
}
