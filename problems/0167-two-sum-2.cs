public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        // Solution 1 : 

        // Dictionary<int, int> kvp = new Dictionary<int, int>();

        // for(int i = 1; i <= numbers.Length; i++)
        // {
        //     if(kvp.TryGetValue(target - numbers[i - 1], out int index))
        //     {
        //         return [index, i];
        //     }

        //     kvp[numbers[i - 1]] = i;
        // }

        // return null;


        // Solution 2 : 

        int l = 0;
        int r = numbers.Length - 1;

        while(l < r)
        {
            int sum = numbers[l] + numbers[r];
            
            if(sum > target)
            {
                r -= 1;
            }
            else if(sum < target)
            {
                l += 1;
            }
            else
            {
                return new int[] { l + 1, r + 1 };
            }
        }

        return null;
    }
}
