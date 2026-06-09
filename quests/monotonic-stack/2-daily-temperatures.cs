// Q2. Daily Temperatures
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count != 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int index = stack.Pop();
                temperatures[index] = i - index;
            }

            stack.Push(i);
        }

        while (stack.Count != 0)
        {
            temperatures[stack.Pop()] = 0;
        }

        return temperatures;
    }
}