namespace LeetCode.Medium.Arrays;

/// <summary>
/// 334. Increasing Triplet Subsequence
/// Условие: существует ли возрастающая подпоследовательность длины 3?
///
/// Подход: поддерживаем два минимальных значения first и second. Если видим число больше second — ответ true.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// </summary>
public class Lc0334IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        int first = int.MaxValue, second = int.MaxValue;
        foreach (var x in nums)
        {
            if (x <= first) first = x;
            else if (x <= second) second = x;
            else return true;
        }
        return false;
    }
}


