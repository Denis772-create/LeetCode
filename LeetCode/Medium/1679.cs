namespace LeetCode.Medium;

public class _1679
{
    /// <summary>
    /// AI
    /// </summary>
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums); // Sort the array
        int left = 0;
        int right = nums.Length - 1;
        int operations = 0;

        while (left < right)
        {
            int sum = nums[left] + nums[right];

            if (sum == k)
            {
                // Pair found
                operations++;
                left++;
                right--;
            }
            else if (sum < k)
            {
                // Increase the smaller number
                left++;
            }
            else
            {
                // Decrease the larger number
                right--;
            }
        }

        return operations;
    }
}
