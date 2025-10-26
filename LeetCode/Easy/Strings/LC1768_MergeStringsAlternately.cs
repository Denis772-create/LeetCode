using System.Text;

namespace LeetCode.Easy.Strings;

/// <summary>
/// 1768. Merge Strings Alternately
/// Задача: даны строки word1 и word2. Объедините их поочередно, начиная с word1.
/// Если одна строка длиннее, оставшиеся символы добавьте в конец результата.
///
/// Подход (два указателя):
/// 1. Заводим индексы i и j для word1 и word2.
/// 2. Пока не закончились обе строки — поочередно добавляем символы.
/// 3. Если одна строка короче, остаток второй просто добавится.
///
/// Сложность:
/// - Время: O(n), где n = len(word1) + len(word2)
/// - Память: O(n) под результат
///
/// Пример:
/// Input: word1 = "abc", word2 = "pqr"
/// Output: "apbqcr"
///
/// Ещё пример:
/// Input: word1 = "ab", word2 = "pqrs"
/// Output: "apbqrs"
/// Объяснение:
/// После чередования "apbq" остаются "rs" из второй строки, они добавляются в конец.
/// </summary>
public class Lc1768MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder(word1.Length + word2.Length);
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


