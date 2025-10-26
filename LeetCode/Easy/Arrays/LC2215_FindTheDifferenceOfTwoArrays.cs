namespace LeetCode.Easy.Arrays;

/// <summary>
/// 2215. Find the Difference of Two Arrays
/// Условие: вернуть элементы, уникальные для каждого из массивов (без дубликатов).
///
/// Подход:
/// 1. Преобразуем оба массива в множества A и B (чтобы убрать дубликаты).
/// 2. Разница множеств даёт уникальные элементы:
///    - только в A: A \ B
///    - только в B: B \ A
///
/// Сложность:
/// - Время: O(n + m)
/// - Память: O(n + m)
///
/// Пример:
/// Input: nums1 = [1,2,3], nums2 = [2,4,6]
/// Output: [[1,3],[4,6]]
/// Объяснение:
/// - В первом массиве уникальны 1 и 3.
/// - Во втором массиве уникальны 4 и 6.
/// </summary>
public class Lc2215FindTheDifferenceOfTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var a = new HashSet<int>(nums1);
        var b = new HashSet<int>(nums2);

        var onlyA = new List<int>();
        var onlyB = new List<int>();

        foreach (var x in a)
        {
            if (!b.Contains(x)) 
                onlyA.Add(x);
        }

        foreach (var y in b)
        {
            if (!a.Contains(y)) 
                onlyB.Add(y);
        }

        return new List<IList<int>> { onlyA, onlyB };
    }
}