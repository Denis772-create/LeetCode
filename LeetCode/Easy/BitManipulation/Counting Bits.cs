namespace LeetCode.Easy.BitManipulation;

public class Solution
{
    public int[] CountBits(int n)
    {
        var ans = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            var x = i;
            var count = 0;
            
            // Считаем количество единиц в двоичном представлении i
            while (x > 0)
            {
                count += x & 1; // прибавляем младший бит
                x >>= 1;        // сдвигаем вправо
            }
            ans[i] = count;
        }
        return ans;
    }
}