public class Solution
{
    public bool IsPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            if (!char.IsLetterOrDigit(s[l]))
            {
                l += 1;
                continue;
            }

            if (!char.IsLetterOrDigit(s[r]))
            {
                r -= 1;
                continue;
            }

            if (char.ToLowerInvariant(s[l]) != char.ToLowerInvariant(s[r]))
            {
                return false;
            }

            l += 1;
            r -= 1;
        }

        return true;
    }
}
