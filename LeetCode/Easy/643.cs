namespace LeetCode.Easy;

public class _643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double currentSum = 0;
        for (int i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }

        double maxSum = currentSum;

        for (int i = k; i < nums.Length; i++)
        {
            currentSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum / k;
    }
}
