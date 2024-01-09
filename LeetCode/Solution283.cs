namespace LeetCode;

internal class Solution283
{
    public void MoveZeroes(int[] nums)
    {
        // 'position' tracks the index where the next non-zero element should be placed.
        var position = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != position)
                {
                    // Swap the non-zero element with the zero at the 'position' index.
                    nums[position] = nums[i];
                    nums[i] = 0;
                }
                position++;
            }
        }
    }
}