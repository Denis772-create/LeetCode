namespace LeetCode.Easy.SlidingWindow;

/// <summary>
/// 643. Maximum Average Subarray I
/// Условие: найти максимальное среднее значение подмассива длины k.
///
/// Подход (скользящее окно): поддерживаем сумму текущего окна длины k,
/// при каждом шаге добавляем новый элемент и вычитаем уходящий.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0643MaximumAverageSubarrayI
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double windowSum = 0;
        for (int i = 0; i < k; i++) windowSum += nums[i];
        double maxSum = windowSum;
        for (int i = k; i < nums.Length; i++)
        {
            windowSum += nums[i] - nums[i - k];
            if (windowSum > maxSum) maxSum = windowSum;
        }
        return maxSum / k;
    }
}


