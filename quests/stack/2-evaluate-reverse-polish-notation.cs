// Q2. Evaluate Reverse Polish Notation
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        if(tokens.Length == 1 && int.TryParse(tokens[0], out int result))
        {
            return result;
        }

        Stack<int> nums = new Stack<int>();

        foreach(string token in tokens)
        {
            if(int.TryParse(token, out int num))
            {
                nums.Push(num);
            }
            else
            {
                int a = nums.Pop();
                int b = nums.Pop();
                nums.Push
                (
                    token switch
                    {
                        "+" => b + a,
                        "-" => b - a,
                        "*" => b * a,
                        "/" => b / a
                    }
                );
            }
        }

        return nums.Pop();
    }
}
