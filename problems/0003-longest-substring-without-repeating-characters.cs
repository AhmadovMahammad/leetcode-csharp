public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // Solution 1 : did not work (because, we cut the sliding window from letter that exists before, but there would be non existed chars)
        // example: "dvdf" -> for dv part, max is 2, then d again comes, and i cut window and start from new window, second occurrence of d, so i lost v letter. 

        // int max = 0;
        // HashSet<char> set = new HashSet<char>();

        // for(int i = 0; i < s.Length; i++)
        // {
        //     if(set.Contains(s[i]))
        //     {
        //         max = Math.Max(max, set.Count);
        //         set.Clear();
        //     }

        //     set.Add(s[i]);
        // }

        // return Math.Max(max, set.Count);


        // Solution 2 : 
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (set.Contains(s[i]))
            {
                set.Remove(s[left]);
                left += 1;
            }

            max = Math.Max(max, i - left + 1);

            set.Add(s[i]);
        }

        return max;


        // Solution 3 : 

        Dictionary<char, int> kvp = new Dictionary<char, int>();
        int left = 0;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (kvp.TryGetValue(s[i], out int index))
            {
                for (int j = left; j <= index; j++)
                {
                    kvp.Remove(s[j]);
                }

                left = index + 1;
            }

            max = Math.Max(max, i - left + 1);
            kvp[s[i]] = i;
        }

        return max;
    }
}
