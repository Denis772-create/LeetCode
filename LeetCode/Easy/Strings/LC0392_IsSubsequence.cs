namespace LeetCode.Easy.Strings;

/// <summary>
/// 392. Is Subsequence
/// Условие: проверить, является ли строка s подпоследовательностью строки t.
///
/// Подход (два указателя):
/// 1. Заводим два индекса: i для s и j для t.
/// 2. Проходим по t. Если s[i] == t[j], увеличиваем i.
/// 3. После прохода, если i == s.Length, значит все символы из s найдены.
///
/// Сложность:
/// - Время: O(|t|)
/// - Память: O(1)
///
/// Пример:
/// Input: s = "abc", t = "ahbgdc"
/// Output: true
/// Объяснение:
/// Можно удалить 'h', 'g', 'd', 'c' останутся в порядке "abc".
///
/// Ещё пример:
/// Input: s = "axc", t = "ahbgdc"
/// Output: false
/// Объяснение:
/// Символ 'x' отсутствует в t.
/// </summary>
public class Lc0392IsSubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }
            j++;
        }
        return i == s.Length;
    }
}