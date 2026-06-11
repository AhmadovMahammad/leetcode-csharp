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
    }
}
