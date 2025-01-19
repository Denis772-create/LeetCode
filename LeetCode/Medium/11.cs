namespace LeetCode.Medium;

public class _11
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            // Calculate the area
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            // Update maxArea if the current area is greater
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer pointing to the shorter line inward
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
