namespace LeetCode.Medium.Arrays;

/// <summary>
/// 334. Increasing Triplet Subsequence
/// Условие: определить, существует ли возрастающая подпоследовательность длины 3
/// 
/// Подход:
/// 1. Заводим две переменные — first и second — для отслеживания минимальных чисел.
/// 2. Проходим по массиву:
///    - Если x ≤ first → обновляем first (новый минимум)
///    - Иначе если x ≤ second → обновляем second (кандидат на середину)
///    - Иначе (x > second) → значит, найдено число больше обоих, возвращаем true.
/// 
/// Сложность:
/// - Время: O(n)
/// - Память: O(1)
/// 
/// Пример:
/// Input: nums = [2,1,5,0,4,6]
/// Ход алгоритма:
/// - x=2 → first=2
/// - x=1 → first=1 (меньше)
/// - x=5 → second=5 (первый кандидат)
/// - x=0 → first=0 (ещё меньше)
/// - x=4 → second=4 (меньше 5)
/// - x=6 → 6 > second → ✅ возрастающая тройка найдена (0 < 4 < 6)
/// 
/// Output: true
/// 
/// Пример 2:
/// Input: nums = [5,4,3,2,1]
/// → ни одного возрастания из трёх нет → Output: false
/// </summary>
public class Lc0334IncreasingTripletSubsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var x in nums)
        {
            if (x <= first)
            {
                first = x;
            }
            else if (x <= second)
            {
                second = x;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}