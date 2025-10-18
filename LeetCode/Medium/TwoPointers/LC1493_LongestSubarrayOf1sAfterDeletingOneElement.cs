namespace LeetCode.Medium.TwoPointers;

/// <summary>
/// 1493. Longest Subarray of 1's After Deleting One Element
/// Условие: удалить ровно один элемент, максимизируя длину подмассива из единиц.
///
/// Подход (скользящее окно/два указателя): держим не более одного нуля в окне.
/// Ответ — максимальный (right - left) с не более чем одним нулём внутри.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc1493LongestSubarrayOf1sAfterDeletingOneElement
{
    public int LongestSubarray(int[] nums)
    {
        int left = 0, zeros = 0, best = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0) zeros++;
            while (zeros > 1)
            {
                if (nums[left] == 0) zeros--;
                left++;
            }
            if (right - left > best) best = right - left; // минус один удалённый
        }
        return best;
    }
}


