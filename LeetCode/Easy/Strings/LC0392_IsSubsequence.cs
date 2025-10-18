namespace LeetCode.Easy.Strings;

/// <summary>
/// 392. Is Subsequence
/// Условие: проверить, является ли строка s подпоследовательностью строки t.
///
/// Подход (два указателя): двигаем i по s и j по t. Если s[i] == t[j],
/// увеличиваем i. В конце ответ: i == s.Length.
///
/// Сложность:
/// - Время: O(|t|)
/// - Память: O(1)
/// </summary>
public class Lc0392IsSubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j]) i++;
            j++;
        }
        return i == s.Length;
    }
}


