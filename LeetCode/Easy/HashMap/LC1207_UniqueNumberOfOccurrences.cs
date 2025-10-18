namespace LeetCode.Easy.HashMap;

/// <summary>
/// 1207. Unique Number of Occurrences
/// Условие: проверить, все ли количества вхождений элементов массива уникальны.
///
/// Подход: считаем частоты в словаре, затем пытаемся добавить каждую частоту в HashSet.
/// Если добавление не удалось (частота уже была) — вернём false.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n)
/// </summary>
public class Lc1207UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        var countByValue = new Dictionary<int, int>();
        foreach (var value in arr)
        {
            if (!countByValue.TryAdd(value, 1))
                countByValue[value]++;
        }

        var seen = new HashSet<int>();
        foreach (var count in countByValue.Values)
        {
            if (!seen.Add(count)) return false;
        }
        return true;
    }
}


