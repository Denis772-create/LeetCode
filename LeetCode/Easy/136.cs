namespace LeetCode.Easy;

internal class _136
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result = result ^ num; // XOR each number
        }
        return result;
    }
}
