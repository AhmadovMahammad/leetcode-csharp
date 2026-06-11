public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (t.Length != s.Length)
        {
            return false;
        }

        int[] l = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            l[t[i] - a] += 1;
            l[s[i] - a] -= 1;
        }

        for(int i = 0; i < l.Length; i++)
        {
            if(l[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}
