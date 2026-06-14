public class Solution
{
    private const int NumLength = 3;

    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0)
        {
            return string.Empty;
        }
        
        StringBuilder sb = new StringBuilder(strs.Count * 10);

        foreach (string s in strs)
        {
            sb.Append($"{s.Length:D3}");
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return [];
        }
        
        List<string> ans = new List<string>();

        ReadOnlySpan<char> span = s.AsSpan();

        int i = 0;

        while (i < span.Length)
        {
            ReadOnlySpan<char> lengthSpan = span.Slice(i, NumLength);
            
            int digit = int.Parse(lengthSpan);
            
            ans.Add(span.Slice(i + NumLength, digit).ToString());

            i += NumLength + digit;
        }
        
        return ans;
    }
}
