namespace LeetCode.Medium.Strings;

/// <summary>
/// 151. Reverse Words in a String
/// Условие: перевернуть порядок слов (пробелы нормализовать, лишние убрать).
///
/// Подход: split по пробелам, фильтруем пустые, меняем порядок, join одним пробелом.
///
/// Сложность:
/// - Время: O(n)
/// - Память: O(n)
/// </summary>
public class Lc0151ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        var parts = s.Split(' ');
        var reversed = parts.Reverse().Where(x => x.Length > 0);
        return string.Join(" ", reversed);
    }
}


