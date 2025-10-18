namespace LeetCode.Easy.Arrays;

/// <summary>
/// 2215. Find the Difference of Two Arrays
/// Условие: вернуть элементы, уникальные для каждого из массивов (без дубликатов).
///
/// Подход: приводим к множествам A и B, тогда ответ — [A\B, B\A].
///
/// Сложность:
/// - Время: O(n + m)
/// - Память: O(n + m)
/// </summary>
public class Lc2215FindTheDifferenceOfTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var a = new HashSet<int>(nums1);
        var b = new HashSet<int>(nums2);

        var onlyA = new List<int>();
        var onlyB = new List<int>();

        foreach (var x in a) if (!b.Contains(x)) onlyA.Add(x);
        foreach (var y in b) if (!a.Contains(y)) onlyB.Add(y);

        return new List<IList<int>> { onlyA, onlyB };
    }
}


