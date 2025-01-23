namespace LeetCode.Medium;

internal class _1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, right = 0, maxLength = 0, zerosCount = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                zerosCount++;
            }

            while (zerosCount > k)
            {
                if (nums[left] == 0)
                {
                    zerosCount--;
                }
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);

            right++;
        }

        return maxLength;
    }
}
