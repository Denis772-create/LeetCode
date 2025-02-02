namespace LeetCode.Medium;

public class _1493
{
    public int LongestSubarray(int[] nums)
    {
        int left = 0, zeroes = 0, maxLength = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                zeroes++;
            }

            while (zeroes > 1)
            {
                // More than one zero in the window is not allowed
                if (nums[left] == 0)
                {
                    zeroes--;
                }

                left++; // Shrink the window from the left
            }

            // Update the max length (excluding one element)
            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength;
    }
}