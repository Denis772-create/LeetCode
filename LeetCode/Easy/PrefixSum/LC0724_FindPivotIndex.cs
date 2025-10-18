namespace LeetCode.Easy.PrefixSum;

/// <summary>
/// 724. Find Pivot Index
/// Условие: найти индекс, где сумма слева равна сумме справа.
///
/// Подход: предварительно считаем total. Идём слева, поддерживая leftSum.
/// Для индекса i правая сумма = total - leftSum - nums[i]. Сравниваем.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0724FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int total = nums.Sum();
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = total - leftSum - nums[i];
            if (leftSum == rightSum) return i;
            leftSum += nums[i];
        }
        return -1;
    }
}


