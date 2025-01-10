namespace LeetCode.Medium;

internal class M_Solution238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        // First pass: calculate left products
        int leftProduct = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = leftProduct;
            leftProduct *= nums[i];
        }

        // Second pass: calculate right products and multiply with left products
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return answer;
    }
}