namespace LeetCode.Medium.TwoPointers;

/// <summary>
/// 1679. Max Number of K-Sum Pairs
/// Условие: максимизировать число пар с суммой k. Один элемент — в одной паре.
///
/// Подход: сортируем, ставим два указателя и сводим к классической парной сумме.
///
/// Сложность:
/// - Время: O(n log n) из-за сортировки
/// - Память: O(1) доп.
/// </summary>
public class Lc1679MaxNumberOfKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        System.Array.Sort(nums);
        int left = 0, right = nums.Length - 1, ops = 0;
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum == k) { ops++; left++; right--; }
            else if (sum < k) left++; else right--;
        }
        return ops;
    }
}


