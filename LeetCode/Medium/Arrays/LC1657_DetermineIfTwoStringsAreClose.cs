namespace LeetCode.Medium.Arrays;

/// <summary>
/// 1657. Determine if Two Strings Are Close
/// Определить, «близки» ли строки: можно ли получить одну из другой
/// операциями (A) перестановки символов и (B) «перераспределения» частот между уже существующими символами.
///
/// Критерий:
/// 1) Одинаковое множество символов (никаких новых символов появиться не может).
/// 2) Одинаковое мультимножество частот (частоты можно «поменять местами» между символами).
///
/// Сложность:
/// - Время: O(n log n) из-за сортировки частот
/// - Память: O(k), где k — число разных символов
///
/// Пример 1:
/// word1 = "abbzzca", word2 = "babzzcz" → true
/// - Множества символов: {a,b,c,z} == {a,b,c,z}
/// - Частоты (после сортировки): [1,1,2,3] == [1,1,2,3]
///
/// Пример 2:
/// word1 = "a", word2 = "aa" → false (разная длина → разные суммы частот)
///
/// Пример 3:
/// word1 = "cabbba", word2 = "abbccc" → true
/// - Сеты равны; частоты {a:1,b:3,c:2} ↔ {a:1,b:2,c:3} (мультимножества частот совпадают)
/// </summary>
public class Lc1657DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        // Базовая проверка: суммы частот (длины) должны совпадать
        if (word1.Length != word2.Length) return false;

        // 1) Проверяем равенство множеств символов
        var set1 = new HashSet<char>(word1);
        var set2 = new HashSet<char>(word2);
        if (!set1.SetEquals(set2)) return false;

        // 2) Считаем частоты и сравниваем мультимножества частот (через сортировку списков)
        var freq1 = Count(word1); // например, {a:1, b:3, c:2} → [1,3,2]
        var freq2 = Count(word2);
        freq1.Sort();             // → [1,2,3]
        freq2.Sort();             // → [1,2,3]

        if (freq1.Count != freq2.Count) 
            return false;

        for (int i = 0; i < freq1.Count; i++)
        {
            if (freq1[i] != freq2[i])
                return false;
        }

        return true;
    }

    // Подсчёт частот символов → список значений частот
    private static List<int> Count(string s)
    {
        var map = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!map.TryAdd(c, 1)) map[c]++; // TryAdd быстрее, чем ContainsKey + присваивание
        }
        return map.Values.ToList();
    }
}
