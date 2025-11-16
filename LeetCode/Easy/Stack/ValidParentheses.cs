namespace LeetCode.Easy.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) 
                    return false;
                
                var top = stack.Pop();
                
                switch (c)
                {
                    case ')' when top != '(':
                    case ']' when top != '[':
                    case '}' when top != '{':
                        return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}