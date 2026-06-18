public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }
 
        // Solution 1 : Sorting.


        // Array.Sort(nums);

        // int cm = 1;

        // int gm = 1;

        // for (int i = 1; i < nums.Length; i++)
        // {
        //     if (nums[i] == nums[i - 1])
        //     {
        //         continue;
        //     }

        //     if (nums[i] == nums[i - 1] + 1)
        //     {
        //         cm += 1;
        //     }
        //     else
        //     {
        //         gm = Math.Max(gm, cm);
        //         cm = 1;
        //     }
        // }

        // return Math.Max(gm, cm);


        // Solution 2 : 

        HashSet<int> set = new HashSet<int>(nums);
    
        int gm = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            if(!set.Contains(nums[i] - 1))
            {
                int check = nums[i] + 1;
                
                int cm = 1;

                while(set.Contains(check))
                {
                    cm += 1;
                    check += 1;
                }

                gm = Math.Max(gm, cm);
            }
        }

        return gm;
    }
}
