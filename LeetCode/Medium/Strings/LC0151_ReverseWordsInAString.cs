namespace LeetCode.Medium.Strings;

/// <summary>
/// 151. Reverse Words in a String
/// Условие: перевернуть порядок слов в строке.  
/// Пробелы между словами нормализовать (один пробел между словами,  
/// без лишних пробелов в начале и в конце).
///
/// Подход:
/// 1. Разбиваем строку по пробелам.
/// 2. Убираем пустые элементы (если было несколько пробелов подряд).
/// 3. Разворачиваем порядок слов.
/// 4. Объединяем обратно через один пробел.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n)
///
/// Пример 1:
/// Input:  s = "  the sky  is blue  "
/// Output: "blue is sky the"
///
/// Пример 2:
/// Input:  s = "hello world"
/// Output: "world hello"
///
/// Объяснение:
/// - Разделяем → ["hello", "world"]
/// - Разворачиваем → ["world", "hello"]
/// - Соединяем → "world hello"
/// </summary>
public class Lc0151ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        // 1️⃣ Разбиваем по пробелам
        var parts = s.Split(' ');

        // 2️⃣ Переворачиваем и убираем пустые строки (если было несколько пробелов подряд)
        var reversed = parts.Reverse().Where(x => x.Length > 0);

        // 3️⃣ Собираем обратно через один пробел
        return string.Join(" ", reversed);
    }
}