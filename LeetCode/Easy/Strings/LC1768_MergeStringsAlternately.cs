namespace LeetCode.Easy.Strings;

/// <summary>
/// 1768. Merge Strings Alternately
/// Задача: даны строки word1 и word2. Объедините их поочередно, начиная с word1.
/// Если одна строка длиннее, оставшиеся символы добавьте в конец результата.
///
/// Подход (два указателя): идем по индексам i от 0 до max(len1, len2),
/// если индекс в пределах word1 — добавляем символ из word1, если в пределах word2 — из word2.
///
/// Сложность:
/// - Время: O(n), где n = len(word1) + len(word2)
/// - Память: O(n) под результат
/// </summary>
public class Lc1768MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new System.Text.StringBuilder(word1.Length + word2.Length);
        int i = 0, j = 0;

        // 1) Добавляем по одному символу из обеих строк, если они остались
        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                result.Append(word1[i]);
                i++;
            }

            if (j < word2.Length)
            {
                result.Append(word2[j]);
                j++;
            }
        }

        // 2) Возвращаем собранную строку
        return result.ToString();
    }
}


