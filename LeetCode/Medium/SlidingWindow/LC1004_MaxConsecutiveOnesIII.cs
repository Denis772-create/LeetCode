namespace LeetCode.Medium.SlidingWindow;

/// <summary>
/// 1004. Max Consecutive Ones III
/// Условие: можно заменить до k нулей на единицы. Найти максимальную длину окна из единиц.
///
/// Подход (скользящее окно): расширяем правый указатель, считаем нули, когда > k — сужаем слева.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc1004MaxConsecutiveOnesIII
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, zeros = 0, best = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0) zeros++;
            while (zeros > k)
            {
                if (nums[left] == 0) zeros--;
                left++;
            }
            int length = right - left + 1;
            if (length > best) best = length;
        }
        return best;
    }
}


