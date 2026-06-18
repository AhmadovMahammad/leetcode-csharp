public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> kvp = new Dictionary<int, int>();

        for(int i = 1; i <= numbers.Length; i++)
        {
            if(kvp.TryGetValue(target - numbers[i - 1], out int index))
            {
                return [index, i];
            }

            kvp[numbers[i - 1]] = i;
        }

        return null;
    }
}
