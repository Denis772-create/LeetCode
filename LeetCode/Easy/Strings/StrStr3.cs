namespace LeetCode.Easy.Strings;

/// <summary>
/// 28. Find the Index of the First Occurrence in a String
/// Условие: найти индекс первого вхождения подстроки needle в строку haystack. Если needle не найдена, вернуть -1.
///
/// Подход (наивный поиск):
/// 1. Проходим по haystack от позиции i = 0 до i = haystack.Length - needle.Length.
/// 2. Для каждой позиции сравниваем подстроку haystack[i..i+needle.Length] с needle.
/// 3. Если все символы совпадают → возвращаем i.
/// 4. Если не нашли → возвращаем -1.
///
/// Сложность:
/// - Время: O(n * m), где n = len(haystack), m = len(needle)
/// - Память: O(1)
///
/// Пример 1:
/// Input: haystack = "sadbutsad", needle = "sad"
/// Output: 0
/// Объяснение: "sad" встречается в позиции 0 и 6. Первое вхождение на позиции 0.
///
/// Пример 2:
/// Input: haystack = "leetcode", needle = "leeto"
/// Output: -1
/// Объяснение: "leeto" не найдена в "leetcode"
/// </summary>
public class StrStr3
{
    public int StrStr(string haystack, string needle)
    {
        // Если needle пустая строка — по правилам вернуть 0
        if (needle.Length == 0)
            return 0;

        // Если needle длиннее, чем haystack — она точно не поместится
        if (needle.Length > haystack.Length)
            return -1;
        
        // Проходим по haystack
        // i — это позиция, откуда мы пробуем начать сравнение
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            // Считаем, что совпадение есть, пока не доказано обратное
            bool match = true;
            
            // Проверяем каждый символ needle
            for (int j = 0; j < needle.Length; j++)
            {
                // Если хоть один символ не совпадает — это НЕ то место
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                return i;
            }
        }
        
        // Если дошли до конца и не нашли needle — возвращаем -1
        return -1;
    }
}