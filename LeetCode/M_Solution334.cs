namespace LeetCode;

internal class M_Solution334
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3) return false;

        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= first)
                first = num;
            else if (num <= second)
                second = num;
            else
                return true;
        }
        return false;
    }
}