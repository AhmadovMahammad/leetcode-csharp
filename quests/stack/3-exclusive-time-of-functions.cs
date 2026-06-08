// Q3. Exclusive Time of Functions
public class Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        int[] ans = new int[n];
        Stack<int> callStack = new Stack<int>();
        int prevTime = 0;

        foreach(string log in logs)
        {
            string[] parts = log.Split(':');
            int functionId = int.Parse(parts[0]);
            int timestamp = int.Parse(parts[2]);

            if(parts[1][0] == 's')
            {
                if(callStack.Count > 0)
                {
                    ans[callStack.Peek()] += timestamp - prevTime;
                }

                callStack.Push(functionId);
                prevTime = timestamp;
            }
            else
            {
                ans[functionId] += timestamp - prevTime + 1;
                callStack.Pop();
                prevTime = timestamp + 1;
            }
        }

        return ans;
    }
}
