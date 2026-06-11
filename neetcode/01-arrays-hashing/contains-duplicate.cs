public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Solution 1 : Time limit exceeded

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     int valToCheck = nums[i];

        //     for(int j = i + 1; j < nums.Length; j++)
        //     {
        //         if(valToCheck == nums[j])
        //         {
        //             return true;
        //         }
        //     }
        // }

        // return false;

        // Solution 2 : 

        HashSet<int> set = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(!set.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}
