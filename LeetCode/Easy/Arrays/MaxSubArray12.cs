namespace LeetCode.Easy.Arrays;

public class MaxSubArray12
{
    // [-2,1,-3,4,-1,2,1,-5,4]
    public int MaxSubArray(int[] nums)
    {
        int best = nums[0]; // лучшая сумма
        int cur = nums[0];  // текущая сумма

        for (int i = 1; i < nums.Length; i++)
        {
            // или продолжаем, или начинаем заново
            cur = Math.Max(nums[i], cur + nums[i]);
            best = Math.Max(best, cur);
        }

        return best;
    }
}