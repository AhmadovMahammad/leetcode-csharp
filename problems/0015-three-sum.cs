public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // Solution 1 : time limit exceeded, Big O(n^3)

        // IList<IList<int>> ans = new List<IList<int>>();

        // Array.Sort(nums);

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     for(int j = i + 1; j < nums.Length; j++)
        //     {
        //         for(int k = j + 1; k < nums.Length; k++)
        //         {
        //             if(nums[i] + nums[j] + nums[k] == 0)
        //             {
        //                 if (!ans.Any(a => a[0] == nums[i] && a[1] == nums[j] && a[2] == nums[k]))
        //                 {
        //                     ans.Add([nums[i], nums[j], nums[k]]);
        //                 }
        //             }
        //         }
        //     }
        // }

        // return ans;


        // Solution 2 : 
        
        IList<IList<int>> ans = new List<IList<int>>();

        HashSet<int> seen = new HashSet<int>();

        HashSet<ValueTuple<int, int, int>> uniqueTriplets = new HashSet<ValueTuple<int, int, int>>();

        for (int i = 0; i <= nums.Length - 3; i++)
        {
            int target = -nums[i];

            seen.Clear();

            for (int j = i + 1; j < nums.Length; j++)
            {
                int required = target - nums[j];

                if (seen.Contains(required))
                {
                    int min = Math.Min(nums[i], Math.Min(required, nums[j]));

                    int max = Math.Max(nums[i], Math.Max(required, nums[j]));

                    int mid = nums[i] + required + nums[j] - min - max;

                    ValueTuple<int, int, int> vt = ValueTuple.Create(min, mid, max);

                    if (uniqueTriplets.Add(vt))
                    {
                        ans.Add([nums[i], required, nums[j]]);
                    }
                }

                seen.Add(nums[j]);
            }
        }

        return ans;
    }
}
