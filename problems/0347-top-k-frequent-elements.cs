public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> kvp = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            int val = kvp.GetValueOrDefault(nums[i], 0);
            kvp[nums[i]] = val + 1;
        }
       
        List<int>[] arr = new List<int>[nums.Length + 1];
       
        foreach(KeyValuePair<int, int> pair in kvp)
        {
            if(arr[pair.Value] is null)
            {
                arr[pair.Value] = new List<int>();
            }

            arr[pair.Value].Add(pair.Key);
        }
        
        int[] res = new int[k];
        
        int counter = 0;
        
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            if(arr[i] is List<int> vals && vals.Count > 0)
            {
                foreach(int num in vals)
                {
                    res[counter++] = num;
                    if (counter == k)
                    {
                        return res;
                    }
                }
            }
        }

        return null;
    }
}
