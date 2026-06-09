public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> kvp = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(kvp.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            kvp[nums[i]] = i;
        }

        return [-1, -1];    
    }
}
