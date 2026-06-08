// Q3. Find All Numbers Disappeared in an Array
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;

        for(int i = 0; i < n; i++)
        {
            int val = Math.Abs(nums[i]);

            if(nums[val - 1] > 0)
            {
                nums[val - 1] = -(nums[val - 1]);
            }
        }

        List<int> ans = [];

        for(int i = 0; i < n; i++)
        {
            if(nums[i] > 0)
            {
                ans.Add(i + 1);
            }
        }

        return ans;
    }
}
