public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        ArrayEqualityComparer com = new ArrayEqualityComparer();
        
        Dictionary<int[], IList<string>> kvp = new Dictionary<int[], IList<string>>(com);

        foreach (string s in strs)
        {
            int[] l = new int[26];

            foreach (char c in s)
            {
                l[c - a] += 1;
            }

            if (!kvp.TryGetValue(l, out var output))
            {
                output = new List<string>();
                kvp[l] = output;
            }

            output.Add(s);
        }

        return kvp.Values.ToList();
    }

    public class ArrayEqualityComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[]? x, int[]? y)
        {
            if (x == null || y == null)
            {
                return x == y;
            }

            return x.Length == y.Length && x.SequenceEqual(y);
        }

        public int GetHashCode(int[] obj)
        {
            HashCode hashCode = new HashCode();

            foreach (int val in obj)
            {
                hashCode.Add(val);
            }

            return hashCode.ToHashCode();
        }
    }
}
