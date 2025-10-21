namespace LeetCode.Easy.DynamicProgramming;

public class Solution
{
    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1 or 2:
                return 1;
        }

        int a = 0, b = 1, c = 1;
        for (var i = 3; i <= n; i++)
        {
            var d = a + b + c;
            a = b;
            b = c;
            c = d;
        }
        return c;
    }
}