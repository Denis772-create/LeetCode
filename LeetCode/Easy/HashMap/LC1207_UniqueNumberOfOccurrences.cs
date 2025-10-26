namespace LeetCode.Easy.HashMap;

/// <summary>
/// 1207. Unique Number of Occurrences
/// Условие: проверить, все ли количества вхождений элементов массива уникальны.
///
/// Подход:
/// 1. Считаем количество вхождений каждого числа (через Dictionary).
/// 2. Добавляем каждое количество в HashSet.
///    Если при добавлении выясняется, что такая частота уже была — возвращаем false.
/// 3. Если все частоты уникальны — возвращаем true.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n)
///
/// Пример 1:
/// Input: arr = [1,2,2,1,1,3]
/// Частоты: {1:3, 2:2, 3:1}
/// Множество частот = {3,2,1} → все уникальны ✅
/// Output: true
///
/// Пример 2:
/// Input: arr = [1,2]
/// Частоты: {1:1, 2:1}
/// Множество частот = {1} → дубликат частоты ❌
/// Output: false
/// </summary>
public class Lc1207UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        // 1️⃣ Считаем частоты элементов
        var countByValue = new Dictionary<int, int>();
        foreach (var value in arr)
        {
            if (!countByValue.TryAdd(value, 1))
                countByValue[value]++; // если элемент уже был, увеличиваем счётчик
        }

        // 2️⃣ Проверяем уникальность частот через HashSet
        var seen = new HashSet<int>();
        foreach (var count in countByValue.Values)
        {
            // если частота уже встречалась → неуникально
            if (!seen.Add(count))
                return false;
        }

        // 3️⃣ Все частоты уникальны
        return true;
    }
}