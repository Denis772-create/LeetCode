namespace LeetCode.Easy;

public class _724
{
    public int PivotIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum() - nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                if (leftSum == rightSum)
                {
                    return 0;
                }
                else
                {
                    continue;
                }
            }

            leftSum += nums[i - 1];
            rightSum -= nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}
